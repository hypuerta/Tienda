USE [Prueba]
GO

/****** Object:  StoredProcedure [dbo].[ObtenerPrueba]    Script Date: 26/10/2016 12:33:23 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerPrueba]   
 
AS   

    SET NOCOUNT off;  
    SELECT p.ID as Identificador, p.DESCRIPCION
    FROM TBL_PRUEBA p  
GO

