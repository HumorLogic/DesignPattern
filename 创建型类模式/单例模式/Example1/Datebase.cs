using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.创建型类模式.单例模式.Example1
{

    //class program
    //{
    //    static void Main(string[] arg)
    //    {
    //        Database db = Database.GetInstance();
    //        Database db2 = Database.GetInstance();
    //        db.QueryMemory();
    //        db.Save(500);
    //        db2.QueryMemory();
    //    }
    //}
    public  class Database
    {

        private static Database instance;
        private static readonly object syncRoot = new object();
        private float storage;
        private float memory;
        public Database()
        {
            this.storage = 0;
            this.memory = 1024;
        }



        public static Database GetInstance()
        {
          
                if (Database.instance == null)
                {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                }
                }
            return instance;
        }

        public void Save(float useStorage)
        {
            storage += useStorage;
        }
        public void QueryMemory()
        {
            Console.WriteLine("剩余内存：" + (memory - storage) + "MB");
        }

    }



}
