﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PGSFORM.Models
{
    public partial class Commentaire
    {
        public Commentaire()
        {
            Notification = new HashSet<Notification>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreation { get; set; }
        public int? RessourceId { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Ressource Ressource { get; set; }
        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
    }
}