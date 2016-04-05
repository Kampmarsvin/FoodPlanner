using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FoodPlanner.Model;
using System.Threading.Tasks;
using Ninject;
using Moq;
using FoodPlanner.Core;
using System.Collections.Generic;

namespace FoodPlanner.UnitTests.Core
{
    [TestClass]
    public class ItemRepositoryTests
    {

        [TestMethod]
        public void Can_Get_Dish_By_Id()
        {
            //Arrange
            var expected = new Dish { Id = 1, MainIngredient = "Oksekød", Name = "Spaghetti" };
            var dishReposityMock = new Mock<IDishRepository>();
            dishReposityMock
               .Setup(d => d.GetDishById(1))
               .Returns(Task.FromResult(new Dish { Id = 1, MainIngredient = "Oksekød", Name = "Spaghetti" }));
            var dishService = new DishService(dishReposityMock.Object);

            //Act
            var actual = dishService.GetDishById(expected.Id);

            //Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.MainIngredient, actual.Result.MainIngredient);
            Assert.AreEqual(expected.Name, actual.Result.Name);
        }


       


        [TestMethod]
        public void Can_Get_All_Dishes()
        {
            //Arrange
            var dish1 = new Dish { Id = 1, MainIngredient = "Oksekød", Name = "Spaghetti" };
            var dish2 = new Dish { Id = 2, MainIngredient = "Kylling", Name = "Kylling i karry" };
            List<Dish> l = new List<Dish>();
            l.Add(dish1);
            l.Add(dish2);

            var dishReposityMock = new Mock<IDishRepository>();
            dishReposityMock
               .Setup(d => d.GetAllDishes())
               .Returns(Task.FromResult(l));
            var dishService = new DishService(dishReposityMock.Object);

            //Act
            var actual = dishService.GetAllDishes();

            //Assert
            Assert.AreEqual(l.Count, actual.Result.Count);

        }

    }
}
