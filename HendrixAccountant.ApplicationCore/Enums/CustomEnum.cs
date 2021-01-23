using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Enums
{
    enum ERoles
    {
        Cajero = 10,
        Administrador = 20
    }

    public enum TipoMovimiento //flujo de caja
    {
        Apertura = 1,
        Cierre = 2
    }

    public enum Estado
    {
        Inactivo,
        Activo
    }

    public enum EstadoPantalla
    {
        Inicial,
        Creacion,
        Eliminacion
    }

    public enum ConsultaVenta
    {
        GENERAL,
        COMP_INDIVIDUAL
    }

    public enum TipoReporte
    {
        VENTAS_GENERALES,
        FACTURA_VENTA
    }
}
