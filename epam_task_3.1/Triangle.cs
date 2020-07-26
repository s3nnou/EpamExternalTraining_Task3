using MaterialsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    /// <summary>
    /// Base class for a Triangle
    /// </summary>
    public class Triangle:Figure
    {
        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if(a + b > c && b + c > a && c + a > b)
                {
                    A = a;
                    B = b;
                    C = c;
                }
                else
                {
                    throw new Exception("Such Triangle cannot exist");
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
        public double A { get; set ; }

        /// <summary>
        /// B side Property
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// C side Property
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Area Property
        /// </summary>
        public override double Area
        {
            get
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        /// <summary>
        /// Perimeter Property
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }

        /// <summary>
        /// Displays an information about a Figure
        /// </summary>
        /// <returns>Information</returns>
        public override string ToString()
        {
            return string.Format($"Figure: {GetType().Name}\n" + $"A: {A}\n" + $"B: {B}\n" + $"C: {C}\n"  + $"Area: {Area}\n" + $"Perimeter: {Perimeter}");
        }
    }

    /// <summary>
    /// Triangle from a paper. Child of the Triangle and IPaper
    /// </summary>
    public class PaperTriangle: Triangle, IPaper
    {
        /// <summary>
        /// PaperTriangle constructor
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="color"></param>
        public PaperTriangle(double A, double B, double C, Color color) : base(A, B, C)
        {
            Color = color;
            IsColoredAgain = false;
        }

        /// <summary>
        /// PaperTriangle Construtor from another Figure
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="figure"></param>
        public PaperTriangle(double A, double B, double C, Figure figure) : base(A, B, C)
        {
            if (figure is IPaper)
            {
                if ((figure.Area < (Math.Sqrt(((A + B + C) / 2) * (((A + B + C) / 2) - A) * (((A + B + C) / 2) - B) * (((A + B + C) / 2) - C)))))
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
            if (obj is PaperTriangle)
            {
                PaperTriangle paperTriangle = obj as PaperTriangle;

                if (this.A == paperTriangle.A && this.B == paperTriangle.B && this.C == paperTriangle.C &&this.Color == paperTriangle.Color)
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
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ Color.GetHashCode();
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
    /// Triangle from a Film. Child of the Triangle and IFilm
    /// </summary>
    public class FilmTriangle : Triangle, IFilm
    {
        /// <summary>
        /// FilmTriangle constructor
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        public FilmTriangle(double A, double B, double C) : base(A, B, C)
        {

        }

        /// <summary>
        /// FilmTriangle constructor from another figure
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="figure"></param>
        public FilmTriangle(double A, double B, double C, Figure figure) : base(A, B, C)
        {
            if (figure is IFilm)
            {
                if ((figure.Area < (Math.Sqrt(((A + B + C) / 2) * (((A + B + C) / 2) - A) * (((A + B + C) / 2) - B) * (((A + B + C) / 2) - C)))))
                {
                    throw new Exception("Cannot create a bigger Figure from a smaller Figure");
                }
                else
                {

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
            if (obj is FilmTriangle)
            {
                FilmTriangle filmTriangle= obj as FilmTriangle;

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
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode();
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
