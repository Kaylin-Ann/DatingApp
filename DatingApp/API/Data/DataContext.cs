using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data //relates to the folder
{
    //deriving from the DB context
    public class DataContext : DbContext
    {
        //generating a constructor
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        //DBSET
        //<  > - takes the type of the class thats needed to create a dAtabase set for
        //calling the table inside the database Users
        public DbSet<AppUser> Users { get; set; }
    }
}