select * from Livros

UPDATE Livros SET Ativo = 0 
WHERE Id = (SELECT Id FROM Livros Where Id = 1 ORDER BY id DESC
OFFSET 1 ROWS FETCH NEXT 1 ROWS ONLY)

select * from Livros