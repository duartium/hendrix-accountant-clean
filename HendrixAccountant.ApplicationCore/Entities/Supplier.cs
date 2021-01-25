using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Entities
{
	[Table("PROVEEDORES", Schema = "inventory")]
	public class Supplier
	{
		[Key]
		public long proveedor_id { get; set; }
		[Display(Name ="Nombre")]
		public string nombre { get; set; }
		[Display(Name = "Alias")]
		public string alias { get; set; }
		[Display(Name = "RUC")]
		public string ruc { get; set; }
		[Display(Name = "Dirección")]
		public string direccion { get; set; }
		[Display(Name = "Ciudad")]
		public string ciudad { get; set; }
		[Display(Name = "Provincia")]
		public string provincia { get; set; }
		[Display(Name = "Email")]
		public string email { get; set; }
		public bool estado { get; set; }
		public DateTime creado_en { get; set; }
		public string usuario_crea { get; set; }
		public DateTime? modificado_en { get; set; }
		public string usuario_mod { get; set; }
		public DateTime? eliminado_en { get; set; }
		public string usuario_elim { get; set; }

        public Supplier()
        {
        }

		public Supplier(long proveedor_id_, string nombre_, string alias_, string ruc_, string direccion_, string ciudad_, string provincia_, string email_, bool estado_, DateTime creado_en_, string usuario_crea_, DateTime modificado_en_, string usuario_mod_, DateTime eliminado_en_, string usuario_elim_)
		{
			this.proveedor_id = proveedor_id_;
			this.nombre = nombre_;
			this.alias = alias_;
			this.ruc = ruc_;
			this.direccion = direccion_;
			this.ciudad = ciudad_;
			this.provincia = provincia_;
			this.email = email_;
			this.estado = estado_;
			this.creado_en = creado_en_;
			this.usuario_crea = usuario_crea_;
			this.modificado_en = modificado_en_;
			this.usuario_mod = usuario_mod_;
			this.eliminado_en = eliminado_en_;
			this.usuario_elim = usuario_elim_;
		}
	}
}
