using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SleighList.Contexts
{
    public class Context
    {
        using Bibliotec.Models;
        using Microsoft.EntityFrameworkCore;

    // Classe que tera as informacoes do banco de dados
    public class Context : DbContext
    {
        public Context()
        {   }
        public Context(DbContextOptions<Context> options) : base(options)
        {     }
        // OnConfiguring -> Possui a configuracao da conexao com 
        // o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //colocar as informacoes no banco de dados

            // as configuracoes existem?
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1HURK41\VINI; Initial Catalog = Bibliotec_mvc; User Id=sa; Password=123;TrustServerCertificate = true");
            }
        }
    	public DbSet<Usuario> Usuario { get; set; }
    	public DbSet<Item> Item { get; set; }
    	
    }
}
    }
