using FoodPlanner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Core
{
    public interface IDishService
    {
        Task<List<Dish>> GetAllDishes();
        void AddDish(Dish d);
        Task<Dish> GetDishById(int dishId);
        void RemoveDish(Dish d);
        List<Dish> SelectDishesWithDistinctMainIngredient(List<Dish> dishes);
        void RandomizeDishes(List<Dish> dishes);
        List<Dish> SelectSevenDishes(List<Dish> dishes);
        List<Dish> GetNonQuarentinedDishes(List<Dish> dishes);
        Task<List<Dish>> SelectSevenDistinctDishes();
        void AddDishesToQuarantine(List<Dish> dishes);
    }
    public class DishService : IDishService
    {
        private readonly IDishRepository dishRepository;

        public DishService(IDishRepository dishRepository)
        {
            this.dishRepository = dishRepository;
        }

        
        public async Task<List<Dish>> GetAllDishes()
        {
            return await dishRepository.GetAllDishes();
        }

        public void AddDish(Dish d)
        {
            dishRepository.AddDish(d);
        }

        public async Task<Dish> GetDishById(int dishId)
        {
            return await dishRepository.GetDishById(dishId);
        }

        public void RemoveDish(Dish d)
        {
            dishRepository.RemoveDish(d);
        }

        public List<Dish> SelectDishesWithDistinctMainIngredient(List<Dish> dishes)
        {
           return dishes.DistinctBy(x => x.MainIngredient).ToList();
           // return dishes.GroupBy(x => x.MainIngredient).Select(x => x.First()).ToList();
        }

        public void RandomizeDishes(List<Dish> dishes)
        {
            Random r = new Random();
            dishes.Sort((x, y) => r.Next(-1, 1));
        }

        public List<Dish> SelectSevenDishes(List<Dish> dishes)
        {
            return dishes.Skip(2).Take(7).ToList();    //skip is simply to stir up the result
        }
        public List<Dish> GetNonQuarentinedDishes(List<Dish> dishes)
        {
            return dishes.Where(x => x.QuarentineDate <= DateTime.Now).ToList();
        }

        public async Task<List<Dish>> SelectSevenDistinctDishes()
        {
            var dishes = await GetAllDishes();
            dishes = GetNonQuarentinedDishes(dishes);
            RandomizeDishes(dishes);
            dishes = SelectDishesWithDistinctMainIngredient(dishes);
            dishes = SelectSevenDishes(dishes);
            return dishes;
        }

        public void AddDishesToQuarantine(List<Dish> dishes)
        {        
            foreach (var d in dishes)
            {
               d.QuarentineDate = d.QuarentineDate.AddMinutes(d.QuarentinePeriod);
                //TODO: quarentinelist should be saved permanently for next time  
            }
        }
        
        
    }
}
