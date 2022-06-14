--Criação das Tabelas

create table usuarios(
	codUsuario int identity(1,1) primary key,
	usuario nvarchar(30) NOT NULL,
    login nvarchar(30) NOT NULL,   
    senha nvarchar(30) NOT NULL,
	nivel int NOT NULL
);

create table tipos(
    codTipo int identity(1,1) primary key,
    tipo nvarchar(30) NOT NULL,
	codUsuario int
);

create table produtos(
    codProduto int identity(1,1) primary key,
    descricao nvarchar(30) NOT NULL,
    preco float,
    unidade nvarchar(2) NOT NULL,
    quantidade int,
	estoqueMinimo int,
    dataValidade datetime,
    codTipo int NOT NULL,
	codUsuario int
);

create table producoes(
    codProducao int identity(1,1) primary key,
	codProduto int NOT NULL,
    dataProducao datetime NOT NULL,
	quantidade int NOT NULL,
	codUsuario int
);

create table fornecedores(
    codFornecedor int identity(1,1) primary key,
    nomeRazao nvarchar(50) NOT NULL,
    nomeFantasia nvarchar(30) NOT NULL,
    cnpj nvarchar(15) NOT NULL,
    cep nvarchar(8) NOT NULL,
    uf nvarchar(2),
    cidade nvarchar(30),
    bairro nvarchar(30),
    endereco nvarchar(40),
    dataCadastro datetime NOT NULL,
	codUsuario int
);

create table solicitacoes(
    codSolicitacao int identity(1,1) primary key,
    codFornecedor int NOT NULL,
    dataPedido datetime NOT NULL,
    dataEntrega datetime,
    obs ntext,
	codUsuario int
);

create table vendas(
    codVenda int identity(1,1) primary key,
    dataVenda datetime NOT NULL,
	codUsuario int
);

create table itensSolicitacao(
    codSolicitacao int NOT NULL,
    codProduto int NOT NULL,
    quantidade float NOT NULL
);

create table itensVenda(
    codVenda int NOT NULL,
    codProduto int NOT NULL,
    quantidade float NOT NULL
);

--Criação das chaves estrangeiras
ALTER TABLE tipos
ADD CONSTRAINT tipos_usuarios_fk FOREIGN KEY (codUsuario) REFERENCES usuarios(codUsuario);

ALTER TABLE produtos
ADD CONSTRAINT produtos_tipos_fk FOREIGN KEY (codTipo) REFERENCES tipos(codTipo);
ALTER TABLE produtos
ADD CONSTRAINT produtos_usuarios_fk FOREIGN KEY (codUsuario) REFERENCES usuarios(codUsuario);

ALTER TABLE producoes
ADD CONSTRAINT producoes_produtos_fk FOREIGN KEY (codProduto) REFERENCES produtos(codProduto);
ALTER TABLE producoes
ADD CONSTRAINT producoes_usuarios_fk FOREIGN KEY (codUsuario) REFERENCES usuarios(codUsuario);

ALTER TABLE fornecedores
ADD CONSTRAINT fornecedores_usuarios_fk FOREIGN KEY (codUsuario) REFERENCES usuarios(codUsuario);

ALTER TABLE solicitacoes
ADD CONSTRAINT solicitacoes_fornecedores_fk FOREIGN KEY (codFornecedor) REFERENCES fornecedores(codFornecedor);
ALTER TABLE solicitacoes
ADD CONSTRAINT solicitacoes_usuarios_fk FOREIGN KEY (codUsuario) REFERENCES usuarios(codUsuario);

ALTER TABLE vendas
ADD CONSTRAINT vendas_usuarios_fk FOREIGN KEY (codUsuario) REFERENCES usuarios(codUsuario);

ALTER TABLE itensSolicitacao
ADD CONSTRAINT itensSolicitacao_solicitacoes_fk FOREIGN KEY (codSolicitacao) REFERENCES solicitacoes(codSolicitacao);
ALTER TABLE itensSolicitacao
ADD CONSTRAINT itensSolicitacao_produtos_fk FOREIGN KEY (codProduto) REFERENCES produtos(codProduto);
ALTER TABLE itensSolicitacao
ADD CONSTRAINT itensSolicitacao_pk PRIMARY KEY (codSolicitacao, codProduto);

ALTER TABLE itensVenda
ADD CONSTRAINT itensVenda_vendas_fk FOREIGN KEY (codVenda) REFERENCES vendas(codVenda);
ALTER TABLE itensVenda
ADD CONSTRAINT itensVenda_produtos_fk FOREIGN KEY (codProduto) REFERENCES produtos(codProduto);
ALTER TABLE itensVenda
ADD CONSTRAINT itensVenda_pk PRIMARY KEY (codVenda, codProduto);


