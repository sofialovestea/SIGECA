//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackEnd.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            this.Cita = new HashSet<Cita>();
            this.Contacto = new HashSet<Contacto>();
            this.Implicado = new HashSet<Implicado>();
        }
    
        public int PK_Persona { get; set; }
        public Nullable<int> FK_Persona_Escolaridad { get; set; }
        public Nullable<int> FK_Persona_Sexo { get; set; }
        public Nullable<int> FK_Persona_Ocupacion { get; set; }
        public Nullable<int> FK_Persona_EstadoCivil { get; set; }
        public int FK_Persona_Nacionalidad { get; set; }
        public Nullable<int> FK_Persona_Distrito { get; set; }
        public Nullable<int> identificacion { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fechaNacimiento { get; set; }
        public Nullable<int> numHijos { get; set; }
        public string lugarTrabajo { get; set; }
        public string direccionVivienda { get; set; }
        public Nullable<int> FK_Persona_Parentesco { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contacto> Contacto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Implicado> Implicado { get; set; }
        public virtual TablaGeneral TablaGeneral { get; set; }
        public virtual TablaGeneral TablaGeneral1 { get; set; }
        public virtual TablaGeneral TablaGeneral2 { get; set; }
        public virtual TablaGeneral TablaGeneral3 { get; set; }
        public virtual TablaGeneral TablaGeneral4 { get; set; }
        public virtual TablaGeneral TablaGeneral5 { get; set; }
        public virtual TablaGeneral TablaGeneral6 { get; set; }
    }
}
