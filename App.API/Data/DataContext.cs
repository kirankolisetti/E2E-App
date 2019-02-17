using App.API.Model;
using Microsoft.EntityFrameworkCore;

namespace App.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext>options):base(options){}

        public DbSet<Value>Values{get;set;}
 
    }
}