using MaterialsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
    public class Rectangle: Figure
    {
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

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public override double Area
        {
            get
            {
                return A * B;
            }
        }

        public override double Perimeter
        {
            get
            {
                return (A + B) * 2;

            }
        }
    }

    public class PaperRectangle:Rectangle, IPaper
    {
        public PaperRectangle(double A, double B, double C, double D, Color color) : base(A, B, C, D)
        {
            Color = color;
            IsColoredAgain = false;
        }

        public PaperRectangle(double A, double B, double C, double D, Figure figure) : base(A, B, C, D)
        {
            if (figure is IPaper)
            {
                if (!(figure.Area < (A * B)))
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

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode() ^ Color.GetHashCode();
        }
    }

    public class FilmRectangle : Rectangle, IFilm
    {
        public FilmRectangle(double A, double B, double C, double D) : base(A, B, C, D)
        {

        }

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

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ D.GetHashCode();
        }

    }
}
