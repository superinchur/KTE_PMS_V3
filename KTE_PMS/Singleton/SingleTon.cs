using System;
using System.Linq;

namespace KTE_PMS.Singleton
{
    public abstract class SingleTonBase<T> where T : SingleTonBase<T>
    {
        private static volatile T _instance;
        private static object syncRoot = new object();

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        _instance = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
                return _instance;
            }
        }

    }
}
