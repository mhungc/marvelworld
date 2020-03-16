using System;
using System.Collections.Generic;
using System.Text;

namespace MarvelWorld.Domain
{
    public class Human
    {
        public string Name { get; set; }
        public string TypeHuman { get; set; }
        public List<int> ListNumbers { get; set; }
        public bool iAmHuman { get; set; }
        public void WhoIAm()
        {
            if (TypeHuman.Equals("Human"))
                this.iAmHuman = true;
            else
                this.iAmHuman = false;
        }
    }
}
