﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class LaserGun : Weapon
    {
        public override string Shoot()
        {
            return $"Zing{base.Shoot()}";
        }

        public LaserGun(string brand) :base(brand)
        {

        }
    }
}
