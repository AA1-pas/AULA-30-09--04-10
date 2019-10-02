select modelo.Codigo, modelo.Modelo, Marcas.Nome as 'Marca', Tipos.Nome from ModelosVeiculos modelo left join Marcas on Marcas.Codigo = modelo.MarcaCodigo
																							       left join Tipos on Tipos.Codigo = modelo.TipoCodigo
																								   where Marcas.Codigo = 20 and Tipos.Codigo = 1