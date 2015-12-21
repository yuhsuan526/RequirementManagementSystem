using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_Project
{
    public class Test
    {
        int _id;
        int _projectId;
        string _name;
        string _description;

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

    }
}
