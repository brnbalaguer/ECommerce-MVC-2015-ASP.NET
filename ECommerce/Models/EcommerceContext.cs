﻿using System.Data.Entity;

namespace ECommerce.Models
{
    public class EcommerceContext: DbContext
    {
        public EcommerceContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ECommerce.Models.Departments> Departments { get; set; }
    }
}