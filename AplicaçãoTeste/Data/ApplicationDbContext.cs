using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AplicaçãoTeste.Models;

namespace AplicaçãoTeste.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AplicaçãoTeste.Models.Endereco> Endereco { get; set; }
        public DbSet<AplicaçãoTeste.Models.Fornecedor> Fornecedor { get; set; }
        public DbSet<AplicaçãoTeste.Models.Produto> Produto { get; set; }
    }
}
