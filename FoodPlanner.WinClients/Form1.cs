using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FoodPlanner.Core;
using FoodPlanner.Model;

namespace FoodPlanner.WinClients
{
    public partial class Form1 : Form
    {
        DishRepository dr;
        DishService ds;


        public Form1()
        {
            InitializeComponent();
            dr = new DishRepository();
            ds = new DishService(dr);
            btnGetDishes_Click(this, new EventArgs());
        }

        private async void btnGetDishes_Click(object sender, EventArgs e)
        {
            var distinctItems = await ds.SelectSevenDistinctDishes();
            ShowInListBox(distinctItems);
            ds.AddDishesToQuarantine(distinctItems);         
        }

        private void ShowInListBox(IEnumerable<Dish> distinctItems)
        {
            foreach (Dish d in distinctItems)
            {
                lstDishes.Items.Add(d.Name);
            }
        }



    }
}
