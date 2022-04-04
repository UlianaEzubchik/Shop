using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Application.Cart;
using Shop.Application.Products;
using Shop.Application.Wishlist;
using Shop.Database;

namespace Shop.UI.Pages
{
    public class AllProductsModel : PageModel
    {
        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }

        [BindProperty]
        public AddToWish.Request WishViewModel { get; set; }
        [BindProperty]
        public AddToCart.Request CartViewModel { get; set; }


        public void OnGet([FromServices] GetProducts getProducts)
        {
            Products = getProducts.Do();
        }
    }
}
