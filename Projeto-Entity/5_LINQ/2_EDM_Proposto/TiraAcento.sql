
USE PEDIDOS

-----------------------------------------------------------------
-- 5. Substituir todos os caracteres acentuados de um 
-- texto pelo correspondente caracter não acentuado
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
                       WHEN ASCII(@C) IN (ASCII('Ã'),ASCII('Á'),ASCII('À'),ASCII('Â')) THEN 'A'
                       WHEN ASCII(@C) IN (ASCII('ã'),ASCII('á'),ASCII('à'),ASCII('â')) THEN 'a'
                       WHEN ASCII(@C) IN (ASCII('É'),ASCII('Ê')) THEN 'E'
                       WHEN ASCII(@C) IN (ASCII('é'),ASCII('ê')) THEN 'e'
                       WHEN ASCII(@C) IN (ASCII('Í')) THEN 'I'
                       WHEN ASCII(@C) IN (ASCII('í')) THEN 'i'
                       WHEN ASCII(@C) IN (ASCII('Ó'),ASCII('Õ'),ASCII('Ô')) THEN 'O'
                       WHEN ASCII(@C) IN (ASCII('ó'),ASCII('õ'),ASCII('ô')) THEN 'o'
                       WHEN ASCII(@C) IN (ASCII('Ú'),ASCII('Ü')) THEN 'U'
                       WHEN ASCII(@C) IN (ASCII('ú'),ASCII('ü')) THEN 'u'
                       WHEN ASCII(@C) = ASCII('Ç') THEN 'C'
                       WHEN ASCII(@C) = ASCII('ç') THEN 'c'
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


