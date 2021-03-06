﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        public Menu(int count, string foodName, float price, float totalPrice = 0)
        {
            this.Count = count;
            this.FoodName = foodName;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row) 
        {
            this.Count = (int)row["count"];
            this.FoodName = row["Name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }

        private float totalPrice;
        private float price;
        private string foodName;
        private int count;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
