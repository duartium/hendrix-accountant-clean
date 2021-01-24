using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Enums
{
    public enum UserRole
    {
        ADMINISTRADOR = 1,
        CAJERO = 3
    }

    public enum TipoMovimiento //flujo de caja
    {
        APERTURA = 1,
        CIERRE = 2
    }

    public enum Estado
    {
        INACTIVO,
        ACTIVO
    }

    public enum EstadoPantalla
    {
        INICIAL,
        CREACION,
        ELIMINACION
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
