using HotelBahia.DataAccess.Repositories;
using HotelBahia.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBahia.BussinesLogic.Servicios
{
    public class HabitacionService
    {
        private readonly HabitacionRepository _habitacionRepository;
        //Constructor
        public HabitacionService()
        {
            _habitacionRepository = new HabitacionRepository();
        }

        //Logica de la busqueda de habitacion
        public Habitacion BuscarHabitacion(int habitacionid)
        {
            if (_habitacionRepository.BuscarHabitacion(habitacionid) == null)
                throw new Exception("No existe la habitación");
            else
                return _habitacionRepository.BuscarHabitacion(habitacionid);
        }

        //Logica de la lista de habitaciones por rol
        //Administrador
        public List<Habitacion> ListaHabitacionAdministrador()
        {
            return _habitacionRepository.ListaHabitacionAdministrador();
        }
        //Supervisor

        //Limpieza


        //Logica del cambio de estado
        public int EditarEstadoHabitacion(Habitacion habitacion)
        {
            if (_habitacionRepository.BuscarHabitacion(habitacion.HabitacionId) == null)
                throw new Exception("No existe la habitación");
            else
                return _habitacionRepository.EditarEstadoHabitacion(habitacion);
        }
    }
}
