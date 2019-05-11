using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using HotelBahia.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBahia.DataAccess.Repositories
{
    public class HabitacionRepository
    {
        HoteleriaDbContext db = new HoteleriaDbContext();
        //Conseguir informacion de la habitacion
        public Habitacion BuscarHabitacion(int habitacionid)
        {
            var hab = db.Habitacion.Find(habitacionid);
            return hab;
        }

        //Conseguir la lista de habitaciones con estados especificos por rol:
        //Administrador
        public List<Habitacion> ListaHabitacionAdministrador()
        {
            RawSqlString sql = "Select * from Habitacion JOIN EstadoHabitacion ON (Habitacion.EstadoHabitacionID = EstadoHabitacion.EstadoHabitacionID) JOIN TipoHabitacion ON (Habitacion.TipoHabitacionID = TipoHabitacion.TipoHabitacionID) where EstadoHabitacion.EstadoNombre = @estado AND TipoHabitacion.Nombre = @tipo OR EstadoHabitacion.EstadoNombre = @estado2 AND TipoHabitacion.Nombre = @tipo";
            SqlParameter parameter1 = new SqlParameter("@estado", "Ocupado");
            SqlParameter parameter2 = new SqlParameter("@estado2", "Supervisado");
            SqlParameter parameter3 = new SqlParameter("@tipo", "Cuarto");
            var habitaciones = db.Habitacion.FromSql(sql, parameter1, parameter2, parameter3).ToList();
            return habitaciones;
        }
        //Supervisor

        //Limpieza


        //Editar situacion de la habitacion
        public int EditarEstadoHabitacion(Habitacion habitacion)
        {
            var hab = db.Habitacion.Find(habitacion.HabitacionId);
            hab.EstadoHabitacionId = habitacion.EstadoHabitacionId;
            return db.SaveChanges();
        }

    }
}
