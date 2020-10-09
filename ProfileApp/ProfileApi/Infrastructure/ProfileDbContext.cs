using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProfileApi.Models;

namespace ProfileApi.Infrastructure
{
    public class ProfileDbContext : DbContext
    {
        public ProfileDbContext(DbContextOptions<ProfileDbContext> options):base(options){

        }

        public DbSet<Profile> Profiles{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            FileStream fs = File.OpenRead("./orig-db.json");
            StreamReader sr = new StreamReader(fs);
            var data = sr.ReadToEnd();
            var profiles = JsonConvert.DeserializeObject<IEnumerable<Profile>>(data);
            modelBuilder.Entity<Profile>().HasData(profiles.ToArray());
        }
    }
}
