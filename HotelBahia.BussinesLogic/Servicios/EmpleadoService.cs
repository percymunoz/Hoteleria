using HotelBahia.DataAccess.Repositories;
using HotelBahia.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

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


        //Envio de notificacion a:
        //Personal del limpieza
        public void NotificacionLimpieza(int? cuarto, string destinatario)
        {
            //Crear un mensaje 
            MailMessage mensaje = new MailMessage();
            //Definir el remitente
            mensaje.From = new MailAddress("adm_hotel_bahia@hotmail.com", "Administración"); //poner correo y nombre
            //Definir los destinatarios
            mensaje.To.Add(destinatario);
            //Especificar el asunto
            mensaje.Subject = "Hotel Bahia - Notificacion de Limpieza";
            //Especificar el tipo de mensaje, "false" si es solo texto
            mensaje.IsBodyHtml = false;
            //Especificar el mensaje
            mensaje.Body = "La administración de Hotel Bahía le informa: Por favor, acudir a la habitación " + cuarto + " para empezar el proceso de limpieza lo más pronto posible.";
            //definir las propiedades del servidor de correos salientes
            SmtpClient servidor = new SmtpClient();
            servidor.Port = 587;
            servidor.Host = "smtp.live.com";
            //definir las credenciales para enviar el correo
            NetworkCredential credenciales = new NetworkCredential();
            credenciales.UserName = "adm_hotel_bahia@hotmail.com"; //poner correo
            credenciales.Password = "prueba12345"; //poner contraseña
            //pasar las credenciales
            servidor.Credentials = credenciales;
            servidor.EnableSsl = true; //esto es obligatorio para outlook
            //Enviar el correo
            servidor.Send(mensaje);
        }
        //Supervisor
    }
}
