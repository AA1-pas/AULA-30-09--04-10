insert into Usuarios
(Nome, Login, Senha)
values
('Jose Maria', 'jose', '562314')

update Usuarios set Ativo = 0 where Id = 6 

GO

update Usuarios set Nome = 'Allan Ricardo Pasquali'  where Id in (6,9) 

GO

select Login,Ativo,Nome,Senha from Usuarios

select * from Usuarios where Ativo = 1


