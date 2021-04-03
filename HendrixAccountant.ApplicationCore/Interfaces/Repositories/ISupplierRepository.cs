using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface ISupplierRepository
    {
        bool Save(SupplierDto supplier, bool isUpdate);
        List<SupplierDto> GetAll(SupplierFilterDto dto);
        bool Remove(int idProveedor, string usuario);
        SupplierDto GetDefault();
    }
}
