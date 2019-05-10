using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using HotelBahia.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBahia.DataAccess.Repositories
{
    public class EmpleadoRepository
    {
        HoteleriaDbContext db;
        //Conseguir informacion del empleado asignado para el envio de notificacion:
        //Limpieza
        public Empleado BuscarPersonalLimpiezaAsignado(int habitacionid)
        {
            RawSqlString sql = "select * from Empleado JOIN AsignacionHabitacion ON (Empleado.EmpleadoID = AsignacionHabitacion.EmpleadoID) JOIN Usuario ON (Empleado.UsuarioNombre = Usuario.UsuarioNombre) JOIN Rol ON (Usuario.RolID = Rol.RolID) where AsignacionHabitacion.HabitacionID = @habitacionid and Rol.Nombre = 'Limpieza'";
            SqlParameter parameter1 = new SqlParameter("@habitacionid", habitacionid);
            var personallimpieza = db.Empleado.FromSql(sql, parameter1).FirstOrDefault();
            return personallimpieza;
        }
        //Supervisor

    }
}
