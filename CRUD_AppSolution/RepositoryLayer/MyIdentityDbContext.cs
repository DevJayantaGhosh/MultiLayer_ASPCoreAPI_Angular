using DomainLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer
{
    public class MyIdentityDbContext:IdentityDbContext<MyIdentityUser>
    {
        public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options):base(options)
        {
                
        }


        public DbSet<CEODetail> CEODetails { get; set; }
    }
}
