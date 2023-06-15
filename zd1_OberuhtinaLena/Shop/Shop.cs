using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    class Shop
    {
        private Dictionary<Product, int> products;
        public Shop ()
        {
            products = new Dictionary<Product, int>();
        }
        public void AddProduct (Product product, int count)
        {
            products.Add(product, count);
        }

        public void CreateProduct (string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }

        public void WriteAllProducts (ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var product in products)
            {
                listBox.Items.Add($"{product.Key.GetInfo()}; Количество:{ product.Value}"  );
            }
        }
        bool chec = true;
        public bool Chec()
        {
            return chec;
        }
        public void Sell (Product product)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] == 0)
                {
                    MessageBox.Show("Нет в наличии!");
                    chec = false;
                } else
                {
                    
                    products[product]--;
                }
            } else
            {
                MessageBox.Show("Товар не найден!");
            }
        }
      
        public Product FindByName (string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
       
        

    }
}
