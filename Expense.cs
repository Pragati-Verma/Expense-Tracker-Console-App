﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expense_Tracker
{
    public class Expense
    {
        private string Description { get; set; }
        private string Category { get; set; }
        private double Amount {  get; set; }
        public Expense()
        {
            Description = string.Empty;
            Category = string.Empty;
            Amount = 0;
        }
        public Expense(string description, string category, double amount)
        {
            Description = description;
            Category = category;
            Amount = amount;
        }

        public void ViewExpenses(List<Expense> expense)
        {
            int i = 1;
            foreach(var item in expense)
            {
                Console.WriteLine($"{i++}\t{item.Description}\t{item.Category}\tRs {item.Amount:0.00}");
            }
            Console.WriteLine();
        }
    }
}
