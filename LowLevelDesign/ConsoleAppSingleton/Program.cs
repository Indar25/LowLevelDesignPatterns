using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleAppSingleton
{
    public class Connection
    {
        public static Connection _instance = null;
        public static object obj = new object();
        private static readonly Lazy<Connection> con = new Lazy<Connection>(() => new Connection());
        private Connection()
        {

        }
        public static Connection getInstance()//t5,t6,t7
        {

            if (_instance == null)
            {
                lock (obj)//t1,t2,t3,t4
                {
                    if (_instance == null)
                    {
                        Console.WriteLine("Instance");
                        _instance = new Connection();//t1
                    }
                }
            }
            return _instance; //t2,t3,t4 //t5,t6,t7
        }
        public static Connection getInstance2()
        {
            Console.WriteLine("Instance");
            return con.Value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < 100; i++)
            {
                Thread thread = new Thread(() => AccessConnection());
                thread.Start();
                threads.Add(thread);
            }
            foreach (var item in threads)
            {
                item.Join();
            }
            //Thread t1 = new Thread(() => AccessConnection());
            //Thread t2 = new Thread(() => AccessConnection());
            //t1.Start();
            //t2.Start();
            //t1.Join();
            //t2.Join();
            Console.ReadKey();
        }
        static void AccessConnection()
        {
            Connection con = Connection.getInstance();
            Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}: Instance HashCode = {con.GetHashCode()}");

        }
    }
}
