using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project
{
    public class Project
    {
        private int _id;
        private string _name;
        private string _description;

        public Project(int id, string name, string description)
        {
            this._id = id;
            this._name = name;
            this._description = description;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string NAME
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string DESC
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;

            }
        }
    }
}
