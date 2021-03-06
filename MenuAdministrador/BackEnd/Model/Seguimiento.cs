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
    
    public partial class Seguimiento
    {
        public int PK_Seguimiento { get; set; }
        public int PK_Seguimiento_Cita { get; set; }
        public Nullable<int> PK_Seguimiento_Expediente { get; set; }
        public int FK_Seg_UsuarioAsignado { get; set; }
        public Nullable<int> FK_Seg_UsuarioAsignador { get; set; }
        public Nullable<int> FK_Seg_UsuarioCancela { get; set; }
        public string ResumenIntervencion { get; set; }
        public System.DateTime fechaCita { get; set; }
        public string hora { get; set; }
        public string observaciones { get; set; }
    
        public virtual Cita Cita { get; set; }
        public virtual Expediente Expediente { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
    }
}
