using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SwLavanderia.Models
{
    public class Ticket
    {
        //ID para tabla
        public int Id { get; set; }

        //Numero de boleta (Debe ser unico)
        [RegularExpression(@"^\d{6}", ErrorMessage = "El numero de boleta debe tener 6 digitos")]
        public int TkNroBoleta { get; set; }

        //Fecha de registro en BD o ingreso a almacen
        [DataType(DataType.Date)]
        public DateTime TkFechaIngreso { get; set; }

        //Fecha tentativa de entrega
        
        public DateTime? TkFechaEntrega { get; set; }

        //Precio total del ticket
        // [Required(ErrorMessage="No dejar el campo nulo")]
        [RegularExpression(@"^\$?\d+(\.(\d{1,2}))?$", ErrorMessage ="El precio debe tener hasta 2 decimales")]
        public double? TkPagoTotal { get; set; }



        //-----------------Accesos----------------------------
        //Lista de Servicios
        public List<Servicio> Servicios { get; set; }
        

        //Para acceder a cliente
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }

        //Para acceder a Almacen
        public Almacen Almacen  { get; set; }
        public int AlmacenId { get; set; }

        //Estado del ticket
        public Estado Estado { get; set; }
        public int EstadoId { get; set; }
    }
}