//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Orm
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sol
    {
        public long Id { get; set; }
        public string NomPoste { get; set; }
        public string CodeAeroport { get; set; }
    
        public virtual Aeroport Aeroport { get; set; }
        public virtual Employe Employe { get; set; }
    }
}