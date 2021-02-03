/*select * from Produtos;
select * from Cesta;*/
select * from Clientes;
select * from Historico;

insert into Historico (
	CestaId, 
	Protocolo, 
	CodigoProduto,
	ImagemProduto,
	NomeProduto, 
	PrecoProduto,
	NomeCategoria,
	QuantidadeCesta) 
SELECT C.Id, C.Protocolo, P.Codigo, P.Imagem, P.Nome, P.Preco, CA.Nome, C.Quantidade
FROM Cesta C
INNER JOIN Produtos P ON C.ProdutoId = P.Id
INNER JOIN Categoria CA ON CA.Id = P.CategoriaId

delete from Clientes

/*update Produtos set Quantidade = 0 where id = 9
UPDATE Historico
SET ClienteId = C.Id
FROM Historico H
INNER JOIN Clientes C
ON H.Protocolo = C.Protocolo
select CONVERT(date, GETUTCDATE())*/