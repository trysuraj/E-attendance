using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Attendee> Attendees { get; set; }
        /*
        public MyDbContext(DbContextOptions<MyDbContext>option) :base(option)
        {

        }
        */
    }
}
