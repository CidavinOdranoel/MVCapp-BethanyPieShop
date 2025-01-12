﻿using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _appDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext?.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }

        public void AddToCart(Pie pie, int amount)
        {
            var shoppingCartItem =
                _appDbContext.ShoppingCardItems.SingleOrDefault(
                    x => x.Pie.PieId == pie.PieId && x.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem()
                {
                    ShoppingCartId = ShoppingCartId,
                    Pie = pie,
                    Amount = 1
                };
                _appDbContext.ShoppingCardItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _appDbContext.SaveChanges();

        }

        public int RemoveFromCart(Pie pie)
        {
            var shoppingCartItem =
                _appDbContext.ShoppingCardItems.SingleOrDefault(
                    x => x.Pie.PieId == pie.PieId && x.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    _appDbContext.ShoppingCardItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();
            return localAmount;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ??
                (ShoppingCartItems =
                    _appDbContext.ShoppingCardItems.Where(x => x.ShoppingCartId == ShoppingCartId)
                    .Include(x => x.Pie)
                    .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.ShoppingCardItems
                .Where(x => x.ShoppingCartId == ShoppingCartId);

            _appDbContext.ShoppingCardItems.RemoveRange(cartItems);

            _appDbContext.SaveChanges();
        }

        public int GetShoppingCartTotal()
        {
            return _appDbContext.ShoppingCardItems.Where(x => x.ShoppingCartId == ShoppingCartId)
                .Select(x => x.Pie.Price).Sum();
        }
    }
}
