using Figures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ParsersLibrary
{
    public class StreamReaderDataParser
    {
        public PaperCircle ParseAsPaperCircle(StreamReader reader)
        {
            int stop = 0;
            string[] info;
            double r = 0;
            Color color = Color.none;
            string line = reader.ReadLine();

            while (stop != 2)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (stop)
                {
                    case 0:
                        r = double.Parse(info[2].Trim());
                        stop++;
                        line = reader.ReadLine();
                        break;
                    case 1:
                        color = (Color)Enum.Parse(typeof(Color), info[2]);
                        stop++;
                        break;
                }
            }
            return new PaperCircle(r, color);
        }

        public PaperRectangle ParseAsPaperRectangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            Color color = Color.none;
            int stop = 0;
            string[] info;

            string line = reader.ReadLine();
            while (stop != 5)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (stop)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        stop++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 3:
                        D = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 4:
                        color = (Color)Enum.Parse(typeof(Color), info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                }
            }

            return new PaperRectangle(A, B, C, D, color);
        }

        public PaperTriangle ParseAsPaperTriangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            Color color = Color.none;
            int stop = 0;
            string[] info;

            string line = reader.ReadLine();
            while (stop != 4)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (stop)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        stop++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 3:
                        color = (Color)Enum.Parse(typeof(Color), info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                }
            }

            return new PaperTriangle(A, B, C, color);
        }

        public FilmCircle ParseAsFilmCircle(StreamReader reader)
        {
            int stop = 0;
            string[] info;
            double r = 0;
            string line = reader.ReadLine();

            while (stop != 1)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (stop)
                {
                    case 0:
                        r = double.Parse(info[2].Trim());
                        stop++;
                        line = reader.ReadLine();
                        break;
                }
            }
            return new FilmCircle(r);
        }

        public FilmRectangle ParseAsFilmRectangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            int stop = 0;
            string[] info;

            string line = reader.ReadLine();
            while (stop != 4)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (stop)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        stop++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 3:
                        D = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                   
                }
            }

            return new FilmRectangle(A, B, C, D);
        }

        public FilmTriangle ParseAsFilmTriangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            int stop = 0;
            string[] info;

            string line = reader.ReadLine();
            while (stop != 3)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (stop)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        stop++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        stop++;

                        line = reader.ReadLine();
                        break;
                }
            }

            return new FilmTriangle(A, B, C);
        }

        public void ParsePaperCircleAsXmlNode(StreamWriter writer, PaperCircle paperCircle)
        {
            try
            {
                writer.WriteLine("\t<PaperCircle>");
                writer.WriteLine("\t\t<R>{0}</R>", paperCircle.R);
                writer.WriteLine("\t\t<Color>{0}</Color>", paperCircle.Color);
                writer.WriteLine("\t</PaperCircle>");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ParsePaperRectangleAsXmlNode(StreamWriter writer, PaperRectangle paperRectangle)
        {
            try
            {
                writer.WriteLine("\t<PaperRectangle>");
                writer.WriteLine("\t\t<A>{0}</A>", paperRectangle.A);
                writer.WriteLine("\t\t<B>{0}</B>", paperRectangle.B);
                writer.WriteLine("\t\t<C>{0}</C>", paperRectangle.C);
                writer.WriteLine("\t\t<D>{0}</D>", paperRectangle.D);
                writer.WriteLine("\t\t<Color>{0}</Color>", paperRectangle.Color);
                writer.WriteLine("\t</PaperRectangle>");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ParsePaperTriangleAsXmlNode(StreamWriter writer, PaperTriangle paperTriangle)
        {
            try
            {
                writer.WriteLine("\t<PaperTriangle>");
                writer.WriteLine("\t\t<A>{0}</A>", paperTriangle.A);
                writer.WriteLine("\t\t<B>{0}</B>", paperTriangle.B);
                writer.WriteLine("\t\t<C>{0}</C>", paperTriangle.C);
                writer.WriteLine("\t\t<Color>{0}</Color>", paperTriangle.Color);
                writer.WriteLine("\t</PaperTriangle>");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ParseFilmCircleAsXmlNode(StreamWriter writer, FilmCircle filmCircle)
        {
            try
            {
                writer.WriteLine("\t<FilmCircle>");
                writer.WriteLine("\t\t<R>{0}</R>", filmCircle.R);
                writer.WriteLine("\t</FilmCircle>");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ParseFilmRectangleAsXmlNode(StreamWriter writer, FilmRectangle filmRectangle)
        {
            try
            {
                writer.WriteLine("\t<FilmRectangle>");
                writer.WriteLine("\t\t<A>{0}</A>", filmRectangle.A);
                writer.WriteLine("\t\t<B>{0}</B>", filmRectangle.B);
                writer.WriteLine("\t\t<C>{0}</C>", filmRectangle.C);
                writer.WriteLine("\t\t<D>{0}</D>", filmRectangle.D);
                writer.WriteLine("\t</FilmRectangle>");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ParseFilmTriangleAsXmlNode(StreamWriter writer, FilmTriangle filmTriangle)
        {
            try
            {
                writer.WriteLine("\t<FilmTriangle>");
                writer.WriteLine("\t\t<A>{0}</A>", filmTriangle.A);
                writer.WriteLine("\t\t<B>{0}</B>", filmTriangle.B);
                writer.WriteLine("\t\t<C>{0}</C>", filmTriangle.C);
                writer.WriteLine("\t</FilmTriangle>");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
