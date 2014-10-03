using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


 public   class controlModel
    {
        int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }
        string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public controlModel(int key, string name)
        {
            this._type = key;
            this._name = name;
        }
    }

