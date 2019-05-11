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
        //Ocupado
        public EstadoHabitacion BuscarEstadoOcupado()
        {
            if (_estadoHabitacionRepository.BuscarEstadoOcupado() == null)
                throw new Exception("No existe el estado ocupado");
            else
                return _estadoHabitacionRepository.BuscarEstadoOcupado();
        }
        //Supervisado
        public EstadoHabitacion BuscarEstadoSupervisado()
        {
            if (_estadoHabitacionRepository.BuscarEstadoSupervisado() == null)
                throw new Exception("No existe el estado supervisado");
            else
                return _estadoHabitacionRepository.BuscarEstadoSupervisado();
        }
        //Habilitado
        public EstadoHabitacion BuscarEstadoHabilitado()
        {
            if (_estadoHabitacionRepository.BuscarEstadoHabilitado() == null)
                throw new Exception("No existe el estado habilitado");
            else
                return _estadoHabitacionRepository.BuscarEstadoHabilitado();
        }
        //Limpieza concluida

    }
}