--Dados

insert into usuarios values ('Gerente', 'admin', 'admin', 1);
insert into usuarios values ('Funcionário', 'user', 'user', 2);
insert into usuarios values ('Vendedor', 'user2', 'user2', 3);

insert into tipos values ('Produzido', 1);
insert into tipos values ('Ingrediente', 1);
insert into tipos values ('Terceiros', 1);

set dateformat dmy;
insert into produtoS values ('Pão', 7.5, 'KG', NULL, NULL, NULL, 1, 1);
insert into produtoS values ('Coca-Cola 2L', 8.5, 'UN', 150, 50, '20/11/2022', 3, 1);
insert into produtoS values ('Farinha de Trigo 1KG', NULL, 'UN', 75, 25, '06/11/2022', 2, 1);
insert into produtoS values ('Coca-Cola 350ml', 3, 'UN', 50, 20, '18/11/2022', 3, 1);
insert into produtoS values ('Mortadela Fatiada 200G', 10, 'UN', 30, 15, '07/06/2022', 3, 1);
insert into produtoS values ('Wafer Chocolate Bauducco', 3, 'UN', 50, 10, '22/11/2022', 3, 1);
insert into produtoS values ('Bolo', 15, 'KG', NULL, NULL, NULL, 1, 1);

set dateformat dmy;
insert into producoes values (1, '24/05/2022', 50, 1);
insert into producoes values (7, '24/05/2022', 15, 1);

set dateformat dmy;
insert into fornecedores values ('Farinha e Cia Ltda.', 'Farinha e Cia', 37753524000163, 69900150, 'AC', 'Rio Branco', 'Preventório', 'Rua Rio Grande do Sul', '21/05/2022', 2);
insert into fornecedores values ('Coca-Cola Indústrias Ltda.', 'Coca-Cola', 43246343000143, 62686974, 'CE', 'Paraipaba', 'Alagoinha', 'Rua Chico Cordeiro', '21/05/2022', 2);
insert into fornecedores values ('Sadia S.A.', 'Sadia', 64025187000160, 06465300, 'SP', 'Barueri', 'Jardim Santa Cecília', 'Rodovia Presidente Castelo Branco', '22/05/2022', 2);
insert into fornecedores values ('Pandurata Alimentos Ltda.', 'Bauducco', 93174378000192, 69316198, 'RR', 'Boa Vista', 'Nova Cidade', 'Rua NC-P', '22/05/2022', 2);

set dateformat dmy;
insert into solicitacoes values (1,  '21/05/2022', '24/05/2022', NULL, 2);
insert into solicitacoes values (2,  '21/05/2022', '28/05/2022', NULL, 2);
insert into solicitacoes values (3,  '21/05/2022', '28/05/2022', NULL, 2);
insert into solicitacoes values (4,  '22/05/2022', '25/05/2022', NULL, 2);
insert into solicitacoes values (1,  '24/05/2022', '27/05/2022', 'Baixa no estoque inesperada', 2);
insert into solicitacoes values (1,  '28/05/2022', '01/06/2022', NULL, 2);

set dateformat dmy;
insert into vendas values ('28/05/2022', 3);
insert into vendas values ('28/05/2022', 3);
insert into vendas values ('28/05/2022', 3);
insert into vendas values ('29/05/2022', 3);

insert into itensSolicitacao values (1, 3, 150);
insert into itensSolicitacao values (2, 2, 100);
insert into itensSolicitacao values (2, 4, 50);
insert into itensSolicitacao values (3, 5, 50);
insert into itensSolicitacao values (4, 6, 80);
insert into itensSolicitacao values (5, 3, 75);
insert into itensSolicitacao values (6, 3, 200);

insert into itensVenda values (1, 1, 0.8);
insert into itensVenda values (1, 2, 1);
insert into itensVenda values (2, 1, 1);
insert into itensVenda values (2, 2, 1);
insert into itensVenda values (2, 5, 1);
insert into itensVenda values (3, 6, 1);
insert into itensVenda values (4, 1, 0.6);
insert into itensVenda values (4, 4, 1);
insert into itensVenda values (4, 5, 1);


select * from usuarios;
select * from tipos;
select * from produtos;
select * from producoes;
select * from fornecedores;
select * from solicitacoes;
select * from vendas;
select * from itensSolicitacao;
select * from itensVenda;


-- FIM --

