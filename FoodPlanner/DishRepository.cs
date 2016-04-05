using FoodPlanner.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Core
{

    public interface IDishRepository
    {
        Task<List<Dish>> GetAllDishes();
        void AddDish(Dish d);
        Task<Dish> GetDishById(int dishId);
        void RemoveDish(Dish d);
    }

    public class DishRepository : IDishRepository
    {
        
        private readonly List<Dish> dishes;

        public DishRepository()
        {
            dishes = new List<Dish>();
            dishes.Add(new Dish { Id = 1, Name = "*JOKER*", MainIngredient = "*JOKER*", QuarentineDate = DateTime.Now, QuarentinePeriod = 14 }); //spise ude, take away, fødselsdag, spise hos venner etc
            dishes.Add(new Dish { Id = 2, Name = "Kylling i karry", MainIngredient = "Kylling", QuarentineDate = DateTime.Now, QuarentinePeriod = 1 });
            dishes.Add(new Dish { Id = 3, Name = "Mørbrad karryret", MainIngredient = "Mørbrad", QuarentineDate = DateTime.Now, QuarentinePeriod = 4 });
            dishes.Add(new Dish { Id = 4, Name = "Æggekage", MainIngredient = "Æg", QuarentineDate = DateTime.Now, QuarentinePeriod = 7 });
            dishes.Add(new Dish { Id = 5, Name = "Hel kylling", MainIngredient = "Kylling", QuarentineDate = DateTime.Now, QuarentinePeriod = 1 });
            dishes.Add(new Dish { Id = 6, Name = "Ristaffel", MainIngredient = "Kylling", QuarentineDate = DateTime.Now, QuarentinePeriod = 1 });
            dishes.Add(new Dish { Id = 7, Name = "Stegt laks", MainIngredient = "Laks", QuarentineDate = DateTime.Now, QuarentinePeriod = 2 });
            dishes.Add(new Dish { Id = 8, Name = "Burger", MainIngredient = "Hakket Okse", QuarentineDate = DateTime.Now, QuarentinePeriod = 3 });
            dishes.Add(new Dish { Id = 9, Name = "Wokret", MainIngredient = "Rejer", QuarentineDate = DateTime.Now, QuarentinePeriod = 0 });
            dishes.Add(new Dish { Id = 10, Name = "Fiskefrikadeller", MainIngredient = "Fiskefars", QuarentineDate = DateTime.Now, QuarentinePeriod = 2});
            dishes.Add(new Dish { Id = 11, Name = "Spaghetti", MainIngredient = "Hakket Okse", QuarentineDate = DateTime.Now, QuarentinePeriod = 3});
            dishes.Add(new Dish { Id = 12, Name = "Hakkebøf", MainIngredient = Ingredient.HakketOkse.ToString(), QuarentineDate = DateTime.Now, QuarentinePeriod = 0});
            dishes.Add(new Dish { Id = 13, Name = "Pandekager", MainIngredient = "Æg", QuarentineDate = DateTime.Now, QuarentinePeriod = 4});
            dishes.Add(new Dish { Id = 14, Name = "Risengrød", MainIngredient = "Ris", QuarentineDate = DateTime.Now, QuarentinePeriod = 0});
            dishes.Add(new Dish { Id = 15, Name = "Pizza", MainIngredient = "Div. Kød", QuarentineDate = DateTime.Now, QuarentinePeriod = 1});
            dishes.Add(new Dish { Id = 16, Name = "Pita", MainIngredient = "Salat", QuarentineDate = DateTime.Now, QuarentinePeriod = 2});
            dishes.Add(new Dish { Id = 17, Name = "Grillmad", MainIngredient = "Div. kød", QuarentineDate = DateTime.Now, QuarentinePeriod = 1});
            dishes.Add(new Dish { Id = 18, Name = "Frikadeller", MainIngredient = "Hakket svin", QuarentineDate = DateTime.Now, QuarentinePeriod = 0});
            dishes.Add(new Dish { Id = 19, Name = "Engelske bøffer", MainIngredient = "Oksekød", QuarentineDate = DateTime.Now, QuarentinePeriod = 1});
            dishes.Add(new Dish { Id = 20, Name = "Rugbrød", MainIngredient = "Pålæg", QuarentineDate = DateTime.Now, QuarentinePeriod = 2});
            dishes.Add(new Dish { Id = 21, Name = "Suppe", MainIngredient = "Rejer", QuarentineDate = DateTime.Now, QuarentinePeriod = 0});
            dishes.Add(new Dish { Id = 22, Name = "Piratens pølsegryde", MainIngredient = "Pølser", QuarentineDate = DateTime.Now, QuarentinePeriod = 0});
            dishes.Add(new Dish { Id = 23, Name = "Pulled pork", MainIngredient = "Nakkefillet", QuarentineDate = DateTime.Now, QuarentinePeriod = 0});
        }

        
        public async Task<List<Dish>> GetAllDishes()
        {
            await Task.Delay(1000);
            return dishes;
        }

        public async void AddDish(Dish d)
        {
            await Task.Delay(1000);
            dishes.Add(d);
        }

        public async void RemoveDish(Dish d)
        {
            await Task.Delay(1000);
            dishes.Remove(d);
        }


        public async Task<Dish> GetDishById(int dishId)
        {
            await Task.Delay(1000);
            return dishes.Where(dish => dish.Id == dishId).FirstOrDefault();
        }

    }
}
