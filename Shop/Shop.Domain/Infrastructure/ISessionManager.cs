using Shop.Domain.Models;
using System;
using System.Collections.Generic;

namespace Shop.Domain.Infrastructure
{
    public interface ISessionManager
    {
        string GetId();
        void AddProduct(CartProduct cartProduct);
        void AddProductToWish(CartProduct cartProduct);
        void RemoveProduct(int stockId, int qty);
        void RemoveProductFromWish(int stockId);
        IEnumerable<TResult> GetCart<TResult>(Func<CartProduct, TResult> selector);
        IEnumerable<TResult> GetWish<TResult>(Func<CartProduct, TResult> selector);
        void ClearCart();
        void ClearWish();
        void AddCustomerInformation(CustomerInformation customer);
        CustomerInformation GetCustomerInformation();
    }
}
