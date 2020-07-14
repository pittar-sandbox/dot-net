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

        public float price { get; set; }

        public string addon {
            get {
                return "Very useful information added by the dotnet core api";
            }
        }

    }
}
