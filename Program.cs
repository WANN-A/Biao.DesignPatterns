using Biao.DesignPatterns.CreationalPatterns;
using Biao.DesignPatterns.StructuralPatterns;

namespace Biao.DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //测试创建型设计模式
            // 测试单例模式
            TestSingletonPattern();
            // 测试工厂模式
            TestFactoryPattern();
            // 测试抽象工厂模式
            TestAbstractFactoryPattern();
            // 测试建造者模式
            TestBuilderPattern();
            // 测试原型模式
            TestPrototypePattern();

            //测试结构型设计模式
            // 测试适配器模式
            TestAdapterPattern();
            // 测试桥接桥接模式
            TestBridgePattern();
            // 测试装饰器模式
            TestDecoratorPattern();
            // 测试组合模式
            TestCompositePattern();
        }

        /// <summary>
        /// 测试单例模式
        /// </summary>
        static void TestSingletonPattern()
        {
            Console.WriteLine("---------------测试单例模式---------------");
            Biao.DesignPatterns.CreationalPatterns.SingletonPattern singletonPattern =
                Biao.DesignPatterns.CreationalPatterns.SingletonPattern.GetInstance();
            singletonPattern.ToString();
        }

        /// <summary>
        /// 测试工厂模式
        /// </summary>
        static void TestFactoryPattern()
        {
            Console.WriteLine("---------------测试工厂模式---------------");
            Biao.DesignPatterns.CreationalPatterns.ShapeFactory shapeFactory = new CreationalPatterns.ShapeFactory();
            IShape shape1 = shapeFactory.GetShape("Rectangle");
            IShape shape2 = shapeFactory.GetShape("Circle");
            IShape shape3 = shapeFactory.GetShape("Triangle");
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
        }

        /// <summary>
        /// 测试抽象工厂模式
        /// </summary>
        static void TestAbstractFactoryPattern()
        {
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
        }

        /// <summary>
        /// 测试建造者模式
        /// </summary>
        static void TestBuilderPattern()
        {
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
        }

        /// <summary>
        /// 测试原型模式
        /// </summary>
        static void TestPrototypePattern()
        {
            Console.WriteLine("---------------测试原型模式---------------");
            Biao.DesignPatterns.CreationalPatterns.ShapeCache.LoadCache();

            ShapeforPrototypePattern cloneShape = (ShapeforPrototypePattern)ShapeCache.GetShape(1);
            Console.WriteLine("Shape:" + cloneShape.GetType());

            ShapeforPrototypePattern cloneShape2 = (ShapeforPrototypePattern)ShapeCache.GetShape(2);
            Console.WriteLine("Shape:" + cloneShape2.GetType());

            ShapeforPrototypePattern cloneShape3 = (ShapeforPrototypePattern)ShapeCache.GetShape(3);
            Console.WriteLine("Shape:" + cloneShape3.GetType());
        }

        /// <summary>
        /// 测试适配器模式
        /// </summary>
        static void TestAdapterPattern()
        {
            Console.WriteLine("---------------测试适配器模式---------------");
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.Play("mp3", "只因你太美.mp3");
            audioPlayer.Play("mp4", "铁山靠.mp4");
            audioPlayer.Play("vlc", "泥食不食油饼.vlc");
            audioPlayer.Play("avi", "荔枝.avi");
        }

        /// <summary>
        /// 测试桥接模式
        /// </summary>
        static void TestBridgePattern()
        {
            Console.WriteLine("---------------测试桥接模式---------------");
            StructuralPatterns.Shape redShape = new StructuralPatterns.Circle(100, 100, 10, new RedCircle());
            StructuralPatterns.Shape greenShape = new StructuralPatterns.Circle(100, 100, 10, new GreenCircle());
            redShape.Draw();
            greenShape.Draw();
        }

        /// <summary>
        /// 测试装饰器模式
        /// </summary>
        static void TestDecoratorPattern()
        {
            Console.WriteLine("---------------测试装饰器模式---------------");
            ShapeforDecoratorPattern rentangle = new Biao.DesignPatterns.StructuralPatterns.Rentangle();
            ShapeDecorator redRentangle = new RedShapeDecorator(new Biao.DesignPatterns.StructuralPatterns.Rentangle());
            ShapeDecorator redSquare = new RedShapeDecorator(new Biao.DesignPatterns.StructuralPatterns.Square());
            //ShapeforDecoratorPattern redRentangle = new RedShapeDecorator(new Biao.DesignPatterns.StructuralPatterns.Rentangle());
            //ShapeforDecoratorPattern redSquare = new RedShapeDecorator(new Biao.DesignPatterns.StructuralPatterns.Square());

            Console.WriteLine("Rentangle with normal border");
            rentangle.Draw();
            Console.WriteLine("----");
            Console.WriteLine("Rentangle of red border");
            redRentangle.Draw();
            Console.WriteLine("----");
            Console.WriteLine("Square of red border");
            redSquare.Draw();
        }

        /// <summary>
        /// 测试组合模式
        /// </summary>
        static void TestCompositePattern()
        {
            Console.WriteLine("---------------测试组合模式---------------");
            Employee CEO = new Employee("Alice", "CEO", 30000);

            Employee headSales = new Employee("Bob", "Head Sales", 20000);

            Employee headMarking = new Employee("Tim", "Head Marking", 20000);

            Employee clerk1 = new Employee("Mr.W", "Marking", 10000);
            Employee clerk2 = new Employee("Mr.B", "Marking", 10000);

            Employee salesExecutive1 = new Employee("Ms.Q", "Sales", 10000);
            Employee salesExecutive2 = new Employee("Ms.E", "Sales", 10000);

            CEO.Add(headSales);
            CEO.Add(headMarking);

            headMarking.Add(clerk1);
            headMarking.Add(clerk2);

            headSales.Add(salesExecutive1);
            headSales.Add(salesExecutive2);

            // 打印该组织的所有员工
            Console.WriteLine(CEO);
            foreach (Employee e in CEO.GetSubordinates())
            {
                Console.WriteLine(e);
                foreach (Employee ee in e.GetSubordinates())
                {
                    Console.WriteLine(ee);
                }
            }
        }
    }
}