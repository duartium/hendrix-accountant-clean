/************************************************************************
 *    Archivo Físico:      SP_CONSULTA_PRODUCTOS.sql                    *
 *    Stored procedure:    SP_CONSULTA_PRODUCTOS                        *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de productos del sistema              *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/

--IF exists (select * from sysobjects where name = 'SP_CONSULTA_PRODUCTOS')
--   drop proc dbo.SP_CONSULTA_PRODUCTOS

CREATE PROCEDURE [dbo].[SP_CONSULTA_PRODUCTOS]
	@accion char(1),
    @usuario int = 0
AS
    DECLARE @fecha_actual datetime = GETDATE()
    
    --consulta de clientes por grupo
	IF(@accion = 'G')
    BEGIN
        SELECT TOP 25
			p.id_producto,				p.nombre,				p.descripcion,
			p.stock,					p.precio_venta precio,			ISNULL(p.marca, 0) marca, 
			p.categoria_id categoria		
		FROM inventory.PRODUCTOS p
        WHERE estado = 1
    END
