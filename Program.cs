using Biao.DesignPatterns.CreationalPatterns;
using Biao.DesignPatterns.StructuralPatterns;

namespace Biao.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 测试创建型设计模式
            /*
            //测试单例模式
            Console.WriteLine("---------------测试单例模式---------------");
            Biao.DesignPatterns.CreationalPatterns.SingletonPattern singletonPattern =
                Biao.DesignPatterns.CreationalPatterns.SingletonPattern.GetInstance();
            singletonPattern.ToString();

            //测试工厂模式
            Console.WriteLine("---------------测试工厂模式---------------");
            Biao.DesignPatterns.CreationalPatterns.ShapeFactory shapeFactory = new CreationalPatterns.ShapeFactory();
            IShape shape1 = shapeFactory.GetShape("Rectangle");
            IShape shape2 = shapeFactory.GetShape("Circle");
            IShape shape3 = shapeFactory.GetShape("Triangle");
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();

            //测试抽象工厂模式
            Console.WriteLine("---------------测试抽象工厂模式-----------");
            Biao.DesignPatterns.CreationalPatterns.AbstractFactory shapeFactory1 = FactoryProducer.GetFactory("Shape");
            Biao.DesignPatterns.CreationalPatterns.Shape shp1 = shapeFactory1.GetShape("Square");
            shp1.Draw();
            Biao.DesignPatterns.CreationalPatterns.Shape shp2 = shapeFactory1.GetShape("Rhombus");
            shp2.Draw();

            Biao.DesignPatterns.CreationalPatterns.AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");
            Biao.DesignPatterns.CreationalPatterns.Color clr1 = colorFactory.GetColor("Red");
            clr1.Fill();
            Biao.DesignPatterns.CreationalPatterns.Color clr2 = colorFactory.GetColor("Yellow");
            clr2.Fill();

            //测试建造者模式
            Console.WriteLine("---------------测试建造者模式-------------");
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("VegMeal");
            vegMeal.ShowItems();
            Console.WriteLine("Total Cost:" + vegMeal.GetCost());

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("NonVegMeal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total Cost:" + nonVegMeal.GetCost());

            //测试原型模式
            Console.WriteLine("---------------测试原型模式---------------");
            Biao.DesignPatterns.CreationalPatterns.ShapeCache.LoadCache();

            ShapeforPrototypePattern cloneShape = (ShapeforPrototypePattern)ShapeCache.GetShape(1);
            Console.WriteLine("Shape:" + cloneShape.GetType());

            ShapeforPrototypePattern cloneShape2 = (ShapeforPrototypePattern)ShapeCache.GetShape(2);
            Console.WriteLine("Shape:" + cloneShape2.GetType());

            ShapeforPrototypePattern cloneShape3 = (ShapeforPrototypePattern)ShapeCache.GetShape(3);
            Console.WriteLine("Shape:" + cloneShape3.GetType());*/

            // 测试结构型设计模式
            //测试适配器模式
            Console.WriteLine("---------------测试适配器模式---------------");
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "只因你太美.mp3");
            audioPlayer.Play("mp4", "铁山靠.mp4");
            audioPlayer.Play("vlc", "泥食不食油饼.vlc");
            audioPlayer.Play("avi", "荔枝.avi");

            //测试桥接桥接模式
            Console.WriteLine("---------------测试桥接模式---------------");
            StructuralPatterns.Shape redShape = new StructuralPatterns.Circle(100, 100, 10, new RedCircle());
            StructuralPatterns.Shape greenShape = new StructuralPatterns.Circle(100, 100, 10, new GreenCircle());

            redShape.Draw();
            greenShape.Draw();

        }
    }
}