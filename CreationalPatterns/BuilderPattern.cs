/*************************************************************************************
 *
 * 文 件 名：	BuilderPattern.cs
 * 描 述：      建造者模式（Builder Pattern）使用多个简单的对象一步一步构建成一个复杂的对象。 
 *
 * 版 本：	    v1.0
 * 创 建 者：	BIAO
 * 创 建 时 间：	2023/5/7 14:23
 * 
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.CreationalPatterns
{
    internal class BuilderPattern
    {
    }

    /// <summary>
    /// 创建一个表示食物条目的接口
    /// </summary>
    public interface Item
    {
        public string Name();
        public IPacking Packing();
        public float Price();
    }

    /// <summary>
    /// 创建一个表示食物包装的接口
    /// </summary>
    public interface IPacking
    {
        public string Pack();
    }

    /// <summary>
    /// 实现Packing接口的实体类Warpper
    /// </summary>
    public class Warpper : IPacking
    {
        public string Pack()
        {
            return "Warpper";
        }
    }

    /// <summary>
    /// 实现Packing接口的实体类Bottle
    /// </summary>
    public class Bottle : IPacking
    {
        public string Pack()
        {
            return "Bottle";
        }
    }

    /// <summary>
    /// 创建实现Item接口的抽象类Burger，该类提供默认功能
    /// </summary>
    public abstract class Burger : Item
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Warpper();
        }

        public abstract float Price();
    }

    /// <summary>
    /// 创建实现Item接口的抽象类ColdDrink，该类提供默认功能
    /// </summary>
    public abstract class ColdDrink : Item
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }

    /// <summary>
    /// 创建扩展Burger抽象类的实体类VegBurger
    /// </summary>
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "VegBurger";
        }

        public override float Price()
        {
            return 25.0f;
        }
    }

    /// <summary>
    /// 创建扩展Burger抽象类的实体类ChickenBurger
    /// </summary>
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "ChickenBurger";
        }

        public override float Price()
        {
            return 30.0f;
        }
    }

    /// <summary>
    /// 创建扩展ColdDrink抽象类的实体类Coke
    /// </summary>
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 30.0f;
        }
    }

    /// <summary>
    /// 创建扩展ColdDrink抽象类的实体类Orangejuice
    /// </summary>
    public class Orangejuice : ColdDrink
    {
        public override string Name()
        {
            return "Orangejuice";
        }

        public override float Price()
        {
            return 28.0f;
        }
    }

    /// <summary>
    /// 创建一个 Meal 类，带有上面定义的 Item 对象。
    /// </summary>
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine("Item:" + item.Name() + ", Packing:" + item.Packing().Pack() + ", Price:" + item.Price());
            }
        }
    }

    /// <summary>
    /// 创建一个 MealBuilder 类，实际的 builder 类负责创建 Meal 对象。
    /// </summary>
    public class MealBuilder
    {
        public Meal PrepareVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            Meal meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Orangejuice());
            return meal;
        }
    }
}