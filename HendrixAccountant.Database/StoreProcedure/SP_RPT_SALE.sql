/************************************************************************
 *    Archivo Físico:      SP_RPT_SALE.sql							    *
 *    Stored procedure:    SP_RPT_SALE								    *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Genera secuenciales único segun clave valor en tabla SECUENCIAL   *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_RPT_SALE]
	@accion char(1),
	@secuencial int		= NULL,
	@fecha_desde date	= NULL,
	@fecha_hasta date	= NULL,
	@id_cliente int		= NULL,
	@id_usuario int		= NULL
AS
BEGIN
	IF(@fecha_desde = '')
		SET @fecha_desde = NULL

	IF(@fecha_hasta = '')
		SET @fecha_hasta = NULL

	IF(@id_cliente <= 0 )
		SET @id_cliente = NULL

	IF(@id_usuario <= 0 )
		SET @id_usuario = NULL

	IF @accion='C'
	BEGIN
		SELECT fac.secuencial,
			   fac.fecha_emision as fechaEmision,
			   CONCAT(cl.nombres,' ',cl.apellidos) as nombresCliente,
			   fac.base_imponible as baseImponible,
			   fac.iva,
			   fac.total,
			   fac.usuario_crea as usuarioCrea
		FROM sale.FACTURA fac
		INNER JOIN management.CLIENTES cl ON cl.id_cliente = fac.cliente_id
		WHERE secuencial=@secuencial
		AND fac.estado = 1

		SELECT pro.id_producto as codigo,
			   pro.nombre,
			   det.cantidad,
			   det.precio_unitario as precioUnit,
			   (det.precio_unitario * det.cantidad) as valor
		FROM sale.FACTURA_DETALLE det
		INNER JOIN sale.FACTURA fac ON fac.id_factura = det.factura_id
		INNER JOIN inventory.PRODUCTOS pro ON pro.id_producto = det.producto_id
		WHERE fac.secuencial = @secuencial
		AND fac.estado = 1
	END
END