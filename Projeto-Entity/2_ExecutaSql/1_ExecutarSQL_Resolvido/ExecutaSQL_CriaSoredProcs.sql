USE PEDIDOS
GO
-- Faz cópia de um pedido e retorna um DataSet de 1 linha contendo
-- o número do pedido gerado e uma mensagem
CREATE PROCEDURE STP_COPIA_PEDIDO @NUM_PEDIDO_FONTE INT
AS BEGIN
-- Declarar variável para armazenar o número do novo pedido
DECLARE @NUM_PEDIDO_NOVO INT;

BEGIN TRAN
-- Abrir bloco de comandos protegidos de erro
BEGIN TRY
	IF NOT EXISTS(SELECT * FROM PEDIDOS WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE)
	   RAISERROR('PEDIDO NÃO EXISTE',16,1)
	-- Copiar registro de PEDIDOS
	INSERT INTO PEDIDOS (CODCLI, CODVEN, DATA_EMISSAO, VLR_TOTAL, SITUACAO, OBSERVACOES)
	SELECT CODCLI, CODVEN, GETDATE(), VLR_TOTAL, 'P', OBSERVACOES
	FROM PEDIDOS
	WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE
	-- Descobrir o NUM_PEDIDO que foi gerado  
	SET @NUM_PEDIDO_NOVO = SCOPE_IDENTITY()
	-- Copiar os itens do pedido (ITENSPEDIDO) 
	INSERT INTO ITENSPEDIDO (NUM_PEDIDO, NUM_ITEM, ID_PRODUTO, COD_PRODUTO, CODCOR, QUANTIDADE, PR_UNITARIO, DATA_ENTREGA, SITUACAO, DESCONTO)
	SELECT @NUM_PEDIDO_NOVO, NUM_ITEM, ID_PRODUTO, COD_PRODUTO, CODCOR, QUANTIDADE, PR_UNITARIO, GETDATE()+10, SITUACAO, DESCONTO 
	FROM ITENSPEDIDO
	WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE;
	-- Retornar com o número do novo pedido
	COMMIT
	SELECT @NUM_PEDIDO_NOVO AS NUM_PEDIDO_NOVO,
	       'SUCESSO' AS MSG;	
END TRY
-- abrir bloco de tratamento de erro
BEGIN CATCH
    ROLLBACK
    SELECT -1 AS NUM_PEDIDO_NOVO,
            ERROR_MESSAGE() AS MSG
END CATCH	
END
GO

EXEC STP_COPIA_PEDIDO 5136
GO
--==========================================================================
-- Faz cópia de um pedido e retorna 2 parâmetros de OUTPUT contendo
-- o número do pedido gerado e uma mensagem
CREATE PROCEDURE STP_COPIA_PEDIDO_P @NUM_PEDIDO_FONTE INT, 
                                    @NUM_PEDIDO_NOVO INT OUTPUT,
                                    @MSG VARCHAR(1000) OUTPUT
AS BEGIN
BEGIN TRAN
-- Abrir bloco de comandos protegidos de erro
BEGIN TRY
	IF NOT EXISTS(SELECT * FROM PEDIDOS WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE)
	   RAISERROR('PEDIDO NÃO EXISTE',16,1)

	-- Copiar registro de PEDIDOS
	INSERT INTO PEDIDOS (CODCLI, CODVEN, DATA_EMISSAO, VLR_TOTAL, SITUACAO, OBSERVACOES)
	SELECT CODCLI, CODVEN, GETDATE(), VLR_TOTAL, 'P', OBSERVACOES
	FROM PEDIDOS
	WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE
	-- Descobrir o NUM_PEDIDO que foi gerado  
	SET @NUM_PEDIDO_NOVO = SCOPE_IDENTITY()
	-- Copiar os itens do pedido (ITENSPEDIDO) 
	INSERT INTO ITENSPEDIDO (NUM_PEDIDO, NUM_ITEM, ID_PRODUTO, COD_PRODUTO, CODCOR, QUANTIDADE, PR_UNITARIO, DATA_ENTREGA, SITUACAO, DESCONTO)
	SELECT @NUM_PEDIDO_NOVO, NUM_ITEM, ID_PRODUTO, COD_PRODUTO, CODCOR, QUANTIDADE, PR_UNITARIO, GETDATE()+10, SITUACAO, DESCONTO 
	FROM ITENSPEDIDO
	WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE;
	-- Retornar mesnagem de sucesso
	SET @MSG = 'SUCESSO';	
	COMMIT
	RETURN 0;
