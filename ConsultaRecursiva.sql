--
-- Consulta Recursiva
--
Declare @mItem as Varchar(6) = 'F';
WITH cteTx AS 
	(
		SELECT	IdTx, CodigoTx, IdTxPadre
		FROM	Ind_Tx
		WHERE	CodigoTx LIKE @mItem + '%' and CodigoTx <> '*' AND LEN(CodigoTx) = LEN(@mItem) + 1

        UNION ALL

		SELECT	t.IdTx, t.CodigoTx, t.IdTxPadre
        FROM    Ind_Tx AS t 
		INNER JOIN	cteTx ON t.IdTx = t.IdTxPadre
	)
    SELECT	X.IdTx, X.CodigoTx, X.IdTxPadre, X.CodigoTx + ' - ' + IsNull(D.DescCortaTxTraducida,'') Descripcion
    FROM    cteTx AS X
			JOIN Ind_TxTraducido D on D.IdTx = X.IdTx
	WHERE	D.IdIdioma = 5831
    ORDER BY CodigoTx

go

Declare @mItem as Varchar(6) = 'F';
WITH cteTx AS 
	(
		SELECT	IdTx, CodigoTx, IdTxPadre, CAST(CodigoTx as varbinary(max)) Orden
		FROM	Ind_Tx
		WHERE	CodigoTx LIKE @mItem + '%' and CodigoTx <> '*' AND LEN(CodigoTx) = LEN(@mItem) + 1

        UNION ALL

		SELECT	t.IdTx, t.CodigoTx, t.IdTxPadre, Orden + CAST(t.IdTxPadre as varbinary(max)) Orden
        FROM    Ind_Tx AS t 
		INNER JOIN	cteTx c ON c.IdTx = t.IdTxPadre
	)
    SELECT	*
    FROM    cteTx 			
    ORDER BY Orden

go
