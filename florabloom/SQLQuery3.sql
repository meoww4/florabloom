-- Таблица Каталога
CREATE TABLE Catalog_Tbl (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100) NOT NULL,
    Price INT NOT NULL,
    ImagePath NVARCHAR(255) NOT NULL
);
INSERT INTO CatalogTb (Title, Price, ImagePath)
VALUES 
(N'Романтика', 3500, 'image/flower1.jpg'),
(N'Весенний бриз', 2800, 'image/flower2.jpg'),
(N'Летняя палитра', 3200, 'image/flower3.jpg'),
(N'Элегантность', 4000, 'image/flower4.jpg'),
(N'Аромат лета', 3800, 'image/flower5.jpg'),
(N'Солнечный день', 2990, 'image/flower6.jpg'),
(N'Очарование', 3450, 'image/flower7.jpg'),
(N'Тёплый вечер', 3150, 'image/flower8.jpg'),
(N'Летняя фантазия', 2650, 'image/flower9.jpg'),
(N'Полевые цветы', 2800, 'image/flower10.jpg'),
(N'Фиалковый бриз', 3600, 'image/flower11.jpg'),
(N'Малиновый звон', 2900, 'image/flower12.jpg'),
(N'Фруктовый рассвет', 3250, 'image/flower13.jpg'),
(N'Цветочная классика', 2750, 'image/flower14.jpg'),
(N'Шоколад и крем', 3990, 'image/flower15.jpg');

SELECT Id, Title, Price, ImagePath FROM CatalogTb
