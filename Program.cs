using Biao.DesignPatterns.CreationalPatterns;

namespace Biao.DesignPatterns {
    internal class Program {
        static void Main(string[] args) {
            //测试单例模式
            Biao.DesignPatterns.CreationalPatterns.SingletonPattern singletonPattern =
                Biao.DesignPatterns.CreationalPatterns.SingletonPattern.GetInstance();
            singletonPattern.ToString();
            Console.WriteLine("------------------------------");
            //测试工厂模式
            Biao.DesignPatterns.CreationalPatterns.ShapeFactory shapeFactory = new CreationalPatterns.ShapeFactory();
            IShape shape1 = shapeFactory.GetShape("Rectangle");
            IShape shape2 = shapeFactory.GetShape("Circle");
            IShape shape3 = shapeFactory.GetShape("Triangle");
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
            Console.WriteLine("------------------------------");
            //测试抽象工厂模式
            Biao.DesignPatterns.CreationalPatterns.AbstractFactory shapeFactory1 = FactoryProducer.GetFactory("Shape");
            Biao.DesignPatterns.CreationalPatterns.Shape shp1= shapeFactory1.GetShape("Square");
            shp1.Draw();
            Biao.DesignPatterns.CreationalPatterns.Shape shp2 = shapeFactory1.GetShape("Rhombus");
            shp2.Draw();

            Biao.DesignPatterns.CreationalPatterns.AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");
            Biao.DesignPatterns.CreationalPatterns.Color clr1 = colorFactory.GetColor("Red");
            clr1.Fill();
            Biao.DesignPatterns.CreationalPatterns.Color clr2 = colorFactory.GetColor("Yellow");
            clr2.Fill();
            Console.WriteLine("------------------------------");
        }
    }
}