//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUDOperationUsinAngularjsinMVC.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_msc_contrato
    {
        public int id_contrato { get; set; }
        public string id_empleado { get; set; }
        public System.DateTime fecha_ingreso { get; set; }
        public Nullable<int> periodo_prueba { get; set; }
        public int id_estado { get; set; }
        public int id_cargo { get; set; }
        public int id_nivel { get; set; }
        public Nullable<bool> pago_vacaciones { get; set; }
        public Nullable<int> id_tipo_pago { get; set; }
        public Nullable<bool> confirmado { get; set; }
        public Nullable<int> id_contrato_sup { get; set; }
        public Nullable<bool> activo { get; set; }
    
        public virtual tb_msc_empleado tb_msc_empleado { get; set; }
    }
}
