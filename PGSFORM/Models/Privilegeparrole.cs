﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PGSFORM.Models
{
    public partial class Privilegeparrole
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PrivilegeId { get; set; }

        public virtual Privilege Privilege { get; set; }
        public virtual Role Role { get; set; }
    }
}