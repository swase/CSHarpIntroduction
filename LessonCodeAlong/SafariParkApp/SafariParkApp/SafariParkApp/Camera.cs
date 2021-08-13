using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp 
{
    public class Camera : IShootable
    {
        private string _brand;

        public Camera(string brand)
        {
            this._brand = brand;
        }

        public string Shoot()
        {
            return $"Flash!! Shooting a {this.ToString()}";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this._brand}";
        }
    }
}
