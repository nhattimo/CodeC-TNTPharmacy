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
        public DbSet<BillOffline> BILL_OFFLINES { get; set; }
        public DbSet<BillOfflineDetail> BILL_OFFLINE_DETAILS { get; set; }
        public DbSet<Categorys> CATEGORYS { get; set; }
        public DbSet<Employees> EMPLOYEES { get; set; }
        public DbSet<PayMent> PAY_MENTS { get; set; }
        public DbSet<PayMentMethond> PAY_MENT_METHONDS { get; set; }
        public DbSet<Products> PRODUCTS { get; set; }
        public DbSet<Roles> ROLES { get; set; }
        public DbSet<SalesOrder> SALES_ORDER { get; set; }
        public DbSet<SalesOrderDetail> SALES_ORDER_DETAIL { get; set; }
        public DbSet<Shipping> SHIPPING { get; set; }
        public DbSet<Stocks> STOCKS { get; set; }
        public DbSet<Suppliers> SUPPLIERS { get; set; }
        public DbSet<Users> USERS { get; set; }
        public DbSet<WareHousing> WARE_HOUSING { get; set; }
        public DbSet<WareHousingDetails> WARE_HOUSING_DETAILS { get; set; }


    }
}
