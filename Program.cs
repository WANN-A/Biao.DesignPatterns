using Biao.DesignPatterns.CreationalPatterns;

namespace Biao.DesignPatterns {
    internal class Program {
        static void Main(string[] args) {
            //测试单例模式
            Biao.DesignPatterns.CreationalPatterns.SingletonPattern singletonPattern =
                Biao.DesignPatterns.CreationalPatterns.SingletonPattern.GetInstance();
            singletonPattern.ToString();

            //测试工厂模式
            Biao.DesignPatterns.CreationalPatterns.ShapeFactory shapeFactory = new CreationalPatterns.ShapeFactory();
            IShape shape1 = shapeFactory.GetShape("Rectangle");
            IShape shape2 = shapeFactory.GetShape("Circle");
            IShape shape3 = shapeFactory.GetShape("Triangle");
            shape1.Draw();
            shape2.Draw();
            shape3.Draw();
        }
    }
}