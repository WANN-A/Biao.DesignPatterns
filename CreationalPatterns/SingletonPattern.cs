using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biao.DesignPatterns.CreationalPatterns
{
    internal class SingletonPattern
    {
        // 定义一个静态变量保存类的实例
        private static SingletonPattern? singleton;

        // 定义一个标识，确保线程同步
        private static readonly object locker = new object();

        // 构造方法设置成私有，防止类外直接 new
        private SingletonPattern() { }

        /// <summary>
        /// 定义公有方法提供一个实例创建 
        /// </summary>
        /// <returns>实例对象</returns>
        public static SingletonPattern GetInstance()
        {
            // 判断实例是否存在，如果存在直接返回，不必等到 先判断locker加锁解锁，再确定
            if (singleton == null)
            {
                // 如果第一个线程运行到此，会对locker对象加锁
                // 第二个线程运行到这时，如果检测出locker对象处于加锁状态，该线程就会挂起，等第一个线程解锁
                // lock语句运行完后，就会对locker解锁
                lock (locker)
                {
                    // 如果实例为null,创建实例
                    if (singleton == null)
                    {
                        singleton = new SingletonPattern();
                    }
                }
            }
            return singleton;
        }
    }
}
