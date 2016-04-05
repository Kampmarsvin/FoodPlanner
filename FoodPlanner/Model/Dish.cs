using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodPlanner.Model
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainIngredient { get; set; }
        public DateTime QuarentineDate { get; set; }
        public int QuarentinePeriod { get; set; }

        
        public override bool Equals(Object obj)
        {
            Dish d = obj as Dish;
            if (d == null)
                return false;
            else
                return Id.Equals(d.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
