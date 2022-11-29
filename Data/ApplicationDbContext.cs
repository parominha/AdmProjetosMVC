using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AdmProjetosMVC.EF;

namespace AdmProjetosMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AdmProjetosMVC.EF.Cliente> Cliente { get; set; }
        public DbSet<AdmProjetosMVC.EF.Projeto> Projeto { get; set; }
        public DbSet<AdmProjetosMVC.EF.Funcionario> Funcionario { get; set; }
        public DbSet<AdmProjetosMVC.EF.Tarefa> Tarefa { get; set; }
    }
}
