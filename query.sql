USE Test

CREATE TABLE [dbo].[products](
	[id] [int] PRIMARY KEY,
	[name] [NVARCHAR](255)
	);

INSERT INTO [dbo].[products]
VALUES
(1, 'Tomb Raider'),
(2, 'Game of Thrones'),
(3, 'Skyrim'),
(4, 'MS SQL SERVER');

CREATE TABLE [dbo].[categories] (
[id] [int] PRIMARY KEY,
[name] [NVARCHAR](255)
);

INSERT INTO [dbo].[categories]
VALUES
(1, 'Series'),
(2, 'Film'),
(3, 'Game'),
(4, 'Anime');

CREATE TABLE [dbo].[product_categories] (
[product_id] [int] FOREIGN KEY REFERENCES [dbo].[products]([id]),
[category_id] [int],
PRIMARY KEY ([product_id], [category_id])
);

INSERT INTO [dbo].[product_categories]
VALUES
(1, 2),
(1, 3),
(2, 1),
(3, 3),
(4, 777);

SELECT p.[name], c.[name]
FROM [products] p
LEFT JOIN [product_categories] pc
ON p.[id] = pc.[product_id]
LEFT JOIN [categories] c
ON pc.[category_id] = c.[id];