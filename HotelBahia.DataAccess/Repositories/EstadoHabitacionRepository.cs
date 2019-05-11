using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using HotelBahia.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelBahia.DataAccess.Repositories
{
    public class EstadoHabitacionRepository
    {
        HoteleriaDbContext db = new HoteleriaDbContext();
        //Estados a los que pueden cambiar dependiendo del rol:
        //Admnistrador
        public List<EstadoHabitacion> EstadosHabitacionAdministrador()
        {
            RawSqlString sql = "Select * from EstadoHabitacion where EstadoNombre = @nombre OR EstadoNombre = @nombre2";
            SqlParameter parameter1 = new SqlParameter("@nombre", "Desocupado");
            SqlParameter parameter2 = new SqlParameter("@nombre2", "Habilitado");
            var estados = db.EstadoHabitacion.FromSql(sql, parameter1, parameter2).ToList();
            return estados;
        }
        //Supervisor

        //Limpieza


        //Conseguir id de la situacion:
        //Desocupado
        public EstadoHabitacion BuscarEstado(string estado)
        {
            RawSqlString sql = "Select * from EstadoHabitacion where EstadoNombre = @estado";
            SqlParameter parameter1 = new SqlParameter("@estado", estado);
            var state = db.EstadoHabitacion.FromSql(sql, parameter1).FirstOrDefault();
            return state;
        }
    }
}
