﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand = "";

        public virtual string Shoot()
        {
            return $"!! Shooting a {this.ToString()}";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this._brand}";
        }

        public Weapon(string brand)
        {
            this._brand = brand;
        }
    }
}
