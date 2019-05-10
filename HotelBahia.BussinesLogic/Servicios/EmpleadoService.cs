using HotelBahia.DataAccess.Repositories;
using HotelBahia.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBahia.BussinesLogic.Servicios
{
    public class EmpleadoService
    {
        private readonly EmpleadoRepository _empleadoRepository;
        //Constructor
        public EmpleadoService()
        {
            _empleadoRepository = new EmpleadoRepository();
        }

        //Logica de conseguir el empleado asignado:
        //Limpieza
        public Empleado BuscarPersonalLimpiezaAsignado(int habitacionid)
        {
            if (_empleadoRepository.BuscarPersonalLimpiezaAsignado(habitacionid) == null)
                throw new Exception("No hay personal de limpieza asignado a la habitacion");
            else
                return _empleadoRepository.BuscarPersonalLimpiezaAsignado(habitacionid);
        }
        //Supervisor

    }
}
