
USE [UPC2014]
GO
/****** Object:  StoredProcedure [dbo].[SP_INSCRIPCIONES_LISTAR]    Script Date: 02/02/2014 01:41:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[SP_INSCRIPCIONES_LISTAR]  
	@P_DNI nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;

        SELECT
			CodigoInscripcion,
			DNI,
			Tipo,
			Nombre,
			ApellidoPaterno,
			ApellidoMaterno,
			FechaInscripcion,
			Direccion,
			CodigoUbigeo
        FROM INSCRIPCION
        WHERE (DNI = @P_DNI OR @P_DNI = '')
        ORDER BY ApellidoPaterno, ApellidoMaterno, Nombre;

END
