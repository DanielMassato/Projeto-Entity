USE PEDIDOS
GO

CREATE PROCEDURE SP_PRODUTOS_INSERT
 @COD_PRODUTO VARCHAR(13), @DESCRICAO VARCHAR(40), 
 @COD_UNIDADE SMALLINT, @COD_TIPO SMALLINT, 
 @PRECO_CUSTO NUMERIC(18,4), @PRECO_VENDA NUMERIC(18,4), 
 @QTD_ESTIMADA INT, @QTD_REAL INT, 
 @QTD_MINIMA INT, @CLAS_FISC VARCHAR(10), 
 @IPI INT, @PESO_LIQ NUMERIC(18,2)
AS BEGIN
DECLARE @ID INT;
INSERT INTO PRODUTOS
( COD_PRODUTO, DESCRICAO, COD_UNIDADE, COD_TIPO, PRECO_CUSTO, PRECO_VENDA, QTD_ESTIMADA, QTD_REAL, QTD_MINIMA, CLAS_FISC, IPI, PESO_LIQ)
VALUES
( @COD_PRODUTO, @DESCRICAO, @COD_UNIDADE, @COD_TIPO, @PRECO_CUSTO, @PRECO_VENDA, @QTD_ESTIMADA, @QTD_REAL, @QTD_MINIMA, @CLAS_FISC, @IPI, @PESO_LIQ)
SET @ID = SCOPE_IDENTITY() -- @@IDENTITY
SELECT @ID AS ID
END
GO

CREATE PROCEDURE SP_PRODUTOS_UPDATE
@ID_PRODUTO INT, @COD_PRODUTO VARCHAR(13), 
@DESCRICAO VARCHAR(40), @COD_UNIDADE SMALLINT, 
@COD_TIPO SMALLINT, 
@PRECO_CUSTO NUMERIC(18,4), 
@PRECO_VENDA NUMERIC(18,4), 
@QTD_ESTIMADA INT, 
@QTD_REAL INT, @QTD_MINIMA INT, 
@CLAS_FISC VARCHAR(10), @IPI INT, 
@PESO_LIQ NUMERIC(18,2)
AS BEGIN
UPDATE PRODUTOS
SET
 COD_PRODUTO = @COD_PRODUTO, 
 DESCRICAO = @DESCRICAO, 
 COD_UNIDADE = @COD_UNIDADE, 
 COD_TIPO = @COD_TIPO, 
 PRECO_CUSTO = @PRECO_CUSTO, 
 PRECO_VENDA = @PRECO_VENDA, 
 QTD_ESTIMADA = @QTD_ESTIMADA, 
 QTD_REAL = @QTD_REAL, 
 QTD_MINIMA = @QTD_MINIMA, 
 CLAS_FISC = @CLAS_FISC, 
 IPI = @IPI, 
 PESO_LIQ = @PESO_LIQ
WHERE ID_PRODUTO = @ID_PRODUTO
END
GO
 
CREATE PROCEDURE SP_PRODUTOS_DELETE
@ID_PRODUTO INT
AS BEGIN
DELETE PRODUTOS
WHERE ID_PRODUTO = @ID_PRODUTO
END
GO

ALTER TABLE ITENSPEDIDO ADD CONSTRAINT FK_ITENSPEDIDO_PRODUTOS
FOREIGN KEY (ID_PRODUTO) REFERENCES PRODUTOS(ID_PRODUTO);
go


--=====================================================================
-- INCLUS�O DE CLIENTE RETRONANDO SELECT
CREATE PROCEDURE SP_CLIENTE_INCLUI_S
   @NOME VARCHAR(50), @FANTASIA VARCHAR(20), @ENDERECO VARCHAR(60), @BAIRRO VARCHAR(20), 
   @CIDADE VARCHAR(20), @ESTADO CHAR(2), @CEP CHAR(8), @CNPJ  VARCHAR(18), @INSCRICAO VARCHAR(19), 
   @FONE1 VARCHAR(15), @E_MAIL VARCHAR(35)
AS BEGIN
BEGIN TRY
   INSERT INTO CLIENTES ( NOME, FANTASIA, ENDERECO, BAIRRO, CIDADE, ESTADO, CEP, CNPJ, INSCRICAO, FONE1, E_MAIL)
   VALUES( @NOME, @FANTASIA, @ENDERECO, @BAIRRO, @CIDADE, @ESTADO, @CEP, @CNPJ, @INSCRICAO, @FONE1,  @E_MAIL);

   SELECT @@IDENTITY AS NOVO_CODIGO, 0 AS ERRO_NUM, 'SUCESSO' AS ERRO_MSG;
END TRY
BEGIN CATCH
   SELECT -1 AS NOVO_CODIGO, ERROR_NUMBER() AS ERRO, ERROR_MESSAGE() AS ERRO_MSG; 
END CATCH
END
GO

-- ALTERA CLIENTE RETORNANDO SELECT
CREATE PROCEDURE SP_CLIENTE_ALTERA_S @CODCLI INT,
   @NOME VARCHAR(50), @FANTASIA VARCHAR(20), @ENDERECO VARCHAR(60), @BAIRRO VARCHAR(20), 
   @CIDADE VARCHAR(20), @ESTADO CHAR(2), @CEP CHAR(8), @CNPJ  VARCHAR(18), @INSCRICAO VARCHAR(19), 
   @FONE1 VARCHAR(15), @E_MAIL VARCHAR(35)
AS BEGIN
BEGIN TRY
   UPDATE CLIENTES SET NOME = @NOME , FANTASIA = @FANTASIA , 
                       ENDERECO = @ENDERECO , BAIRRO = @BAIRRO , 
                       CIDADE = @CIDADE , ESTADO = @ESTADO , 
                       CEP = @CEP , 
                       CNPJ = @CNPJ , 
                       INSCRICAO = @INSCRICAO , 
                       FONE1 = @FONE1 ,                        
                       E_MAIL = @E_MAIL 

    WHERE CODCLI = @CODCLI; 

    SELECT 0 AS ERRO_NUM, 'SUCESSO' AS ERRO_MSG;
END TRY
BEGIN CATCH
   SELECT  ERROR_NUMBER() AS ERRO, ERROR_MESSAGE() AS ERRO_MSG; 
END CATCH
END
GO

-- EXCLUI CLIENTE RETORNANDO SELECT
CREATE PROCEDURE SP_CLIENTE_EXCLUI_S @CODCLI INT
AS BEGIN
BEGIN TRY
   DELETE CLIENTES WHERE CODCLI = @CODCLI; 
   SELECT 0 AS ERRO_NUM, 'SUCESSO' AS ERRO_MSG;
END TRY
BEGIN CATCH
   SELECT  ERROR_NUMBER() AS ERRO, ERROR_MESSAGE() AS ERRO_MSG; 
END CAT
END
GO

SELECT * FROM PRODUTOS


UPDATE PRODUTOS SET PESO_LIQ = 0 WHERE PESO_LIQ IS NULL

ALTER TABLE EMPREGADOS WITH NOCHECK ADD 
CONSTRAINT CH_EMPREGADOS_SALARIO CHECK(SALARIO >= 800)

SELECT * FROM PRODUTOS WHERE COD_PRODUTO = 'AAA'

UPDATE PRODUTOS SET PESO_LIQ = 0
WHERE COD_PRODUTO = 'AAA'

