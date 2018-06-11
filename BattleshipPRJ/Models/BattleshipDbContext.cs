using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleshipPRJ.Models
{
    public class BattleshipDbContext : DbContext
    {
        public DbSet<HiScoresModel> HiScoresDb { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connection = @"Server=(localdb)\mssqllocaldb;Database=BattleshipPRJ; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }


    }
}
