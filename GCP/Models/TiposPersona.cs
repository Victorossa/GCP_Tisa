//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GCP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TiposPersona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TiposPersona()
        {
            this.Personas = new HashSet<Personas>();
        }
    
        public int TipoPersona_Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<int> Naturaleza_Id { get; set; }
        public Nullable<int> Persona_Id { get; set; }
        public string Cargo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personas> Personas { get; set; }
        public virtual TiposNaturaleza TiposNaturaleza { get; set; }
    }
}
