using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMovie.Models
{
    public class SocialMovieContextFactory
    {
        public static SocialMovieContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SocialMovieContext>();
            optionsBuilder.UseMySQL(connectionString);

            //Ensure database creation
            var context = new SocialMovieContext(optionsBuilder.Options);
            context.Database.EnsureCreated();

            return context;
        }
    }
}
