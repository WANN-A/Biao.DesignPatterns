/*************************************************************************************
 *
 * 文 件 名：	BridgePattern.cs
 * 描 述：   桥接模式
 *
 * 版 本：	v1.0
 * 创 建 者：	BiaoWang
 * 创 建 时 间：	2023/5/14 14:43
 * 
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.StructuralPatterns
{
    /// <summary>
    /// 创建桥接实现接口
    /// </summary>
    public interface DrawAPI
    {
        public void DrawCircle(int radius, int x, int y);
    }

    /// <summary>
    /// 创建2个实现DrawAPI接口的实体类
    /// </summary>
    public class RedCircle : DrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: red, radius: "
         + radius + ", x: " + x + ", " + y + "]");
        }
    }

    public class GreenCircle : DrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.WriteLine("Drawing Circle[ color: green, radius: "
         + radius + ", x: " + x + ", " + y + "]");
        }
    }

    /// <summary>
    /// 使用DrawAPI创建抽象类Shape
    /// </summary>
    public abstract class Shape
    {
        protected DrawAPI drawAPI;
        protected Shape(DrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void Draw();
    }

    /// <summary>
    /// 创建了Shape抽象类的实体类Circle
    /// </summary>
    public class Circle : Shape
    {
        public int x, y, radius;

        public Circle(int x, int y, int radius, DrawAPI drawAPI) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.DrawCircle(radius, x, y);
        }
    }
}