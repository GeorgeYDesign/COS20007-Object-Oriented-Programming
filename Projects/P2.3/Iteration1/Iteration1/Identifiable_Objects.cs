using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1
{
    class Identifiable_Object
    {
        public List<string> Identifiers { get; set; }

        public Identifiable_Object(string[] idents)
        {
            Identifiers = new List<string>();
            foreach (string s in idents)
            {
                Identifiers.Add(s.ToLower());
            }
        }

        public bool AreYou(string id)
        {
            foreach (string s in Identifiers)
            {
                if (id.ToLower() == s)
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId()
        {
            if (Identifiers.Count == 0)
            {
                return "";
            }

            return Identifiers[0];
        }

        public void Add_Identifier(string id)
        {
            Identifiers.Add(id.ToLower());
        }
    }
}