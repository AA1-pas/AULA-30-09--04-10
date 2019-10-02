select car.Modelo, mar.Nome as 'Marca',usu.Nome as 'Usuário Criação', usu2.Nome as 'Usuário Alteração' from Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo
																													   inner join Usuarios usu on car.UsuarioCriacao = usu.Id
																													   inner join Usuarios usu2 on car.UsuarioAlteracao = usu2.Id

select car.Modelo, mar.Nome as 'Marca',usu.Nome as 'Usuário Criação', usu2.Nome as 'Usuário Alteração' from Carros car left join Marcas mar on car.MarcaCodigo = mar.Codigo
																													   left join Usuarios usu on car.UsuarioCriacao = usu.Id
																													   left join Usuarios usu2 on car.UsuarioAlteracao = usu2.Id