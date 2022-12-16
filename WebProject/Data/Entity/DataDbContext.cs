using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebProject.Data.Entity;

namespace WebProject.Data.Entity
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options) { }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Collaboration> Collaborations { get; set; }
        public DbSet<Contora> Contoras { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Mini_Game> Mini_Games { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Vid_sporta> Vid_sportas { get; set; }
    }
}
