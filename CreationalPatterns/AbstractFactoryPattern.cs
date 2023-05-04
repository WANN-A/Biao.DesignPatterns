using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.CreationalPatterns {
    //internal class AbstractFactoryPattern {
    //}
    /// <summary>
    /// 定义一个图形接口
    /// </summary>
    public interface Shape {
        void Draw();
    }
    /// <summary>
    /// 定义实现图形接口的方形实体类
    /// </summary>
    public class Square : Shape {
        public void Draw() {
            Console.WriteLine("画矩形。");
        }
    }
    /// <summary>
    /// 定义实现图形接口的菱形实体类
    /// </summary>
    public class Rhombus : Shape {
        public void Draw() {
            Console.WriteLine("画菱形。");
        }
    }
    /// <summary>
    /// 定义一个颜色接口
    /// </summary>
    public interface Color {
        public void Fill();
    }
    /// <summary>
    /// 定义实现颜色接口的红色实体类
    /// </summary>
    public class Red : Color {
        public void Fill() {
            Console.WriteLine("填充红色。");
        }
    }
    /// <summary>
    /// 定义实现颜色接口的黄色实体类
    /// </summary>
    public class Yellow : Color {
        public void Fill() {
            Console.WriteLine("填充黄色。");
        }
    }
    /// <summary>
    /// 为 Color 和 Shape 对象创建抽象类来获取工厂。
    /// </summary>
    public abstract class AbstractFactory {
        public abstract Shape GetShape(string ShapeType);
        public abstract Color GetColor(string ColorType);
    }
    /// <summary>
    /// 创建扩展了 AbstractFactory 的工厂类ShapeFty，基于给定的信息生成实体类的对象。
    /// </summary>
    public class ShapeFty : AbstractFactory {
        public override Shape GetShape(string ShapeType) {
            if (ShapeType == null) {
                return null;
            } else if (ShapeType == "Square") {
                return new Square();
            } else if (ShapeType == "Rhombus") {
                return new Rhombus();
            }
            return null;
        }

        public override Color GetColor(string ColorType) {
            return null;
        }
    }
    /// <summary>
    /// 创建扩展了 AbstractFactory 的工厂类ColorFty，基于给定的信息生成实体类的对象。
    /// </summary>
    public class ColorFty : AbstractFactory {
        public override Shape GetShape(string ShapeType) {
            return null;
        }

        public override Color GetColor(string ColorType) {
            if (ColorType == null) {
                return null;
            } else if (ColorType == "Red") {
                return new Red();
            } else if (ColorType == "Yellow") {
                return new Yellow();
            }
            return null;
        }
    }
    /// <summary>
    /// 创建一个工厂创造器/生成器类，通过传递形状或颜色信息来获取工厂。
    /// </summary>
    public class FactoryProducer {
        public static AbstractFactory GetFactory(string FactoryType) {
            if (FactoryType == "Shape") {
                return new ShapeFty();
            } else if (FactoryType == "Color") {
                return new ColorFty();
            }
            return null;
        }
    }
}
