//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoGastro
{
    using System;
    using System.Collections.Generic;
    
    public partial class telefono
    {
        public int id { get; set; }
        public string Numero { get; set; }
        public int Tipo_Telefono_id { get; set; }
        public Nullable<int> Proveedor_id { get; set; }
        public Nullable<int> Empleado_id { get; set; }
    
        public virtual empleado empleado { get; set; }
        public virtual proveedor proveedor { get; set; }
        public virtual tipo_telefono tipo_telefono { get; set; }
    }
}
