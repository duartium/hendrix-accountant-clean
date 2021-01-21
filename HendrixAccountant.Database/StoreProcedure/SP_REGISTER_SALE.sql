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
CREATE PROCEDURE [dbo].[SP_REGISTER_SALE]
	@accion char(1),
    @id_usuario int,
	@usuario varchar(20),
	@serial varchar(50),
	@factura varchar(max)
AS
BEGIN
	DECLARE @fecha_actual datetime = GETDATE(),
			@factura_xml xml,
			@id_factura int,
			@secuencial int

	IF @accion='I'
	BEGIN
	--BEGIN TRANSACTION TR_REGISTER_INVOICE
	--  BEGIN TRY
		SET @factura_xml = CAST(@factura as XML)
		
		EXEC @secuencial = dbo.SP_GENERATE_SEQUENTIAL 'factura'

		INSERT INTO sale.FACTURA
		SELECT
		   @secuencial,
		   @id_usuario,
		   factura.value('(clienteId/text())[1]', 'int'),
		   factura.value('(fechaEmision/text())[1]', 'datetime'),
		   factura.value('(baseImponible/text())[1]', 'decimal(10,2)'),
		   factura.value('(iva/text())[1]', 'decimal(10,2)'),
		   factura.value('(total/text())[1]', 'decimal(10,2)'),
		   1 as estado,
		   @usuario as usuarioCrea,
		   @fecha_actual as creadoEn,
		   NULL, NULL, NULL, NULL
		from @factura_xml.nodes('/factura') AS FACTURA_XML(factura);

		SET @id_factura = SCOPE_IDENTITY()

		INSERT INTO sale.FACTURA_DETALLE
		SELECT
		   @id_factura,
		   detalle.value('(productoId/text())[1]', 'int'),
		   detalle.value('(cantidad/text())[1]', 'int'),
		   detalle.value('(precioUnitario/text())[1]', 'decimal(10,2)'),
		   detalle.value('(descuento/text())[1]', 'decimal(10,2)'),
		   1 as estado
		from @factura_xml.nodes('/factura/detalles/detalle') AS FACTURA_XML(detalle);
		--COMMIT TRANSACTION TR_REGISTER_INVOICE

	 -- END TRY
	 -- BEGIN CATCH
		--  ROLLBACK TRANSACTION TR_REGISTER_INVOICE
	 -- END CATCH
		
    END
END
