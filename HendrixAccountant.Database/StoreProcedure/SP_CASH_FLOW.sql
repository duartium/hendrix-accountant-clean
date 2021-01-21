/************************************************************************
 *    Archivo Físico:      SP_CASH_FLOW.sql							    *
 *    Stored procedure:    SP_CASH_FLOW								    *
 *    Base de datos:       HENDRIX        			                	*
 *    Elaborado por:       Byron Duarte                                 *
 *----------------------------------------------------------------------*
 *                   DESCRIPCION DEL PROCEDIMIENTO                      *
 *    Implementa el mantenimiento de movimientos de caja				*
 *----------------------------------------------------------------------*
 *                     BITACORA DE MODIFICACIONES                       *
 *      FECHA        AUTOR            RAZON                             *
 *----------------------------------------------------------------------*/
CREATE PROCEDURE [dbo].[SP_CASH_FLOW]
	@accion char(1),
    @usuario int = 0,
	@tipo_movimiento int,
	@saldo decimal,
	@serial decimal
AS
BEGIN
	DECLARE @fecha_actual datetime = GETDATE(),
			@usuario_id int,
			@caja_id int

	IF @accion='I'
	BEGIN
		SELECT @usuario_id=id_usuario FROM auth.USUARIOS WHERE usuario=@usuario

		SELECT @caja_id=id_caja FROM CAJA WHERE serial_pc=@serial

		INSERT INTO MOVIMIENTOS_CAJA(
				fecha,			tipo_movimiento,		ingresos, 
				egresos,		saldo,					usuario_id,			caja_id)
		 VALUES(@fecha_actual, @tipo_movimiento,		NULL,
				NULL,			@saldo,					@usuario_id,		@caja_id)
    END
END
