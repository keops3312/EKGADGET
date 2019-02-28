namespace EKGADGET.WinForms.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Empleados
    {
        [Key]
        [Column(Order = 0)]
        public int Consecutivo { get; set; }

        [StringLength(50)]
        public string NoEmpleado { get; set; }

        [Column("Nombre Completo")]
        [StringLength(255)]
        public string Nombre_Completo { get; set; }

        [StringLength(255)]
        public string Nombres { get; set; }

        [StringLength(255)]
        public string Apaterno { get; set; }

        [StringLength(255)]
        public string Amaterno { get; set; }

        [StringLength(255)]
        public string Calle { get; set; }

        [StringLength(255)]
        public string Colonia { get; set; }

        [StringLength(255)]
        public string No_int { get; set; }

        [StringLength(255)]
        public string No_ext { get; set; }

        public int? Cp { get; set; }

        [StringLength(255)]
        public string Ciudad { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [StringLength(255)]
        public string Pais { get; set; }

        [StringLength(255)]
        public string Sexo { get; set; }

        [StringLength(255)]
        public string Edo_civil { get; set; }

        [Column("Fecha de Nacimiento", TypeName = "smalldatetime")]
        public DateTime? Fecha_de_Nacimiento { get; set; }

        public int? EDAD { get; set; }

        [Column("No Seguro Social")]
        [StringLength(255)]
        public string No_Seguro_Social { get; set; }

        [StringLength(255)]
        public string Nacionalidad { get; set; }

        [StringLength(255)]
        public string Puesto { get; set; }

        [StringLength(255)]
        public string RFC { get; set; }

        [StringLength(255)]
        public string CURP { get; set; }

        [Column("Lugar de nacimiento")]
        [StringLength(255)]
        public string Lugar_de_nacimiento { get; set; }

        [StringLength(255)]
        public string Teléfono { get; set; }

        [StringLength(255)]
        public string CEL { get; set; }

        [Column("Fecha de Ingreso", TypeName = "smalldatetime")]
        public DateTime? Fecha_de_Ingreso { get; set; }

        [StringLength(255)]
        public string Localidad { get; set; }

        [StringLength(255)]
        public string BAJA { get; set; }

        [StringLength(255)]
        public string HORARIO_de { get; set; }

        [StringLength(255)]
        public string HORARIO_a { get; set; }

        [Column("HORARIO AM")]
        [StringLength(255)]
        public string HORARIO_AM { get; set; }

        [Column("HORARIO PM")]
        [StringLength(255)]
        public string HORARIO_PM { get; set; }

        [StringLength(255)]
        public string empresa { get; set; }

        [StringLength(255)]
        public string ife { get; set; }

        [StringLength(255)]
        public string estadocivil { get; set; }

        [StringLength(255)]
        public string esposa { get; set; }

        [StringLength(255)]
        public string hijos { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string grado_estudios { get; set; }

        [StringLength(255)]
        public string estudios_espcf { get; set; }

        public string fotografia { get; set; }

        [StringLength(255)]
        public string altapor { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaalta { get; set; }

        public string correo { get; set; }

        [StringLength(50)]
        public string departamento { get; set; }
    }
}
