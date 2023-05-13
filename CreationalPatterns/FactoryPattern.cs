using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.CreationalPatterns
{
    /// <summary>
    /// 定义一个图形接口
    /// </summary>
    public interface IShape
    {
        void Draw();
    }

    /// <summary>
    /// 定义实现图形接口的矩形实体类
    /// </summary>
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画矩形。");
        }
    }

    /// <summary>
    /// 定义实现图形接口的圆形实体类
    /// </summary>
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画圆形。");
        }
    }

    /// <summary>
    /// 定义实现图形接口的三角形实体类
    /// </summary>
    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画三角形。");
        }
    }

    /// <summary>
    /// 创建Shape的工厂类，通过传递类型信息来获取实体类的对象。
    /// </summary>
    public class ShapeFactory
    {
        public IShape GetShape(string ShapeType)
        {
            if (ShapeType == null)
            {
                return null;
            }
            else if (ShapeType == "Rectangle")
            {
                return new Rectangle();
            }
            else if (ShapeType == "Circle")
            {
                return new Circle();
            }
            else if (ShapeType == "Triangle")
            {
                return new Triangle();
            }
            return null;
        }
    }
}
