using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiTestApplication.Models;

namespace WebApiTestApplication.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
