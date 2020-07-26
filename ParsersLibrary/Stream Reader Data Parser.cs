using epam_task_3._1;
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
    }
}
