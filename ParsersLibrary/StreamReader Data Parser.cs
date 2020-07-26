using Figures;
using System;
using System.IO;

namespace ParsersLibrary
{
    /// <summary>
    /// Class for a parsing data with a StreamWriter or StreamReader
    /// </summary>
    public class StreamReaderDataParser
    {
        /// <summary>
        /// Parses data as a PaperCircle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new PaperCircle</returns>
        public PaperCircle ParseAsPaperCircle(StreamReader reader)
        {
            int step = 0;
            string[] info;
            double r = 0;
            Color color = Color.none;
            string line = reader.ReadLine();

            while (step != 2)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (step)
                {
                    case 0:
                        r = double.Parse(info[2].Trim());
                        step++;
                        line = reader.ReadLine();
                        break;
                    case 1:
                        color = (Color)Enum.Parse(typeof(Color), info[2]);
                        step++;
                        break;
                }
            }
            return new PaperCircle(r, color);
        }

        /// <summary>
        /// Parses data as a PaperRectangle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new PaperRectangle</returns>
        public PaperRectangle ParseAsPaperRectangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            Color color = Color.none;
            int step = 0;
            string[] info;

            string line = reader.ReadLine();
            while (step != 5)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (step)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        step++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 3:
                        D = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 4:
                        color = (Color)Enum.Parse(typeof(Color), info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                }
            }

            return new PaperRectangle(A, B, C, D, color);
        }

        /// <summary>
        /// Parses data as a PaperTriangle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new PaperTriangle</returns>
        public PaperTriangle ParseAsPaperTriangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            Color color = Color.none;
            int step = 0;
            string[] info;

            string line = reader.ReadLine();
            while (step != 4)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (step)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        step++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 3:
                        color = (Color)Enum.Parse(typeof(Color), info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                }
            }

            return new PaperTriangle(A, B, C, color);
        }

        /// <summary>
        /// Parses data as a FilmCircle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new FilmCircle</returns>
        public FilmCircle ParseAsFilmCircle(StreamReader reader)
        {
            int step = 0;
            string[] info;
            double r = 0;
            string line = reader.ReadLine();

            while (step != 1)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (step)
                {
                    case 0:
                        r = double.Parse(info[2].Trim());
                        step++;
                        line = reader.ReadLine();
                        break;
                }
            }
            return new FilmCircle(r);
        }

        /// <summary>
        /// Parses data as a FilmRectangle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new FilmRectangle</returns>
        public FilmRectangle ParseAsFilmRectangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            int step = 0;
            string[] info;

            string line = reader.ReadLine();
            while (step != 4)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (step)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        step++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 3:
                        D = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                   
                }
            }

            return new FilmRectangle(A, B, C, D);
        }

        /// <summary>
        /// Parses data as a FilmTriangle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new FilmTriangle</returns>
        public FilmTriangle ParseAsFilmTriangle(StreamReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            int step = 0;
            string[] info;

            string line = reader.ReadLine();
            while (step != 3)
            {
                line = line.TrimStart();
                info = line.Split('>', '<');

                switch (step)
                {
                    case 0:
                        A = double.Parse(info[2].Trim());
                        step++;
                        line = reader.ReadLine();

                        break;
                    case 1:
                        B = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                    case 2:
                        C = double.Parse(info[2].Trim());
                        step++;

                        line = reader.ReadLine();
                        break;
                }
            }

            return new FilmTriangle(A, B, C);
        }

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
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

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
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

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
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

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
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

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
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

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
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
