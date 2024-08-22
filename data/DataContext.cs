using Controle_Financeiro.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle_Financeiro.data
{
    public class DataContext : DbContext
    {
        // Defina a string de conexão
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=data.db");
        }

        public DbSet<User> Users { get; set; }

        // Configurações adicionais (opcional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Definir configurações específicas das entidades aqui, se necessário
        }
    }
}
