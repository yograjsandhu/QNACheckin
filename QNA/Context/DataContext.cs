/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QNA.Models;

namespace QNA.Context
{
    public class DataContext:DbContext

    {

        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Category> Categories { get; set; }


        public DbSet<Answer> Answers { get; set; }


      


    }
}
*/