using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SecondNetCoreApp.Data;
using SecondNetCoreApp.Models;


namespace SecondNetCoreApp.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDBContext _context;
        public CheckoutModel(ApplicationDBContext Context)
        {
             _context = Context;    
        }
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                PizzaName = "Create";
            }

            PizzaOrders pizzaOrders = new PizzaOrders();
            pizzaOrders.PizzaName = PizzaName;
            pizzaOrders.BasePrice = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrders);
            _context.SaveChanges();
        }
    }
}
