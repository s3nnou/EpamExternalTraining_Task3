using MaterialsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace epam_task_3._1
{
    public class Triangle:Figure
    {
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; set ; }
        public double B { get; set; }
        public double C { get; set; }

        public override double Area
        {
            get
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public override double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }
    }

    public class PaperTriangle: Triangle, IPaper
    {
        private Color _color;

        public PaperTriangle(double A, double B, double C, Color color) : base(A, B, C)
        {
            _color = color;
            IsColoredAgain = false;
        }

        public PaperTriangle(double A, double B, double C, Figure figure) : base(A, B, C)
        {
            if (figure is IPaper)
            {
                if (!(figure.Area < (Math.Sqrt(((A + B + C) / 2) * (((A + B + C) / 2) - A) * (((A + B + C) / 2) - B) * (((A + B + C) / 2) - C)))))
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

        public Color Color { get => _color; set => _color = value; }

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

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode() ^ Color.GetHashCode();
        }
    }

    public class FilmTriangle : Triangle, IFilm
    {
        public FilmTriangle(double A, double B, double C) : base(A, B, C)
        {

        }

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

        public override int GetHashCode()
        {
            return A.GetHashCode() ^ B.GetHashCode() ^ C.GetHashCode();
        }

    }
}
