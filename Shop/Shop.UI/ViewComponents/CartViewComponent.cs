using Microsoft.AspNetCore.Mvc;
using Shop.Application.Cart;
using Shop.Application.Wishlist;
using System.Linq;

namespace Shop.UI.ViewComponents
{
    public class CartViewComponent : ViewComponent
    {
        private GetCart _getCart;
        private GetWish _getWish;

        public CartViewComponent(GetCart getCart, GetWish getWish)
        {
            _getCart = getCart;
            _getWish = getWish;
        }

        public IViewComponentResult Invoke(string view = "Default")
        {
            if(view == "Small")
            {
                var totalValue = _getCart.Do().Sum(x => x.RealValue * x.Qty).ToString("0.00");
                return View(view, $"{totalValue}");
            }
            else if(view == "Medium")
            {
                return View(view, _getCart.Do());
            }
            else if (view == "SmallWish")
            {
                var totalValue = _getWish.Do().Count();
                return View(view, totalValue);
            }
            else if (view == "DefaultWish")
            {
                return View(view, _getWish.Do());
            }
           
            return View(view, _getCart.Do());
        }
    }
}
