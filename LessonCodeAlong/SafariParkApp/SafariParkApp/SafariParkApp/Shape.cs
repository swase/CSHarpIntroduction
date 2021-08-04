using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public abstract class Shape
    {
        public abstract int CalculateArea();

    }

    public sealed class Rectangle : Shape 
    {
        private int _width = 0;
        private int _height = 0;
        public override int CalculateArea()
        {
            return _width * _height;
        }

        public Rectangle(int width, int height)
        {
            this._width = width;
            this._height = height;
        }

        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }

    }
}
