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
    
    public partial class tb_msc_expediente
    {
        public int id_expediente { get; set; }
        public string nom1 { get; set; }
        public string nom2 { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string cedula { get; set; }
        public string sexo { get; set; }
        public string seguro { get; set; }
        public Nullable<int> id_estado_civil { get; set; }
        public string lugar_nacimiento { get; set; }
        public int id_lugar { get; set; }
        public Nullable<int> id_nacionalidad { get; set; }
        public Nullable<int> id_nivel_acad { get; set; }
        public string direccion { get; set; }
        public int id_profesion { get; set; }
        public string email { get; set; }
        public Nullable<double> peso { get; set; }
        public Nullable<double> altura { get; set; }
        public string senas_particulares { get; set; }
        public System.DateTime fecha_nacimiento { get; set; }
        public Nullable<int> id_daem { get; set; }
        public Nullable<int> id_licencia { get; set; }
        public Nullable<int> id_vehiculo { get; set; }
        public Nullable<int> talla_pantalon { get; set; }
        public string talla_camisa { get; set; }
        public Nullable<int> talla_botas { get; set; }
        public Nullable<int> id_acreditacion_daem { get; set; }
    
        public virtual tb_cat_lugar tb_cat_lugar { get; set; }
    }
}
