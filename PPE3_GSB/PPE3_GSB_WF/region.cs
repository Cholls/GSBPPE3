//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE3_GSB_WF
{
    using System;
    using System.Collections.Generic;
    
    public partial class region
    {
        public region()
        {
            this.travaillers = new HashSet<travailler>();
            this.visiteurs = new HashSet<visiteur>();
        }
    
        public string REG_CODE { get; set; }
        public string SEC_CODE { get; set; }
        public string REG_NOM { get; set; }
    
        public virtual secteur secteur { get; set; }
        public virtual ICollection<travailler> travaillers { get; set; }
        public virtual ICollection<visiteur> visiteurs { get; set; }
    }
}