﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PGSFORM.Models
{
    public partial class Privilege
    {
        public Privilege()
        {
            Privilegeparrole = new HashSet<Privilegeparrole>();
        }

        public int Id { get; set; }
        public string Label { get; set; }
        public DateTime? DateCreation { get; set; }

        public virtual ICollection<Privilegeparrole> Privilegeparrole { get; set; }
    }
}