//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CinemaGalleryWinForm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Peliculas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Peliculas()
        {
            this.PeliculasActores = new HashSet<PeliculasActores>();
            this.PeliculasDirectores = new HashSet<PeliculasDirectores>();
        }
    
        public int Id { get; set; }
        public string titulo_original { get; set; }
        public string titulo_traducido { get; set; }
        public string director { get; set; }
        public string duraccion { get; set; }
        public string url { get; set; }
        public string calificacion_IMBD { get; set; }
        public string calificacion_propia { get; set; }
        public string descripcion_ { get; set; }
        public string comentarios { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeliculasActores> PeliculasActores { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PeliculasDirectores> PeliculasDirectores { get; set; }
    }
}