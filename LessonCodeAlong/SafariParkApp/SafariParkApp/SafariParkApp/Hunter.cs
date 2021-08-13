using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Hunter : Person
        
    {
        public IShootable Shooter{ get; set; }
        public Hunter(string fname, string lname) : base (fname, lname)
        {
            
        }

        public string Shoot()
        {
            return $"{Shooter.Shoot()}";
        }

        public override string ToString()
        {

            if (Shooter == null) 
            {
                return $"{base.ToString()}";
            }
            else
            {
                return $"{base.ToString()} with Shooter: " +
                    $"{Shooter.GetType().Name}";
            }
        }

    }
}
