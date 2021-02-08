// Skylar Peters
// CIS 237
// 2/8/2021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment1
{
    class Beverage
    {
        //*************************
        // Variables
        //*************************
        private string _id;
        private string _name;
        private string _pack;
        private decimal _price;
        private bool _active;

        //*************************
        // Properties
        //*************************
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }

        //*************************
        // Methods
        //*************************
        public override string ToString()
        {
            return _id + " " + _name + " " + _pack + " " + _price + " " + _active;
        }

        //*************************
        // Constructors
        //*************************
        public Beverage(string ID, string Name, string Pack, decimal Price, bool Active)
        {
            this._id = ID;
            this._name = Name;
            this._pack = Pack;
            this._price = Price;
            this._active = Active;
        }

        public Beverage() { }
    }
}
