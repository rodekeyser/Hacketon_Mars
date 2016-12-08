using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESTService.Models.DAL
{
    public class DataContext: DbContext
    {
        public DataContext(): base("DefaultConnection"){

        }

        public static DataContext Create()
        {
            return new DataContext();
        }
        public DbSet<Data> Data { get; set; }
    }
}