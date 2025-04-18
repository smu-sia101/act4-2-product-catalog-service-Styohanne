﻿using SQLite;

namespace ProductsDAL
{
    public class ProductModel
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Manufacturer { get; set; }
    }
}
