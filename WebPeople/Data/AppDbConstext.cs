using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPeople.Models;

namespace WebPeople.Data
{
    public class AppDbConstext:DbContext
    {
        public DbSet<Person> People { get; set; }

        public AppDbConstext(DbContextOptions<AppDbConstext>options):base(options)// enlaza base de datos
        {

        }
    }
}
