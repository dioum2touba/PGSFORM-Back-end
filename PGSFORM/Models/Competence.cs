﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PGSFORM.Models
{
    public partial class Competence
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public string Niveau { get; set; }
        public int? UtilisateurId { get; set; }

        public virtual Utilisateur Utilisateur { get; set; }
    }
}