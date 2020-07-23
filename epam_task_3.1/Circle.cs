using MaterialsLibrary;
using System;

namespace epam_task_3._1
{
    public class Circle: Figure
    {
        private double _r;

        public Circle(double r)
        {
            if (r > 0)
            {
                _r = r;
            }
            else
            {
                throw new Exception("R cannot be 0 or below");
            }
        }

        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(_r, 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * _r;
            }
        }

        public double R { get => _r; set => _r = value; }

    }

    public class PaperCircle:Circle, IPaper
    {
        
        public PaperCircle(double _r, Color color): base(_r)
        {
            Color = color;
            IsColoredAgain = false;
        }

        public PaperCircle(double _r, Figure figure) : base(_r)
        {
            if(figure is IPaper)
            {
                if(!(figure.Area < (Math.PI * Math.Pow(_r, 2))))
                {
                    throw new Exception("Cannot create a bigger Figure from a smaller Figure");
                }
                else
                {
                    this.Color = ((IPaper)figure).Color;
                    this.IsColoredAgain = ((IPaper)figure).IsColoredAgain;
                }
            }
            else
            {
                throw new Exception("Cannot create a Paper form a Film");
            }
        }

        public Color Color { get; set; }

        public bool IsColoredAgain { get; set; }

        public void Paint(Color newColor)
        {
            if (!IsColoredAgain)
            {
                IsColoredAgain = true;

                Color = newColor;
            }
            else
            {
                throw new Exception("Cannot paint a same Figure twice");
            }
        }

        public override bool Equals(object obj)
        {
            if(obj is PaperCircle)
            {
                PaperCircle paperCircle = obj as PaperCircle;

                if(this.R == paperCircle.R && this.Color == paperCircle.Color)
                {
                    return true;
                }
                else
                {
                    return false; 
                }
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return R.GetHashCode() ^ Color.GetHashCode();
        }
    }
       
    public class FilmCircle:Circle, IFilm
    {
        public FilmCircle(double _r): base(_r)
        {
        }

        public FilmCircle(double _r, Figure figure) : base(_r)
        {
            if (figure is IFilm)
            {
                if (!(figure.Area < (Math.PI * Math.Pow(_r, 2))))
                {
                    throw new Exception("Cannot create a bigger Figure from a smaller Figure");
                }
            }
            else
            {
                throw new Exception("Cannot create a Film form a Paper");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is FilmCircle)
            {
                FilmCircle paperCircle = obj as FilmCircle;

                if (this.R == paperCircle.R)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return R.GetHashCode();
        }
    }
}
