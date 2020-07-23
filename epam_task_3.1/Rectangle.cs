using MaterialsLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace epam_task_3._1
{
    public class Rectangle: Figure
    {
        public Rectangle(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
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
        private Color _color;

        public PaperRectangle(double A, double B, double C, double D, Color color) : base(A, B, C, D)
        {
            _color = color;
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
