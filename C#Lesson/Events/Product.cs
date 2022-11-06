﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public delegate void StockControl();
    public class Product
    {
        private int _stock;

        public Product(int stock)
        {
            _stock = stock;
        }

        public event StockControl StockConrolEvent;
        public string ProductName { get; set; }
        public int Stock 
        {
            get { return _stock; }
            set
            {
                _stock = value;
                if (value<15 && StockConrolEvent!=null)
                {
                    StockConrolEvent();
                }
            }
                
            
        }

        public void Sell(int Amount)
        {
            Stock -= Amount;
            Console.WriteLine($"{ProductName}  Stock amount : {Stock}");
        }
    }
}
