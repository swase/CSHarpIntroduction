using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person
        
    {
        private string _camera;
        public Hunter(string fname, string lname, string camera = "") : base (fname, lname)
        {
            this._camera = camera;
        }

        public string Shoot()
        {
            return $"{base.GetFullName()} has taken a photo with their {this._camera}";
        }

        public override string ToString()
        {

            return $"{base.ToString()}, Camera: {_camera}";
        }

    }
}
