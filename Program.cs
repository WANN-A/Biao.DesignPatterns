namespace Biao.DesignPatterns {
    internal class Program {
        static void Main(string[] args) {
            //单例模式
            Biao.DesignPatterns.CreationalPatterns.SingletonPattern singletonPattern =
                Biao.DesignPatterns.CreationalPatterns.SingletonPattern.GetInstance();
            singletonPattern.ToString();
        }
    }
}