/************************************************************************
 *    Archivo Físico:      SP_USER_ATHENTICATION.sql                    *
 *    Stored procedure:    SP_USER_ATHENTICATION                        *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa la autenticación de usuarios                           *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_USER_ATHENTICATION]
	@accion char(1),
    @usuario int = 0,
    @username varchar(20) = 0,
    @password varchar(150) = 0
AS
	IF(@accion = 'C')
    BEGIN
        SELECT COUNT(1)
		FROM auth.USUARIOS u
		WHERE usuario = ISNULL(@username, '') AND  clave = ISNULL(@password, '')
    END