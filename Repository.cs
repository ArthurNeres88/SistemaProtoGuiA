using System;
using Microsoft.EntityFrameworkCore;

namespace SistemaProtoGuiA
{
    public class Repository : DbContext
    {
        public static readonly String _connectionParams = @"server=127.0.0.1;port=3307;uid=root;pwd=;database=sistemaprotoguia";

        public DbSet<Usuario> Usuarios {  get; set; }

        public Repository() => this.Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySQL(_connectionParams);
        }
    }
}
