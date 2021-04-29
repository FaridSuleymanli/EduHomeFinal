using EduHomeFinal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.DAL
{
    public class EduDb : DbContext
    {
        public EduDb(DbContextOptions<EduDb> options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeProfession> NoticeProfessions { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<EduHome> EduHomes { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Speakers> Speakers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
