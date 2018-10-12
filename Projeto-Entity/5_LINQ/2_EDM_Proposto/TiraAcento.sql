
USE PEDIDOS

-----------------------------------------------------------------
-- 5. Substituir todos os caracteres acentuados de um 
-- texto pelo correspondente caracter n�o acentuado
-----------------------------------------------------------------
CREATE FUNCTION FN_TIRA_ACENTO( @S VARCHAR(200) )
  RETURNS VARCHAR( 200 )
AS BEGIN
DECLARE @I INT, @RET VARCHAR(200), @C CHAR(1);
SET @I = 1;
SET @RET = '';
-- Enquanto @I for menor que o tamanho de @S
WHILE @I <= LEN(@S)
   BEGIN
   SET @C = SUBSTRING( @S, @I, 1 );
   SET @RET = @RET + CASE 
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�'),ASCII('�'),ASCII('�')) THEN 'A'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�'),ASCII('�'),ASCII('�')) THEN 'a'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�')) THEN 'E'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�')) THEN 'e'
                       WHEN ASCII(@C) IN (ASCII('�')) THEN 'I'
                       WHEN ASCII(@C) IN (ASCII('�')) THEN 'i'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�'),ASCII('�')) THEN 'O'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�'),ASCII('�')) THEN 'o'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�')) THEN 'U'
                       WHEN ASCII(@C) IN (ASCII('�'),ASCII('�')) THEN 'u'
                       WHEN ASCII(@C) = ASCII('�') THEN 'C'
                       WHEN ASCII(@C) = ASCII('�') THEN 'c'
                       ELSE @C
                     END -- CASE   
    SET @I = @I + 1
    END  
RETURN (@RET);
END
GO
---
SELECT NOME FROM EMPREGADOS
WHERE DBO.FN_TIRA_ACENTO( NOME ) LIKE '%JOSE%'

SELECT NOME FROM EMPREGADOS
WHERE DBO.FN_TIRA_ACENTO( NOME ) LIKE '%JOAO%'


