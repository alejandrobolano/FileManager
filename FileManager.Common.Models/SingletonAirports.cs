using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.Common.Models
{
    class SingletonAirports
    {
        private static SingletonAirports instance = null;
        private static readonly object padlock = new object();

        private SingletonAirports()
        {

        }

        public static SingletonAirports Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonAirports();
                    }
                    return instance;
                }
            }
        }
    }
}
