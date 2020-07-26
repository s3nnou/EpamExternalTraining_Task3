using MaterialsLibrary;
using System;

namespace Figures
{
    /// <summary>
    /// Base class for a Circle
    /// </summary>
    public class Circle: Figure
    {
        /// <summary>
        /// Radius
        /// </summary>
        private double _r;

        /// <summary>
        /// Circle class constructor
        /// </summary>
        /// <param name="r"></param>
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

        /// <summary>
        /// Area accessor
        /// </summary>
        public override double Area
        {
            get
            {
                return Math.PI * Math.Pow(_r, 2);
            }
        }

        /// <summary>
        /// Perimeter Property
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * _r;
            }
        }

        /// <summary>
        /// Radius Property
        /// </summary>
        public double R { get => _r; set => _r = value; }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return string.Format($"Figure: {GetType().Name}\n" + $"R: {R}\n" + $"Area: {Area}\n" + $"Perimeter: {Perimeter}");
        }
    }

    /// <summary>
    /// Circle from a paper. Child of the Circle and IPaper
    /// </summary>
    public class PaperCircle:Circle, IPaper
    {
        /// <summary>
        /// PaperCircle constructor
        /// </summary>
        /// <param name="_r"></param>
        /// <param name="color"></param>
        public PaperCircle(double _r, Color color): base(_r)
        {
            Color = color;
            IsColoredAgain = false;
        }

        /// <summary>
        /// PaperCircle constructor from another Figure
        /// </summary>
        /// <param name="_r"></param>
        /// <param name="figure"></param>
        public PaperCircle(double _r, Figure figure) : base(_r)
        {
            if(figure is IPaper)
            {
                if((figure.Area < (Math.PI * Math.Pow(_r, 2))))
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

        /// <summary>
        /// Color Property
        /// </summary>
        public Color Color { get; set; }

        /// <summary>
        /// Colored State Property
        /// </summary>
        public bool IsColoredAgain { get; set; }

        /// <summary>
        /// Paints Figure to the another color for a once
        /// </summary>
        /// <param name="newColor"></param>
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

        /// <summary>
        /// Finds equal Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true - if it was found, if not - false</returns>
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

        /// <summary>
        /// Calculates Hashcode
        /// </summary>
        /// <returns>Hashcode</returns>
        public override int GetHashCode()
        {
            return R.GetHashCode() ^ Color.GetHashCode();
        }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return base.ToString() + string.Format($"Meterial: Paper\n" + $"Color: {Color}\n" + $"Was painted twice:{IsColoredAgain}");
        }
    }

    /// <summary>
    /// Circle from a Film. Child of the Circle and IFilm
    /// </summary>
    public class FilmCircle:Circle, IFilm
    {
        /// <summary>
        /// FilmCircle constructor
        /// </summary>
        /// <param name="_r"></param>
        public FilmCircle(double _r): base(_r)
        {
        }

        /// <summary>
        /// FilmCircle constructor from another figure
        /// </summary>
        /// <param name="_r"></param>
        /// <param name="figure"></param>
        public FilmCircle(double _r, Figure figure) : base(_r)
        {
            if (figure is IFilm)
            {
                if ((figure.Area < (Math.PI * Math.Pow(_r, 2))))
                {
                    throw new Exception("Cannot create a bigger Figure from a smaller Figure");
                }
            }
            else
            {
                throw new Exception("Cannot create a Film form a Paper");
            }
        }

        /// <summary>
        /// Find equal Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true - if it was found, if not - false</returns>
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

        /// <summary>
        /// Calculates Hashcode
        /// </summary>
        /// <returns>Hashcode</returns>
        public override int GetHashCode()
        {
            return R.GetHashCode();
        }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return base.ToString() + string.Format($"Meterial: Film\n");
        }
    }
}
