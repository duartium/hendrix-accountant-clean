using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Repositories
{
    public class SupplierRepository: Repository<Supplier>, ISupplierRepository
    {
        private AppDbContext _appDbContext => (AppDbContext)_context;

        public SupplierRepository(AppDbContext context) : base(context)
        {
        }

        public List<ComboBoxProveedorDTO> GetComboBoxProveedorDTOs()
        {
            var query = _context.Supplier.Where(x => x.estado == true).ToList();
            var listResponse = (from x in query select new ComboBoxProveedorDTO { Id = x.proveedor_id, Descripcion = x.nombre }).ToList();
            return listResponse;

            //var response = new List<ComboBoxProveedorDTO>();
            //response.Add(new ComboBoxProveedorDTO { Id = 1, Descripcion = "Pro A" });
            //response.Add(new ComboBoxProveedorDTO { Id = 2, Descripcion = "Pro B" });
            //response.Add(new ComboBoxProveedorDTO { Id = 3, Descripcion = "Pro C" });

        }
    }
}
