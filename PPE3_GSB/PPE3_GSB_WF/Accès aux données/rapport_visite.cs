//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_GSB_WF.Accès_aux_données
{
    using System;
    using System.Collections.Generic;
    
    public partial class rapport_visite
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public rapport_visite()
        {
            this.offrirs = new HashSet<offrir>();
            this.medicaments = new HashSet<medicament>();
        }
    
        public string VIS_MATRICULE { get; set; }
        public int RAP_NUM { get; set; }
        public int PRA_NUM { get; set; }
        public Nullable<int> PRA_NUM_REMPLACANT { get; set; }
        public Nullable<System.DateTime> RAP_DATE_VISITE { get; set; }
        public Nullable<System.DateTime> RAP_DATE_SAISIE { get; set; }
        public string RAP_BILAN { get; set; }
        public string RAP_MOTIF_AUTRE { get; set; }
        public string MOT_CODE { get; set; }
        public int RAP_DOCUMENTATION { get; set; }
        public int RAP_SAISIEDEFINITIVE { get; set; }
    
        public virtual motif motif { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<offrir> offrirs { get; set; }
        public virtual praticien praticien { get; set; }
        public virtual praticien praticien1 { get; set; }
        public virtual visiteur visiteur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<medicament> medicaments { get; set; }
    }
}
