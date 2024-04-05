using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp.Models
{
    public sealed class ShoppingCartSingleton
    {
        private static readonly ShoppingCartSingleton instance = new ShoppingCartSingleton();

        private List<Product> items = new List<Product>();

        private ShoppingCartSingleton()
        {
        }

        public static ShoppingCartSingleton Instance
        {
            get
            {
                return instance;
            }
        }

        public void AddItem(Product item)
        {
            items.Add(item);
        }

        public void RemoveItemm(Product item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
            }
        }
        public void ClearItems()
        {
            items.Clear();
        }
        public List<Product> GetItems()
        {
            return items;
        }
    }
}
