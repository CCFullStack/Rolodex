using Rolodex.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Rolodex.Models {
    public class DataContext : DbContext {

        static DataContext() {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataContext, Configuration>());
        }


        public IDbSet<Contact> Contacts { get; set; }
        public IDbSet<Address> Addresses { get; set; }
    }
}