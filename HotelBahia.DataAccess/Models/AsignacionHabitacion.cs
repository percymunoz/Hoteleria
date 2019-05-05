﻿using System;
using System.Collections.Generic;

namespace HotelBahia.DataAccess.Models
{
    public partial class AsignacionHabitacion
    {
        public int AsignacionHabitacionId { get; set; }
        public int EmpleadoId { get; set; }
        public int HabitacionId { get; set; }
        public DateTime? Fecha { get; set; }

        public Empleado Empleado { get; set; }
        public Habitacion Habitacion { get; set; }
    }
}
