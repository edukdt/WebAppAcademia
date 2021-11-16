using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppAcademia.Models;

namespace WebAppAcademia.Data
{
    public class WebAppAcademiaContext : DbContext
    {
        public WebAppAcademiaContext (DbContextOptions<WebAppAcademiaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppAcademia.Models.TraineeModel> TraineeModel { get; set; }
    }
}