END TRY
-- abrir bloco de tratamento de erro
BEGIN CATCH
    ROLLBACK
    SET @NUM_PEDIDO_NOVO = -1;
    SET @MSG = ERROR_MESSAGE();
    RETURN -1;
END CATCH	
END
GO

ALTER TABLE ITENSPEDIDO WITH NOCHECK
ADD CONSTRAINT CK_ITENSPEDIDO_QUANTIDADE CHECK(QUANTIDADE > 0)
GO


--==========================================================================
-- Cria uma VIEW para consultar o total vendido em cada 
-- um dos meses de 2012
CREATE VIEW VIE_TOTAL_VENDIDO AS
SELECT TOP 12 MONTH( DATA_EMISSAO ) AS MES,
       YEAR( DATA_EMISSAO ) AS ANO,
       SUM( VLR_TOTAL ) AS TOTAL_VENDIDO
FROM PEDIDOS
-- NÃO ACEITA PARÂMETRO. Trabalha somente com constantes
WHERE YEAR(DATA_EMISSAO) = 2012
GROUP BY MONTH(DATA_EMISSAO), YEAR(DATA_EMISSAO)
ORDER BY MES
GO
----------------------------------------------------
-- LIMITAÇÃO: Uma VIEW não pode receber parâmetros
----------------------------------------------------
-- executa com SELECT
SELECT * FROM VIE_TOTAL_VENDIDO
-- Pode fazer ORDER BY
SELECT * FROM VIE_TOTAL_VENDIDO
ORDER BY TOTAL_VENDIDO DESC
GO

--==========================================================================
-- Cria uma STORED PROCEDURE para consultar o total vendido em cada 
-- um dos meses do ano que foi passado como parâmetro
CREATE PROCEDURE STP_TOTAL_VENDIDO @ANO INT
AS BEGIN
SELECT MONTH( DATA_EMISSAO ) AS MES,
       YEAR( DATA_EMISSAO ) AS ANO,
       SUM( VLR_TOTAL ) AS TOTAL_VENDIDO
FROM PEDIDOS
-- Aceita parâmetro. Trabalha com dados variáveis
WHERE YEAR(DATA_EMISSAO) = @ANO
GROUP BY MONTH(DATA_EMISSAO), YEAR(DATA_EMISSAO)
ORDER BY MES
END
GO
----------------------------------------------------
-- LIMITAÇÃO: É executada com EXEC, não tem JOIN,
-- ORDER BY, WHERE etc...
----------------------------------------------------
EXEC STP_TOTAL_VENDIDO 2010
EXEC STP_TOTAL_VENDIDO 2011
EXEC STP_TOTAL_VENDIDO 2012
GO

--==========================================================================
-- Cria uma FUNÇÃO TABULAR para consultar o total vendido em cada 
-- um dos meses do ano que foi passado como parâmetro
CREATE FUNCTION FN_TOTAL_VENDIDO( @ANO INT )
RETURNS TABLE
AS
RETURN ( SELECT MONTH( DATA_EMISSAO ) AS MES, 
                YEAR( DATA_EMISSAO ) AS ANO, 
                SUM( VLR_TOTAL ) AS TOTAL_VENDIDO
                FROM PEDIDOS
                -- Aceita parâmetros. Trabalha com variáveis
                WHERE YEAR(DATA_EMISSAO) = @ANO
                GROUP BY MONTH( DATA_EMISSAO ), 
                         YEAR( DATA_EMISSAO ) )
GO
----------------------------------------------------
-- Executa com SELECT
SELECT * FROM FN_TOTAL_VENDIDO( 2011)
ORDER BY ANO, MES
-- Aceita filtro
SELECT * FROM FN_TOTAL_VENDIDO( 2012)
WHERE MES > 6
ORDER BY ANO, MES