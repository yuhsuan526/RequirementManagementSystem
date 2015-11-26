using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project
{
    public class Item
    {
        public int id;
        public string name;

        public Item(int value, string name)
        {
            this.id = value;
            this.name = name;
        }
        public override string ToString()
        {
            // Generates the text shown in the combo box
            return name;
        }
    }
}
