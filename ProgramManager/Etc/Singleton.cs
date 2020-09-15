using System;

namespace ProgramManager.Etc
{
    public class Singleton<T> where T : class, new()
    {
        private static object _syncobj = new object();
        private static volatile T _instance = null;
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new T();
                        }
                    }
                }
                return _instance;
            }
        }

        public delegate void ExceptionEventHandler(string LocationID, Exception ex);
    }
}
