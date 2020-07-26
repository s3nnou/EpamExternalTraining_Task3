using epam_task_3._1;
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
    }
}
