﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PGSFORM.Models
{
    public partial class Projet
    {
        public Projet()
        {
            Notification = new HashSet<Notification>();
            Ressource = new HashSet<Ressource>();
        }

        public int Id { get; set; }
        public string Libelle { get; set; }
        public int? Duree { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Enonce { get; set; }
        public string PieceJointe { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<Ressource> Ressource { get; set; }
    }
}