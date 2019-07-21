using HangFireTest_WebApp.Models;

namespace HangFireTest_WebApp
{
    public class GenerateDailySalesReport : IGenerateDailySalesReport
    {
        // NOTE
        /*
        Hangfire hooks itself into Microsoft’s Dependency Injection framework, 
        so the EF Core context here will be wired up automatically.
        */
        private AppContext _context;

        public GenerateDailySalesReport(AppContext context)
        {
            _context = context;
        }

        public string[] ForAllCustomers()
        {
            // business logic and data persistence here...
            // NOTE: instead of getting data from database, for simplicity...
            
            var customers = new string[]{
                "Tom", "John", "Alice"
            };
            return customers;


        }
    }
}