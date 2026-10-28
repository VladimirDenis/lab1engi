using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1shapes
{
    public abstract class Shape
    {
        public string Name { get; protected set; }
        public bool IsSuper { get; protected set; }
        public List<Point> Cells { get; protected set; }

        protected Shape(string name, bool isSuper, List<Point> cells)
        {
            Name = name;
            IsSuper = isSuper;
            Cells = cells;
        }

        protected Shape(Shape source)
        {
            Name = source.Name;
            IsSuper = source.IsSuper;
            Cells = new List<Point>(source.Cells);
        }

        public abstract Shape Clone();
    }
}
