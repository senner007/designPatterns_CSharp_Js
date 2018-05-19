using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single
{
    public class Singleton
    {
        private static Singleton _instance;
        public string FullName;

        public void Makename(string firstName, string lastName)
        {
            FullName = firstName + " " + lastName;
        }

        private Singleton() { }

        public static Singleton Instance => _instance ?? (_instance = new Singleton());
    }
}
