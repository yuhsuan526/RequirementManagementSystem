using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project
{
    public class Requirement
    {
        private int _id;
        private int _projectId;
        private string _name;
        private string _description;
        private string _version;
        private string _memo;

        public Requirement(int id, string name, string description, string version, string memo)
        {
            this._id = id;
            this._name = name;
            this._description = description;
            this._version = version;
            this._memo = memo;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public int ProjectID
        {
            get
            {
                return _projectId;
            }
        }

        public string NAME
        {
            get
            {
                return _name;
            }
        }

        public string DESC
        {
            get
            {
                return _description;
            }
        }

        public string MEMO
        {
            get
            {
                return _memo;
            }
        }
    }
}
