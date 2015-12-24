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
        private string _version;
        private string _memo;
        private int _projectId;
        private int _priorityTypeId;
        private int _statusTypeId;
        private int _createdAt;
        private int _updatedAt;

        public Requirement(int id, int projectId, string name, string description, string version, string memo)
        {
            this._id = id;
            this._projectId = projectId;
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

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }

        public User Owner
        {
            get
            {
                return _owner;
            }
        }

        public string Version
        {
            get
            {
                return _version;
            }
        }

        public string Memo
        {
            get
            {
                return _memo;
            }
        }

        public int ProjectID
        {
            get
            {
                return _projectId;
            }
        }

        public int PriorityTypeId
        {
            get
            {
                return _priorityTypeId;
            }
        }
        private int StatusTypeId
        {
            get
            {
                return _statusTypeId;
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
