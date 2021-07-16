/************************************************************************
 *    Archivo Físico:      SP_REGISTER_SALE.sql                         *
 *    Stored procedure:    SP_REGISTER_SALE                             *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de clientes del sistema               *
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/

ALTER PROCEDURE [dbo].[SP_RPT_SALE]
	@accion char(1),
	@secuencial int		= NULL,
	@fecha_desde varchar(10)	= NULL,
	@fecha_hasta varchar(10)	= NULL,
	@id_cliente int		= NULL,
	@id_usuario int		= NULL
AS
BEGIN
	DECLARE @fecha_actual datetime = GETDATE()
	DECLARE @fecha_actual_corta date = CONVERT(DATE, GETDATE(), 104)
	
	IF(@fecha_desde = '')
		SET @fecha_desde = NULL

	IF(@fecha_hasta = '')
		SET @fecha_hasta = NULL

	IF(@id_cliente <= 0 )
		SET @id_cliente = NULL

	IF(@id_usuario <= 0 )
		SET @id_usuario = NULL

	IF(@secuencial <= 0)
		SET @secuencial = NULL

	IF @accion='G'
	BEGIN
		--EXEC SP_PARAMETERS 'J', 'empresa'
		SELECT fac.id_factura as idFactura,
			   fac.secuencial,
			   fac.fecha_emision as fechaEmision,
			   cl.identificacion,
			   CONCAT(cl.nombres,' ',cl.apellidos) as nombresCliente,
			   fac.base_imponible as baseImponible,
			   fac.iva,
			   fac.total,
			   fac.usuario_crea as usuarioCrea
		FROM sale.FACTURA fac
		INNER JOIN management.CLIENTES cl ON cl.id_cliente = fac.cliente_id
		WHERE fac.estado = 1
		AND CONVERT(DATE, fecha_emision, 104)  BETWEEN ISNULL(CONVERT(DATE, @fecha_desde, 104), @fecha_actual_corta) AND ISNULL(CONVERT(DATE, @fecha_hasta, 104), @fecha_actual_corta)
		AND fac.secuencial = ISNULL(@secuencial, fac.secuencial)
		AND fac.cliente_id = ISNULL(@id_cliente, fac.cliente_id)
		AND fac.usuario_id = ISNULL(@id_usuario, fac.usuario_id)
	END
	
	IF @accion='C'
	BEGIN
		--EXEC SP_PARAMETERS 'J', 'empresa'

		SELECT fac.id_factura as idFactura,
			   fac.secuencial,
			   fac.fecha_emision as fechaEmision,
			   cl.identificacion,
			   CONCAT(cl.nombres,' ',cl.apellidos) as nombresCliente,
			   fac.base_imponible as baseImponible,
			   fac.iva,
			   fac.total,
			   fac.usuario_crea as usuarioCrea
		FROM sale.FACTURA fac
		INNER JOIN management.CLIENTES cl ON cl.id_cliente = fac.cliente_id
		WHERE secuencial=@secuencial
		AND fac.estado = 1

		SELECT pro.id_producto as idProducto,
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