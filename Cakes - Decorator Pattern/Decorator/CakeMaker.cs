using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
	public class CakeMaker
	{
        private List<CakeBase> ingredients;
        private CakeBase currentCake;

        public CakeMaker()
        {
            currentCake = null;
            ingredients = new List<CakeBase>();
            ingredients.Add(new ChocolateCake("Chocolate Cake"));
            ingredients.Add(new FruitCake("Fruit Cake"));
            ingredients.Add(new ChocoCream("Choco Cream", null));
            ingredients.Add(new WhippedCream("Whipped Cream", null));
            ingredients.Add(new Strawberry("Strawberry", null));
            ingredients.Add(new ForestFruits("Forest Fruits", null));
        }

        private CakeBase getCakeBaseByName(string name)
        {
            foreach(CakeBase i in ingredients)
            {
                if(i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
		public void AddToppingBase(string Name)
		{
            Console.WriteLine(Name);
            CakeBase cb = getCakeBaseByName(Name);
            if(cb != null)
            {
                if(currentCake != null)
                {
                    if(cb is ToppingBase)
                    {
                        CakeBase cbCopy = cb.Copy();
                        ((ToppingBase)cbCopy).NextBase = currentCake.Copy();
                        currentCake = cbCopy;
                    }
                }
            }
		}

		public void SetCakeType(string Name)
		{
            CakeBase cb = getCakeBaseByName(Name);
            if (currentCake == null)
            {
                if(!(cb is ToppingBase))
                {
                    currentCake = cb.Copy();
                }
            }
		}

		public CakeBase GetCake()
		{
            return currentCake;
		}

		public void RemoveCake()
		{
            currentCake = null;
		}

		public List<CakeBase> GetAllIngredients()
		{
            return ingredients;
		}
	}
}
