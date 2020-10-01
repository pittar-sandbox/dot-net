using System;

namespace simpleproject_products_api
{
    public class Product
    {
        public string created { get; set; }

        public string description { get; set; }

        public int id { get; set; }

        public string modified { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public string addon {
            get {
                return "Nouveau message";
            }
        }

    }
}
