using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConcurrencia
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object bloqueo = new object();

        public string CadenaConexion;
        public Singleton() 
        {
            CadenaConexion = "";
        }  
        public static Singleton Instance
        {
            get
            { 
                lock (bloqueo)
                {
                    if (instance == null)
                    {
                    instance = new Singleton();
                    }
                    return instance;
                }
            } 
        }
    }
}
