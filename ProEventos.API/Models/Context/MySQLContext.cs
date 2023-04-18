using Microsoft.EntityFrameworkCore;
using System.Reflection.PortableExecutable;

namespace ProEventos.API.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) {
        }

        public DbSet<Evento> Eventos { get; set; }

        }
    }



