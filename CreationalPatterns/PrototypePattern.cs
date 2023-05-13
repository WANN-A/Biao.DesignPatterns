/*************************************************************************************
 *
 * 文 件 名：	PrototypePattern.cs
 * 描 述：       原型模式（Prototype Pattern）是用于创建重复的对象，同时又能保证性能。
 *
 * 版 本：	    v1.0
 * 创 建 者：	BIAO
 * 创 建 时 间：	2023/5/7 15:40
 * 
*************************************************************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.CreationalPatterns
{
    /// <summary>
    /// 创建一个实现了调用Object对象的MemberwiseClone方法的Clone方法的抽象类。
    /// </summary>
    public abstract class ShapeforPrototypePattern
    {
        private int id;
        protected string type;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string GetType()
        {
            return type;
        }

        public abstract void Draw();

        public Object Clone()
        {
            Object clone = null;
            try
            {
                clone = base.MemberwiseClone();
            }
            catch
            {
                Console.WriteLine("Clone出错！");
            }
            return clone;
        }
    }

    /// <summary>
    /// 创建了扩展ShapeforPrototypePattern抽象类的实体类RectangleforPrototypePattern
    /// </summary>
    public class RectangleforPrototypePattern : ShapeforPrototypePattern
    {
        public RectangleforPrototypePattern()
        {
            type = "Rectangle";
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle内的Draw方法");
        }
    }

    /// <summary>
    /// 创建了扩展ShapeforPrototypePattern抽象类的实体类SquareforPrototypePattern
    /// </summary>
    public class SquareforPrototypePattern : ShapeforPrototypePattern
    {
        public SquareforPrototypePattern()
        {
            type = "Square";
        }

        public override void Draw()
        {
            Console.WriteLine("Square内的Draw方法");
        }
    }

    /// <summary>
    /// 创建了扩展ShapeforPrototypePattern抽象类的实体类CircleforPrototypePattern
    /// </summary>
    public class CircleforPrototypePattern : ShapeforPrototypePattern
    {
        public CircleforPrototypePattern()
        {
            type = "Circle";
        }

        public override void Draw()
        {
            Console.WriteLine("Circle内的Draw方法");
        }
    }

    /// <summary>
    /// 创建一个类，从数据库获取实体类，并把它们存储在一个 Hashtable 中。
    /// </summary>
    public class ShapeCache
    {
        private static Hashtable shapeMap = new Hashtable();

        public static ShapeforPrototypePattern GetShape(int shapeId)
        {
            ShapeforPrototypePattern cachedShape = (ShapeforPrototypePattern)shapeMap[shapeId];
            return (ShapeforPrototypePattern)cachedShape.Clone();
        }

        public static void LoadCache()
        {
            CircleforPrototypePattern circle = new CircleforPrototypePattern();
            circle.Id = 1;
            shapeMap.Add(circle.Id, circle);

            SquareforPrototypePattern square = new SquareforPrototypePattern();
            square.Id = 2;
            shapeMap.Add(square.Id, square);

            RectangleforPrototypePattern rectangle = new RectangleforPrototypePattern();
            rectangle.Id = 3;
            shapeMap.Add(rectangle.Id, rectangle);
        }
    }
}
