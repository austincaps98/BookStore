using System;
using System.Text.Json.Serialization;
using BookStore.Infrastructure;
using Microsoft.AspNetCore.Http;

namespace BookStore.Models
{
    public class SessionCart : Cart
    {
        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Book book, int qty)
        {
            base.AddItem(book, qty);
            Session.SetJson("Cart", this);
        }

        public override void RemoveItem(Book book)
        {
            base.RemoveItem(book);
            Session.SetJson("Cart", this);
        }

        public override void ClearBasket()
        {
            base.ClearBasket();
            Session.Remove("Cart");
        }
    }
}
