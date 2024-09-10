using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entity_Vinicom.Models;
using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Tls;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;

namespace Entity_Vinicom.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }
        public object Post { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               @"Data Source = (localdb)\ProjectModels; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
        }
    }
}
