
CREATE OR ALTER VIEW VW_movreport 
as
SELECT c.Client,c.Number, cc.Description AS "Descrição", mt.Description, m.Dt_Init, m.Dt_Fin
FROM Movimentations m inner join Containers c on m.ContainerId = c.Id
inner join ContainerCategories cc on c.ContainerCategoryId = cc.Id
inner join MovTypes mt on mt.Id = m.MovTypeId
order by c.Client;


Select * from Movimentations;