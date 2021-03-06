//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Clinicas.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Consulta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Consulta()
        {
            this.CrecimientoPaciente = new HashSet<CrecimientoPaciente>();
            this.DiagnosticoCIE10 = new HashSet<DiagnosticoCIE10>();
            this.OrdenImagen = new HashSet<OrdenImagen>();
            this.OrdenLaboratorio = new HashSet<OrdenLaboratorio>();
            this.PagoConsulta = new HashSet<PagoConsulta>();
            this.Receta = new HashSet<Receta>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PacienteId { get; set; }
        public Nullable<int> EstadoConsultaId { get; set; }
        public Nullable<int> UsuarioAsignadoId { get; set; }
        public string Titulo { get; set; }
        public System.DateTime Inicio { get; set; }
        public System.DateTime Fin { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> UsuarioCreaId { get; set; }
    
        public virtual EstadoConsulta EstadoConsulta { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Usuario Usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CrecimientoPaciente> CrecimientoPaciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiagnosticoCIE10> DiagnosticoCIE10 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenImagen> OrdenImagen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdenLaboratorio> OrdenLaboratorio { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PagoConsulta> PagoConsulta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receta> Receta { get; set; }
    }
}
