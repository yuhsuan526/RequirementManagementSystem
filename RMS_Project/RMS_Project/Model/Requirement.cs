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
        private string _name;
        private string _description;
        private User _owner;
        private User _handler;
        private string _version;
        private string _memo;
        private int _projectId;
        private int _type;
        private int _priority;
        private int _status;
        private int _createdAt;
        private int _updatedAt;

        public Requirement(int id, int projectId, string name, User owner, User handler, string description, string version, string memo, int type, int priority, int status)
        {
            this._id = id;
            this._projectId = projectId;
            this._name = name;
            this._owner = owner;
            this._handler = handler;
            this._description = description;
            this._version = version;
            this._memo = memo;
            this._type = type;
            this._priority = priority;
            this._status = status;
        }

        public int ID
        {
            get
            {
                return _id;
            }
        }

        public string Name
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

        public string Description
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

        public User Owner
        {
            get
            {
                return _owner;
            }
            set
            {
                _owner = value;
            }
        }

        public User Handler
        {
            get
            {
                return _handler;
            }
            set
            {
                _handler = value;
            }
        }

        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
            }
        }

        public string Memo
        {
            get
            {
                return _memo;
            }
            set
            {
                _memo = value;
            }
        }

        public int ProjectID
        {
            get
            {
                return _projectId;
            }
            set
            {
                _projectId = value;
            }
        }
        public int Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public int Priority
        {
            get
            {
                return _priority;
            }
            set
            {
                _priority = value;
            }
        }
        public int Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        private int CreatedAt
        {
            get
            {
                return _createdAt;
            }
        }
        private int UpdatedAt
        {
            get
            {
                return _updatedAt;
            }
        }
    }
}
