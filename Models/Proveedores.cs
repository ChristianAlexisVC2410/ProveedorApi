namespace ProyProveedor.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proveedores
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Razon_social { get; set; }

        [Required]
        [StringLength(15)]
        public string Rfc { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(20)]
        public string Estatus { get; set; }

        public int Moneda { get; set; }
    }
}
