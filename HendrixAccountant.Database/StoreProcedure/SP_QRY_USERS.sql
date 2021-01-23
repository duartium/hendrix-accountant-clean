/************************************************************************
 *    Archivo Físico:      SP_QRY_USERS.sql							    *
 *    Stored procedure:    SP_QRY_USERS								    *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Gestión de usuarios											    *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_QRY_USERS]
	@accion char(1),
	@id_usuario int	= NULL,
	@usuario varchar(20) = NULL
AS
BEGIN
	IF(@id_usuario <= 0)
		SET @id_usuario = NULL

	IF(@usuario <= 0)
		SET @usuario = NULL

	IF @accion='G'
	BEGIN
		 SELECT u.id_usuario,
				u.usuario,
				u.creado_en
		FROM auth.USUARIOS u
        WHERE estado = 1
		AND u.id_usuario = ISNULL(@id_usuario, u.id_usuario)
		AND u.usuario = ISNULL(@usuario, u.usuario)
	END
END