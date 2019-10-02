--insert into Pedidos(Numero,ClienteId,Valor) values ('P26O25140R',7,1.63), ('I52D02320Y',7,245816.09),('F83B02142M',7,118.99)   
--select * from Clientes
--select * from Pedidos
select ped.Numero, cli.Nome as 'Cliente', concat ('R$ ',ped.Valor) as Valor, ped.Ativo as 'Status' from Pedidos ped inner join Clientes cli on cli.Id = ped.ClienteId

select ped.Numero, cli.Nome as 'Cliente', ped.Valor, ped.Ativo as 'Status' from Pedidos ped inner join Clientes cli on cli.Id = ped.ClienteId

select ped.Numero, cli.Nome as 'Cliente', ped.Valor, ped.Ativo as 'Status' from Pedidos ped inner join Clientes cli on cli.Id = ped.ClienteId
																							where cli.Nome = 'José'

select  cli.Nome as 'Cliente', sum(ped.Valor) as 'Valor Total' from Pedidos ped inner join Clientes cli on cli.Id = ped.ClienteId
																				group by cli.Nome

select  cli.Nome,sum(ped.valor) as 'Valor Total', iif(sum(ped.Valor) > 200000, 'Ganhou um Xiaomi','Não Ganhou um Xiaomi') as 'Resultado' from Pedidos ped inner join Clientes cli on cli.Id = ped.ClienteId
																				group by cli.Nome   --where cli.Nome = 'Renata'--

select  cli.Nome,sum(ped.valor) as 'Valor Total', 
iif(sum(ped.Valor) > 200000, 'Ganhou um Xiaomi','Não Ganhou um Xiaomi') as 'Resultado'
from Clientes cli inner join Pedidos ped on cli.Id = ped.ClienteId
group by cli.Nome