using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassPlayground
{
    internal class student
    {
        public int year;
        public int id;
        public string name;
        public Dictionary<string, List<int>> subjects = new Dictionary<string, List<int>>();

        public void AddSubject(string X)
        {
            subjects.Add(X, new List<int>());
        }
    }
}
