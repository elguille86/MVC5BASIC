//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApps01.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public int usu_cod { get; set; }
        public string usu_nom { get; set; }
        public int car_cod { get; set; }
    
        public virtual cargo cargo { get; set; }
    }
}