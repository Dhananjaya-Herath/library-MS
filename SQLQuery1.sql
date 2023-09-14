CREATE TABLE books(
id INT PRIMARY KEY IDENTITY(1,1),
book_title VARCHAR(MAX) NULL,
author VARCHAR(MAX) NULL,
published_date VARCHAR(MAX) NULL,
status VARCHAR(MAX) NULL,
date_insert VARCHAR(MAX) NULL,
date_update VARCHAR(MAX) NULL,
date_delete VARCHAR(MAX) NULL,
)

SELECT * FROM books WHERE date_delete IS NULL