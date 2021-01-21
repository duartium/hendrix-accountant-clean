/************************************************************************
 *    Archivo Físico:      SP_GENERATE_SEQUENTIAL.sql                   *
 *    Stored procedure:    SP_GENERATE_SEQUENTIAL                       *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Genera secuenciales único segun clave valor en tabla SECUENCIAL   *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_GENERATE_SEQUENTIAL]
	@nombre varchar(50)
AS
DECLARE @NextSeq int
BEGIN
	SELECT @NextSeq = valor FROM sale.Secuencial WHERE nombre=@nombre
	SET @NextSeq = @NextSeq+1
	UPDATE sale.SECUENCIAL SET valor=@NextSeq WHERE nombre=@nombre
	RETURN @NextSeq
END