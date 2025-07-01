using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static florabloom.Functions;

namespace florabloom
{
    public partial class Order : Form
    {
        private readonly Dictionary<int, int> _items;
        private Functions Con;
        private Label totalLbl;
        private Panel itemsPanel;
        private FlowLayoutPanel flowLayoutPanel;
        private Label deliveryLbl;
        private Label orderNumberLbl;
        private bool isDragging;
        private Point dragStart;

        private Panel panel1;
        private Button closeButton;

        public Order(Dictionary<int, int> items)
        {
            _items = items;
            Con = new Functions();
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Панель для перетаскивания
            panel1 = new Panel
            {
                Size = new Size(this.Width, 30),
                Location = new Point(0, 0),
                BackColor = Color.LightGray
            };

            panel1.MouseDown += (s, e) => { isDragging = true; dragStart = new Point(e.X, e.Y); };
            panel1.MouseMove += (s, e) => { if (isDragging) Location = new Point(Location.X + e.X - dragStart.X, Location.Y + e.Y - dragStart.Y); };
            panel1.MouseUp += (s, e) => isDragging = false;
            this.Controls.Add(panel1);

            // Кнопка закрытия (вместо Guna2Button)
            closeButton = new Button
            {
                Text = "Закрыть",
                Size = new Size(100, 30),
                Location = new Point(10, 590),
                Font = new Font("Trebuchet MS", 10, FontStyle.Bold),
                BackColor = Color.LightGray,
                FlatStyle = FlatStyle.Flat
            };
            closeButton.Click += closeButton_Click;
            this.Controls.Add(closeButton);

            Random rand = new Random();
            int orderNumber = rand.Next(100000, 999999);

            deliveryLbl = new Label
            {
                Text = $"Доставка ожидается к {DateTime.Now.AddDays(3):dd.MM.yyyy}",
                Font = new Font("Trebuchet MS", 12, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                AutoSize = true,
                Location = new Point(237, 32)
            };

            orderNumberLbl = new Label
            {
                Text = $"Номер заказа: {orderNumber}",
                Font = new Font("Trebuchet MS", 12, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                AutoSize = true,
                Location = new Point(237, 52)
            };

            itemsPanel = new Panel
            {
                Location = new Point(237, 80),
                Size = new Size(758, 500),
                AutoScroll = true,
                BorderStyle = BorderStyle.None
            };
            itemsPanel.VerticalScroll.Enabled = true;
            itemsPanel.VerticalScroll.Visible = true;

            flowLayoutPanel = new FlowLayoutPanel
            {
                Location = new Point(0, 0),
                Size = new Size(740, _items.Count * 130),
                FlowDirection = FlowDirection.TopDown,
                AutoSize = false,
                WrapContents = false
            };

            totalLbl = new Label
            {
                Text = "Общая сумма: 0 ₽",
                Font = new Font("Trebuchet MS", 14, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Location = new Point(237, 590)
            };

            itemsPanel.Controls.Add(flowLayoutPanel);
            this.Controls.AddRange(new Control[] { deliveryLbl, orderNumberLbl, itemsPanel, totalLbl });

            LoadItems();
        }

        private void LoadItems()
        {
            decimal totalPrice = 0;

            foreach (var item in _items)
            {
                int bouquetId = item.Key;
                int quantity = item.Value;
                string query = $"SELECT Title, Price, ImagePath FROM CatalogTb WHERE Id = {bouquetId}";
                var dt = Con.GetData(query);

                if (dt.Rows.Count > 0)
                {
                    var row = dt.Rows[0];
                    string title = row["Title"].ToString();
                    decimal price = Convert.ToDecimal(row["Price"]);
                    string imgPath = row["ImagePath"].ToString();
                    decimal itemTotal = price * quantity;
                    totalPrice += itemTotal;

                    var itemPanel = new Panel
                    {
                        Size = new Size(700, 120),
                        Margin = new Padding(10)
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Size = new Size(100, 100),
                        Location = new Point(10, 10),
                        SizeMode = PictureBoxSizeMode.Zoom
                    };

                    string fullPath = Path.Combine(Application.StartupPath, imgPath);
                    if (File.Exists(fullPath))
                    {
                        Image img = Image.FromFile(fullPath);
                        pictureBox.Image = CreateRoundedImage(img, 15);
                    }

                    Label titleLbl = new Label
                    {
                        Text = $"{title} (x{quantity})",
                        Font = new Font("Trebuchet MS", 12),
                        AutoSize = true,
                        Location = new Point(120, 20)
                    };

                    Label priceLbl = new Label
                    {
                        Text = $"{itemTotal} ₽",
                        Font = new Font("Trebuchet MS", 12, FontStyle.Bold),
                        AutoSize = true,
                        Location = new Point(120, 50)
                    };

                    itemPanel.Controls.AddRange(new Control[] { pictureBox, titleLbl, priceLbl });
                    flowLayoutPanel.Controls.Add(itemPanel);
                }
            }

            totalLbl.Text = $"Общая сумма: {totalPrice} ₽";
        }

        private Image CreateRoundedImage(Image image, float radius)
        {
            Bitmap bitmap = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
                    path.AddArc(image.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
                    path.AddArc(image.Width - radius * 2, image.Height - radius * 2, radius * 2, radius * 2, 0, 90);
                    path.AddArc(0, image.Height - radius * 2, radius * 2, radius * 2, 90, 90);
                    path.CloseFigure();
                    g.SetClip(path);
                    g.DrawImage(image, 0, 0, image.Width, image.Height);
                }
            }
            return bitmap;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            
        }
    }
}
