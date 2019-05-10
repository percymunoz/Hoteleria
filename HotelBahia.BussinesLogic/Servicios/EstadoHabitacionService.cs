using HotelBahia.DataAccess.Repositories;
using HotelBahia.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBahia.BussinesLogic.Servicios
{
    public class EstadoHabitacionService
    {
        private readonly EstadoHabitacionRepository _estadoHabitacionRepository;
        //Constructor
        public EstadoHabitacionService()
        {
            _estadoHabitacionRepository = new EstadoHabitacionRepository();
        }

        //Logica de la lista de estados por rol:
        //Administrador
        public List<EstadoHabitacion> EstadosHabitacionAdministrador()
        {
            return _estadoHabitacionRepository.EstadosHabitacionAdministrador();
        }
        //Supervisor

        //Limpieza


        //Logica de la busqueda de los estados de habitacion
        //Desocupado
        public EstadoHabitacion BuscarEstadoDesocupado()
        {
            if (_estadoHabitacionRepository.BuscarEstadoDesocupado() == null)
                throw new Exception("No existe el estado desocupado");
            else
                return _estadoHabitacionRepository.BuscarEstadoDesocupado();
        }
        //Limpieza concluida

    }
}
