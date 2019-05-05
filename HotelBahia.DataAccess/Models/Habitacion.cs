﻿using System;
using System.Collections.Generic;

namespace HotelBahia.DataAccess.Models
{
    public partial class Habitacion
    {
        public Habitacion()
        {
            AsignacionHabitacion = new HashSet<AsignacionHabitacion>();
            HabitacionActividad = new HashSet<HabitacionActividad>();
        }

        public int HabitacionId { get; set; }
        public int? Numero { get; set; }
        public int? Piso { get; set; }
        public int? EstadoHabitacionId { get; set; }
        public int? TipoHabitacionId { get; set; }

        public EstadoHabitacion EstadoHabitacion { get; set; }
        public TipoHabitacion TipoHabitacion { get; set; }
        public ICollection<AsignacionHabitacion> AsignacionHabitacion { get; set; }
        public ICollection<HabitacionActividad> HabitacionActividad { get; set; }
    }
}