/*
--Índices
--Índice para os produtos mais vendidos
CREATE INDEX MaioresVendas ON itempedido (quantidade Desc, codProduto Asc);

--Índice par ver os produtos com maior quantidade de estoque
CREATE INDEX QuantidaProduto ON produto (quantidade Desc, codProduto Asc);


--3)
--a. Uma consulta usando junção de mais de 2 tabelas.
--Mostra o produto e a quantidade dele na venda com o codigo 1
select venda.codVenda, itemVenda.codProduto, itemVenda.quantidade, produto.descricao from venda
inner join itemVenda on venda.codVenda = itemVenda.codVenda
inner join produto on itemVenda.codProduto = produto.codProduto
where venda.codVenda = 1;

--b. Uma consulta que seja útil para a lógica de negócios usando totalização e uma função de data.
--Mostra os produtos e quantidade que foi vendido no dia.
select produto.descricao, sum(itemvenda.quantidade) as "Quantidade Vendida" from itemvenda
inner join produto on itemvenda.codProduto = produto.codProduto
inner join venda on venda.codvenda = itemvenda.codvenda
where extract(day from venda.datavenda) = extract(day from sysdate)
group by produto.descricao;

--c. Uma Visão que use junção e funções de totalização(Avg ou Min, Max, count ou Sum)
--Quantidade de vezes que um produto foi comprado em mais de 1 venda
create or replace view Padaria as
select itemVenda.codProduto, produto.descricao, count(itemVenda.codProduto) VezesComprado from itemVenda 
inner join produto on itemVenda.codProduto = produto.codProduto
group by itemVenda.codProduto, produto.descricao
having count(produto.codProduto) > 1;

select * from Padaria;

--d. Escreva uma consulta usando junção externa left join ou right join
--Produto que não está em nenhum pedido
select produto.codproduto, produto.descricao from produto
left join itempedido on produto.codproduto = itempedido.codproduto
where itempedido.codpedido is null;

--e. Escreva uma consulta usando o operador de União.
--Mostra os produtos Produzidos e os Ingredientes
select * from produto where codTipo = 1
union
select * from produto where codTipo = 2;

--f. Escreva uma consulta usando o operador Minus
--Mostra todos produtos que não sejam Ingredientes
select * from produto
minus
select * from produto where codTipo = 2;

--g. Escreva uma consulta usando o operador de intersecção
--Seleciona o codigo dos itens produzidos que foram comprados
select itemvenda.codproduto from itemVenda
intersect
select produto.codproduto from produto where codTipo = 1;






--4) Subconsultas
--a. Exemplo de um comando utilizando subconsultas que utilize o operador = ou <,>, <= etc. 
--Seleciona os Produtos com preço maior ou igual a media de preço de todos os produtos
select * from produto 
where preco >= (select avg(preco) from produto);


--b. Exemplo de um comando utilizando subconsultas que utilize o operador in. 
--Seleciona todos os produtos vendidos no mês 5
select * from produto where codProduto in 
(select itemVenda.codProduto from itemVenda 
inner join venda on itemVenda.codVenda = venda.codVenda
where extract(month from venda.dataVenda) = 5);

--c. Um comando utilizando subconsultas que utilize o operador not in. 
--Seleciona todos os produtos que não foram vendidos no mês 5
select * from produto where codProduto not in 
(select itemVenda.codProduto from itemVenda 
inner join venda on itemVenda.codVenda = venda.codVenda
where extract(month from venda.dataVenda) = 5);

--d. exemplo de um comando utilizando subconsultas que utilize o operador exists
--Selecionar vendas que venderam o produto 2
select * from venda 
where exists 
(select codproduto from itemvenda 
where venda.codvenda = itemvenda.codvenda and codproduto = 2);

--e. exemplo de uma subconsulta utilizada dentro de um comando Update.
--Adiciona 100 a quantidade de todos os itens pedido hoje
update itempedido set quantidade = quantidade + 100 
where codpedido in 
(select codpedido from pedido 
where extract(day from datapedido) = extract(day from sysdate));

--f. exemplo de uma subconsulta utilizada dentro de um comando Delete.
--Deleta todos os itens de pedidos realizados no dia
delete from itempedido where codpedido in
(select codpedido from pedido
where extract(day from datapedido) = extract(day from sysdate));


--1. Parte PL/SQL 
--Não se esqueça de indicar o objetivo de cada procedimento criado nos itens abaixo.

Create table logPadaria(
    datalog date,
    campo1 varchar2(60),
    campo2 varchar2(60)
 );

Create table ErroPadaria(
    dataerro date,
    mensagem varchar2(50)
);

create table backupProduto(
    codProduto NUMBER(4,0),
    descricao VARCHAR2(30) NOT NULL,
    preco NUMBER(6,2),
    unidade VARCHAR2(2) NOT NULL,
    quantidade NUMBER(4,0),
    dataProducao DATE,
    dataValidade DATE,
    codTipo NUMBER(4,0) NOT NULL
);

--a. Escreva uma Stored Procedure que realize algum procedimento que seja útil implementar reuso para a aplicação e indique uma forma de testá-la.
--Registra o produto mais vendido do dia selecionado e a quantidade
create or replace procedure SP_PadariaValidade (data date)
as
    nome produto.descricao%type;
    qtd number;
    --d date;
begin

    --d := to_date(data, 'DD/MM/YYYY');
    
    select * into nome from 
    (select produto.descricao from venda
    inner join itemvenda on venda.codvenda = itemvenda.codvenda
    inner join produto on itemvenda.codproduto = produto.codproduto
    where venda.datavenda = data
    group by produto.descricao, itemvenda.codproduto
    order by sum(itemvenda.quantidade) desc)
    where rownum = 1;
    
    select * into qtd from 
    (select sum(itemvenda.quantidade) as t from venda
    inner join itemvenda on venda.codvenda = itemvenda.codvenda
    inner join produto on itemvenda.codproduto = produto.codproduto
    where venda.datavenda = data
    group by produto.descricao, itemvenda.codproduto
    order by t desc)
    where rownum = 1;
    
    insert into logpadaria values(sysdate, 'Produto mais vendido no dia ' || data, 'Nome: ' || nome || ' - Quantidade: ' || qtd);

exception
when no_data_found then
    insert into erropadaria values (sysdate, 'Sem vendas no dia ' || data);
end;

exec SP_PadariaValidade('28/05/2021');

--b. Escreva um trigger que faça a replicação síncrona de dados de uma tabela para outra em caso de inserção, alteração ou exclusão.
--Backup da tabela produto toda vez que um produto é alterado ou deletado
CREATE OR REPLACE TRIGGER TR_BackupPadaria
BEFORE UPDATE OR DELETE ON produto
FOR EACH ROW 
DECLARE
    qtd number;
BEGIN
    select count(*) into qtd from backupproduto where codproduto = :old.codproduto;
    
    if qtd = 1 then
        update backupproduto set 
        preco = :old.preco, unidade = :old.unidade, descricao = :old.descricao, quantidade = :old.quantidade, dataproducao = :old.dataproducao, datavalidade = :old.datavalidade, codtipo = :old.codtipo
        where codproduto = :old.codproduto;
    else
        insert into backupproduto values (:old.codproduto, :old.preco, :old.unidade, :old.descricao, :old.quantidade, :old.dataproducao, :old.datavalidade, :old.codtipo);
    end if;
END;

--c. Escreva um trigger de auditoria para criação e uso de logs sempre que alguma operação crítica for realizada. Deverá usar :NEW e :OLD.  
--Registro de vendas deletadas (Ex: cliente não realizou pagamento)
CREATE OR REPLACE TRIGGER TR_LogPadaria
BEFORE DELETE ON venda
FOR EACH ROW 
DECLARE
    
BEGIN
    insert into logpadaria values (sysdate, 'Registro de operações', 'Venda com código: ' || :old.codvenda || ' deletada');
END;

--d. Escreva um trigger para impor uma integridade de dados mais complexa do que uma restrição Check(por exemplo).
--Não pode deletar itemvenda se a data da venda for diferente do dia atual
CREATE OR REPLACE TRIGGER TR_DeletarItemVenda
BEFORE DELETE ON itemvenda
FOR EACH ROW 
DECLARE
    data date;
BEGIN
    select datavenda into data from venda where codvenda = :old.codvenda;
    if(data != to_char(sysdate, 'dd/mm/yyyy')) then
        raise_application_error  (-20100, 'Itens da venda não pode ser exluido');
    end if;
END;

--e. Escreva uma função que retorna alguma informação útil para a aplicação e indique uma forma de testá-la.
--Retorna a quantidade de determinado produto em estoque
Create or replace Function FN_ConsultaEstoque (cod in produto.codproduto%TYPE)
return number
as
qtd number;
BEGIN    
    select quantidade into qtd from produto
    where codproduto = cod;
    Return qtd;
END;

select  FN_ConsultaEstoque(1) from dual;

 
select * from tipo;
select * from produto;
select * from fornecedor;
select * from pedido;
select * from venda;
select * from itemPedido;
select * from itemVenda;

select * from logpadaria;
select * from erropadaria;
*/