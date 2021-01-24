﻿using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Dtos
{
    public class UserDto : ISaleElement
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string FechaCreacion { get; set; }
    }

    public class UserAuthDto
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
    }
}
