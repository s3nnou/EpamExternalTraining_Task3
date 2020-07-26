using MaterialsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Base class for a Rectangle
    /// </summary>
    public class Rectangle: Figure
    {
        /// <summary>
        /// Rectangle constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public Rectangle(double a, double b, double c, double d)
        {
            if(a > 0 && b > 0 && c > 0 && d > 0)
            {
                if (a + b + c > d && b + c + d > a && c + d + a > b && a + b + d > c)
                {
                    A = a;
                    B = b;
                    C = c;
                    D = d;
                }
                else
                {
                    throw new Exception("Such Rectangle cannot exist");
                }
            }
            else
            {
                throw new Exception("Negative sides cannot exist");
            }
        }

        /// <summary>
        /// A side Property
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// B side Property
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// C side Property
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// D side Property
        /// </summary>
        public double D { get; set; }

        /// <summary>
        /// Area Property
        /// </summary>
        public override double Area
        {
            get
            {
                return A * B;
            }
        }

        /// <summary>
        /// Perimeter Property
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return (A + B) * 2;

            }
        }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return string.Format($"Figure: {GetType().Name}\n" + $"A: {A}\n" + $"B: {B}\n" + $"C: {C}\n" + $"D: {D}\n" + $"Area: {Area}\n" + $"Perimeter: {Perimeter}");
        }
    }

    /// <summary>
    /// Rectangle from a paper. Child of the Circle and IPaper
    /// </summary>
    public class PaperRectangle:Rectangle, IPaper
    {
        /// <summary>
        /// PaperRectangle Construtor
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="color"></param>
        public PaperRectangle(double A, double B, double C, double D, Color color) : base(A, B, C, D)
        {
            Color = color;
            IsColoredAgain = false;
        }

        /// <summary>
        /// PaperRectangle Construtor from another Figure
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="figure"></param>
        public PaperRectangle(double A, double B, double C, double D, Figure figure) : base(A, B, C, D)
        {
            if (figure is IPaper)
            {
                if ((figure.Area < (A * B)))
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
            if (obj is PaperRectangle)
            {
               PaperRectangle paperRectangle = obj as PaperRectangle;

                if (this.A == paperRectangle.A && this.B == paperRectangle.B && this.C == paperRectangle.C && this.D == paperRectangle.D && this.Color == paperRectangle.Color)
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
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode() ^ Color.GetHashCode();
        }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return base.ToString() + string.Format($"Meterial: Paper\n" + $"Color: {Color}\n" + $"Was painted twice: {IsColoredAgain}"); 
        }
    }

    /// <summary>
    /// Rectangle from a Film. Child of the Rectangle and IFilm
    /// </summary>
    public class FilmRectangle : Rectangle, IFilm
    {
        /// <summary>
        /// FilmRectangle constructor
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        public FilmRectangle(double A, double B, double C, double D) : base(A, B, C, D)
        {

        }

        /// <summary>
        /// FilmRectangle constructor from another figure
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="figure"></param>
        public FilmRectangle(double A, double B, double C, double D, Figure figure) : base(A, B, C, D)
        {
            if (figure is IFilm)
            {
                if ((figure.Area < (A * B)))
                {
                    throw new Exception("Cannot create a bigger Figure from a smaller Figure");
                }
            }
            else
            {
                throw new Exception("Cannot create a Paper form a Film");
            }
        }

        /// <summary>
        /// Find equal Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true - if it was found, if not - false</returns>
        public override bool Equals(object obj)
        {
            if (obj is FilmRectangle)
            {
                FilmRectangle filmTriangle = obj as FilmRectangle;

                if (this.A == filmTriangle.A && this.B == filmTriangle.B && this.C == filmTriangle.C)
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
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode();
        }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return base.ToString() + string.Format($"Meterial: Film");
        }
    }
}
