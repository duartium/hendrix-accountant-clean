/************************************************************************
 *    Archivo Físico:      SP_CONSULTA_CLIENTES.sql                     *
 *    Stored procedure:    SP_CONSULTA_CLIENTES                         *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_CONSULTA_CLIENTES]
	@accion char(1),
    @usuario varchar(20) = NULL,
    @tipo_consulta int = 0,
    @id_cliente int = 0,
	@identificacion int = 0,
	@nombres varchar(100) = NULL,
	@apellidos varchar(100) = NULL
AS
    DECLARE @fecha_actual datetime = GETDATE()
    
    --consulta de clientes por grupo
	IF(@accion = 'G')
    BEGIN
        SELECT TOP 25
			c.id_cliente,				c.identificacion,				c.tipo_identificacion,
			c.tipo_cliente,				c.nombres,						c.apellidos,
			c.telefono,					c.celular,
			c.direccion,				c.email
		FROM management.CLIENTES c
        WHERE estado = 1
    END
    --consulta individual de cliente
    ELSE IF(@accion = 'C')
    BEGIN 
		--consulta por número de identificación
		IF(@tipo_consulta = 1) 
			SELECT
				c.id_cliente,				c.identificacion,				c.tipo_identificacion,
				c.tipo_cliente,				c.nombres,						c.apellidos,
				c.telefono,					c.celular,
				c.direccion,				c.email
			FROM management.CLIENTES c
			WHERE estado = 1 AND identificacion = @identificacion
		--consulta por nombres
		--HERE
		--consulta por apellidos
		--HERE
    END
