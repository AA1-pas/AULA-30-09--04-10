select * from Tipos
select * from Marcas
select * from ModelosVeiculos 
select * from ModelosVeiculos vei inner join Marcas mar on vei.MarcaCodigo =  mar.Codigo
								  inner join Tipos tip on mar.TipoCodigo = tip.Codigo
select vei.Id, vei.Modelo, mar.Nome as 'Marca',tip.Nome as 'Tipo' from ModelosVeiculos vei inner join Marcas mar on vei.MarcaCodigo =  mar.Codigo
																                    		inner join Tipos tip on mar.TipoCodigo = tip.Codigo
select vei.Id, vei.Modelo, mar.Nome as 'Marca',tip.Nome as 'Tipo' from ModelosVeiculos vei inner join Marcas mar on vei.MarcaCodigo =  mar.Codigo
																                    		inner join Tipos tip on mar.TipoCodigo = tip.Codigo
																							where mar.Codigo = 20 -- Moto Kawasaki
select vei.Id, vei.Modelo, mar.Nome as 'Marca',tip.Nome as 'Tipo' from ModelosVeiculos vei inner join Marcas mar on vei.MarcaCodigo =  mar.Codigo
																                    		inner join Tipos tip on mar.TipoCodigo = tip.Codigo
																							where mar.Codigo = 10 -- Carro Kia