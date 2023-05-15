/*************************************************************************************
 *
 * 文 件 名：	DecoratorPattern.cs
 * 描 述：   装饰器模式
 *
 * 版 本：	v1.0
 * 创 建 者：	BiaoWang
 * 创 建 时 间：	2023/5/15 21:12
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
    /// 创建一个Shape接口，这里定义这个名字因为和其他模式的接口名/类名重复了，所以取ShapeforDecoratorPattern
    /// </summary>
    public interface ShapeforDecoratorPattern
    {
        void Draw();
    }

    /// <summary>
    /// 创建2个实现该形状接口的实体类
    /// </summary>
    public class Rentangle : ShapeforDecoratorPattern
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }

    public class Square : ShapeforDecoratorPattern
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Square");
        }
    }

    /// <summary>
    /// 创建实现了Shape接口的抽象装饰类
    /// </summary>
    public abstract class ShapeDecorator : ShapeforDecoratorPattern
    {
        protected ShapeforDecoratorPattern decoratedShape;

        public ShapeDecorator(ShapeforDecoratorPattern decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }

        public virtual void Draw()
        {
            decoratedShape.Draw();
        }
    }

    /// <summary>
    /// 创建扩展了ShapeDecorator类的实体装饰类
    /// </summary>
    public class RedShapeDecorator : ShapeDecorator
    {
        public RedShapeDecorator(ShapeforDecoratorPattern decoratedShape) : base(decoratedShape)
        {
        }

        public override void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);
        }

        private void SetRedBorder(ShapeforDecoratorPattern decoratedShape)
        {
            Console.WriteLine("Border Color:Red");
        }
    }
}
