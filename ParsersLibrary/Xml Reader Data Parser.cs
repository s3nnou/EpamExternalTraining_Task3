using Figures;
using System;
using System.Xml;

namespace ParsersLibrary
{
    public class XMLTextReaderDataParser
    {
        public PaperCircle ParseAsPaperCircle(XmlTextReader reader)
        {
            double r = 0;
            Color color = Color.none;
            int stop = 0;

            while (stop != 2)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "R":
                        r = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "Color":
                        color = (Color)Enum.Parse(typeof(Color), reader.ReadString());
                        stop++;
                        break;
                }
            }

            return new PaperCircle(r, color);
        }

        public PaperRectangle ParseAsPaperRectangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            Color color = Color.none;
            int stop = 0;

            while (stop != 5)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "D":
                        D = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "Color":
                        color = (Color)Enum.Parse(typeof(Color), reader.ReadString());
                        stop++;
                        break;
                }
            }

            return new PaperRectangle(A, B, C , D, color);
        }

        public PaperTriangle ParseAsPaperTriangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            Color color = Color.none;
            int stop = 0;

            while (stop != 4)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "Color":
                        color = (Color)Enum.Parse(typeof(Color), reader.ReadString());
                        stop++;
                        break;
                }
            }

            return new PaperTriangle(A, B, C, color);
        }

        public FilmCircle ParseAsFilmCircle(XmlTextReader reader)
        {
            double r = 0;
            int stop = 0;

            while (stop != 1)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "R":
                        r = double.Parse(reader.ReadString());
                        stop++;
                        break;
                }
            }

            return new FilmCircle(r);
        }

        public FilmRectangle ParseAsFilmRectangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            int stop = 0;

            while (stop != 4)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "D":
                        D = double.Parse(reader.ReadString());
                        stop++;
                        break;
                        break;
                }
            }

            return new FilmRectangle(A, B, C, D);
        }

        public FilmTriangle ParseAsFilmTriangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            int stop = 0;

            while (stop != 3)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        stop++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        stop++;
                        break;
                }
            }

            return new FilmTriangle(A, B, C);
        }

        public void ParsePaperCircleAsXmlNode(XmlTextWriter writer, PaperCircle paperCircle)
        {
            try
            {
                writer.WriteStartElement(nameof(PaperCircle));
                writer.WriteElementString(nameof(PaperCircle.R), paperCircle.R.ToString());
                writer.WriteElementString(nameof(PaperCircle.Color), paperCircle.Color.ToString());
                writer.WriteEndElement();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public void ParsePaperRectangleAsXmlNode(XmlTextWriter writer, PaperRectangle paperRectangle)
        //{
        //    try
        //    {
        //        writer.WriteLine("\t<PaperRectangle>");
        //        writer.WriteLine("\t\t<A>{0}</A>", paperRectangle.A);
        //        writer.WriteLine("\t\t<B>{0}</B>", paperRectangle.B);
        //        writer.WriteLine("\t\t<C>{0}</C>", paperRectangle.C);
        //        writer.WriteLine("\t\t<D>{0}</D>", paperRectangle.D);
        //        writer.WriteLine("\t\t<Color>{0}</Color>", paperRectangle.Color);
        //        writer.WriteLine("\t</PaperRectangle>");

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void ParsePaperTriangleAsXmlNode(XmlTextWriter writer, PaperTriangle paperTriangle)
        //{
        //    try
        //    {
        //        writer.WriteLine("\t<PaperTriangle>");
        //        writer.WriteLine("\t\t<A>{0}</A>", paperTriangle.A);
        //        writer.WriteLine("\t\t<B>{0}</B>", paperTriangle.B);
        //        writer.WriteLine("\t\t<C>{0}</C>", paperTriangle.C);
        //        writer.WriteLine("\t\t<Color>{0}</Color>", paperTriangle.Color);
        //        writer.WriteLine("\t</PaperTriangle>");

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void ParseFilmCircleAsXmlNode(XmlTextWriter writer, FilmCircle filmCircle)
        //{
        //    try
        //    {
        //        writer.WriteLine("\t<FilmCircle>");
        //        writer.WriteLine("\t\t<R>{0}</R>", filmCircle.R);
        //        writer.WriteLine("\t</FilmCircle>");

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void ParseFilmRectangleAsXmlNode(XmlTextWriter writer, FilmRectangle filmRectangle)
        //{
        //    try
        //    {
        //        writer.WriteLine("\t<FilmRectangle>");
        //        writer.WriteLine("\t\t<A>{0}</A>", filmRectangle.A);
        //        writer.WriteLine("\t\t<B>{0}</B>", filmRectangle.B);
        //        writer.WriteLine("\t\t<C>{0}</C>", filmRectangle.C);
        //        writer.WriteLine("\t\t<D>{0}</D>", filmRectangle.D);
        //        writer.WriteLine("\t</FilmRectangle>");

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        //public void ParseFilmTriangleAsXmlNode(XmlTextWriter writer, FilmTriangle filmTriangle)
        //{
        //    try
        //    {
        //        writer.WriteLine("\t<FilmTriangle>");
        //        writer.WriteLine("\t\t<A>{0}</A>", filmTriangle.A);
        //        writer.WriteLine("\t\t<B>{0}</B>", filmTriangle.B);
        //        writer.WriteLine("\t\t<C>{0}</C>", filmTriangle.C);
        //        writer.WriteLine("\t</FilmTriangle>");

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
