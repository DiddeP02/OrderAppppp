using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrderApp.ViewModel
{
    internal class ProductViewModel
    {

        public List<Models.Product> TheJewelryProducts { get; set; }
        public List<Models.Product> TheMenProducts { get; set; }
        public List<Models.Product> TheWomenProducts { get; set; }
        public List<Models.Product> TheTechnologyProducts { get; set; }



        public ProductViewModel()
        {
            var task1 = Task.Run(() => GetJewelryProductsAsync());
            task1.Wait();
            TheJewelryProducts = task1.Result;

            var task2 = Task.Run(() => GetMenProductsAsync());
            task2.Wait();
            TheMenProducts = task2.Result;

            var task3 = Task.Run(() => GetWomenProductsAsync());
            task3.Wait();
            TheWomenProducts = task3.Result;

            var task4 = Task.Run(() => GetElectronicProductsAsync());
            task4.Wait();
            TheTechnologyProducts = task4.Result;

        }

        public static async Task<List<Models.Product>> GetJewelryProductsAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://fakestoreapi.com/");

            List<Models.Product> jewelryProducts = null;

            HttpResponseMessage response = await client.GetAsync("/products/category/jewelery");

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                var productList = JsonSerializer.Deserialize<List<Models.Product>>(responseString);

                jewelryProducts = productList.Take(4).ToList();
            }

            return jewelryProducts;
        }

        public static async Task<List<Models.Product>> GetMenProductsAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://fakestoreapi.com/");

            List<Models.Product> menProducts = null;

            HttpResponseMessage response = await client.GetAsync("/products/category/men's clothing");

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                var productList = JsonSerializer.Deserialize<List<Models.Product>>(responseString);

                menProducts = productList.Take(4).ToList();
            }

            return menProducts;
        }

        public static async Task<List<Models.Product>> GetWomenProductsAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://fakestoreapi.com/");

            List<Models.Product> womenProducts = null;

            HttpResponseMessage response = await client.GetAsync("/products/category/women's clothing");


            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                var productList = JsonSerializer.Deserialize<List<Models.Product>>(responseString);

                womenProducts = productList.Take(4).ToList();
            }

            return womenProducts;
        }

        public static async Task<List<Models.Product>> GetElectronicProductsAsync()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://fakestoreapi.com/");

            List<Models.Product> electronicProducts = null;

            HttpResponseMessage response = await client.GetAsync("/products/category/electronics");

            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                var productList = JsonSerializer.Deserialize<List<Models.Product>>(responseString);

                electronicProducts = productList.Take(4).ToList();
            }

            return electronicProducts;
        }
    }
}

