﻿using System;
using System.Collections.Generic;

namespace HotelBahia.DataAccess.Models
{
    public partial class Rol
    {
        public Rol()
        {
            Usuario = new HashSet<Usuario>();
        }

        public int RolId { get; set; }
        public string Nombre { get; set; }

        public ICollection<Usuario> Usuario { get; set; }
    }
}
