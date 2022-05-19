using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MTCV.Models.ENTITY
{
    public class ContextCv : DbContext
    {
        public DbSet<AboutMe> Abouts { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Education> educations { get; set; }
        public DbSet<Skill> skills { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Award> Awards { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}