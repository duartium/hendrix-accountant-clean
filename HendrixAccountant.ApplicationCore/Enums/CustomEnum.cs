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

    public enum TipoBusqueda
    {
        IDENTIFICACION,
        NOMBRES
    }

    public enum EstadoOperacionCrud
    {
        Nuevo = 1,
        Edicion = 2,
        Eliminacion = 3
    }

    public enum EnumCriterioBusquedaMantProducto
    {
        Nombre = 0,
        Descripción = 1,
        Costo = 2,
        PrecioDeVenta = 3
    }

    public enum EnumCriterioBusquedaMantProveedor
    {
        Nombre = 0,
        RUC = 1,
        Ciudad = 2,
        Provincia = 3
    }
}
