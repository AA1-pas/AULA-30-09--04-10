SELECT * FROM Marcas
SELECT * FROM Carros

select Modelo, (select Nome from Marcas where codigo = MarcaCodigo) as 'Marca',Placa,Ano from Carros Where MarcaCodigo =1