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
    
    public partial class TipoDemanda
    {
        public int PK_TipoDemanda { get; set; }
        public int FK_TipoDemanda_Expediente { get; set; }
        public int FK_TipoDemanda_tipo { get; set; }
        public string descripcion { get; set; }
    
        public virtual Expediente Expediente { get; set; }
        public virtual TablaGeneral TablaGeneral { get; set; }
    }
}
