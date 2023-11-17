using DTO;
using System.Data.Entity;
using System.Net.NetworkInformation;

namespace DAL
{
    public class AppPharmacyContext : DbContext
    {
        public AppPharmacyContext() : base(@"Server = NHATTIMO\MSSQLSERVER01; Database = App_Pharmacy_3Layer_EF_CodeFirst; Trusted_Connection = true;")
        {

        }
        public DbSet<Roles> ROLES { get; set; }
        public DbSet<Users> USERS { get; set; }

        public DbSet<Employees> EMPLOYEES { get; set; }
        

        public DbSet<Products> PRODUCTS { get; set; }
        public DbSet<Suppliers> SUPPLIERS { get; set; }
        public DbSet<Categorys> CATEGORYS { get; set; }


    }
}
