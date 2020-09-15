using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.DataAccess.Context
{
    public class PersianAnimalLandContext : DbContext
    {
        public PersianAnimalLandContext(){ }
        public PersianAnimalLandContext(DbContextOptions options) : base(options) { }
        public PersianAnimalLandContext(DbContextOptions<PersianAnimalLandContext> options) : base(options) {}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
