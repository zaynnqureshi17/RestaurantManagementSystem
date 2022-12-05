using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SecondNetCoreApp.Models;  

namespace SecondNetCoreApp.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ ImageTitle = "Margerita",
                PizzaName = "Margerita", 
                BasePrice=2, 
                Tomato=true, 
                Beef=true, 
                FinalPrice=4}
        };
        public void OnGet()
        {
        }
    }
}
