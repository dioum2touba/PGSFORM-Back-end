﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PGSFORM.Models.CollectionViewModel
{
    public partial class UtilisateurVM
    {
        public UtilisateurVM()
        {
            Commentaire = new HashSet<CommentaireVM>();
            Competence = new HashSet<CompetenceVM>();
            Projet = new HashSet<ProjetVM>();
            Ressource = new HashSet<RessourceVM>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Status { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }

        public virtual ICollection<CommentaireVM> Commentaire { get; set; }
        public virtual ICollection<CompetenceVM> Competence { get; set; }
        public virtual ICollection<ProjetVM> Projet { get; set; }
        public virtual ICollection<RessourceVM> Ressource { get; set; }
    }
}