select car.Modelo, mar.Nome, car.Placa, car.Ano from Carros car inner join Marcas mar on car.MarcaCodigo = mar.Codigo

select car.Modelo, mar.Nome, car.Placa, car.Ano from Carros car left join Marcas mar on car.MarcaCodigo = mar.Codigo

select car.Modelo, mar.Nome, car.Placa, car.Ano from Carros car right join Marcas mar on car.MarcaCodigo = mar.Codigo