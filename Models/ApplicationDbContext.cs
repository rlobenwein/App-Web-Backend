﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App_Web_Backend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos{ get; set; }
        public DbSet<Usuario> Usuarios{ get; set; }


    }
}
