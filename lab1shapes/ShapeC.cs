using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1shapes
{
    public class SquareShape : Shape
    {
        public SquareShape()
                   : base("Квадрат", false, new List<Point>
                   {
                new Point(0, 0),
                new Point(1, 0),
                new Point(0, 1),
                new Point(1, 1)
                   })
        {
        }

        private SquareShape(SquareShape source) : base(source)
        {
        }

        public override Shape Clone()
        {
            return new SquareShape(this);
        }
    }
    public class LShapeShape : Shape
    {
        public LShapeShape()
            : base("Г-образная фигура", false, new List<Point>
            {
                new Point(0, 0),
                new Point(0, 1),
                new Point(0, 2),
                new Point(1, 2)
            })
        {
        }

        private LShapeShape(LShapeShape source) : base(source)
        {
        }

        public override Shape Clone()
        {
            return new LShapeShape(this);
        }
    }
    public class SuperShape : Shape
    {
        private static readonly Random random = new Random();

        public SuperShape()
            : base("Суперфигура", true, GenerateCells())
        {
        }

        private SuperShape(SuperShape source)
            : base(source)
        {
        }

        public override Shape Clone()
        {
            return new SuperShape(this);
        }

        private static List<Point> GenerateCells()
        {
            int targetCount = random.Next(8, 16);

            List<Point> cells = new List<Point>();
            cells.Add(new Point(0, 0));

            while (cells.Count < targetCount)
            {
                Point source = cells[random.Next(cells.Count)];

                int direction = random.Next(4);

                Point next = source;

                if (direction == 0)
                    next = new Point(source.X + 1, source.Y);
                else if (direction == 1)
                    next = new Point(source.X - 1, source.Y);
                else if (direction == 2)
                    next = new Point(source.X, source.Y + 1);
                else
                    next = new Point(source.X, source.Y - 1);

                if (!cells.Contains(next))
                    cells.Add(next);
            }

            int minX = cells[0].X;
            int minY = cells[0].Y;

            foreach (Point cell in cells)
            {
                if (cell.X < minX)
                    minX = cell.X;

                if (cell.Y < minY)
                    minY = cell.Y;
            }

            List<Point> normalizedCells = new List<Point>();

            foreach (Point cell in cells)
            {
                normalizedCells.Add(
                    new Point(cell.X - minX, cell.Y - minY));
            }

            return normalizedCells;
        }
    }
    public abstract class ShapeCreator
    {
        public abstract Shape CreateShape();
    }
    public class SquareCreator : ShapeCreator
    {
        public override Shape CreateShape()
        {
            return new SquareShape();
        }
    }
    public class LShapeCreator : ShapeCreator
    {
        public override Shape CreateShape()
        {
            return new LShapeShape();
        }
    }
    public class SuperShapeCreator : ShapeCreator
    {
        public override Shape CreateShape()
        {
            return new SuperShape();
        }
    }
    public class RandomShapeFactory
    {
        private readonly Random random = new Random();

        public Shape CreateRandomShape()
        {
            int number = random.Next(10);

            ShapeCreator creator;

            if (number < 4)
            {
                creator = new SquareCreator();
            }
            else if (number < 8)
            {
                creator = new LShapeCreator();
            }
            else
            {
                creator = new SuperShapeCreator();
            }

            return creator.CreateShape();
        }
    }
    
}
