using Figures;
using System;
using System.Xml;

namespace ParsersLibrary
{
    /// <summary>
    /// Class for a parsing data with a XMLTextReader orXMLTextWriter
    /// </summary>
    public class XMLTextReaderDataParser
    {
        /// <summary>
        /// Parses data as a PaperCircle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new PaperCircle</returns>
        public PaperCircle ParseAsPaperCircle(XmlTextReader reader)
        {
            double r = 0;
            Color color = Color.none;
            int step = 0;

            while (step != 2)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "R":
                        r = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "Color":
                        color = (Color)Enum.Parse(typeof(Color), reader.ReadString());
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
        public PaperRectangle ParseAsPaperRectangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            Color color = Color.none;
            int step = 0;

            while (step != 5)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "D":
                        D = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "Color":
                        color = (Color)Enum.Parse(typeof(Color), reader.ReadString());
                        step++;
                        break;
                }
            }

            return new PaperRectangle(A, B, C , D, color);
        }

        /// <summary>
        /// Parses data as a PaperTriangle
        /// </summary>
        /// <param name="reader"></param>
        /// <returns>new PaperTriangle</returns>
        public PaperTriangle ParseAsPaperTriangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            Color color = Color.none;
            int step = 0;

            while (step != 4)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "Color":
                        color = (Color)Enum.Parse(typeof(Color), reader.ReadString());
                        step++;
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
        public FilmCircle ParseAsFilmCircle(XmlTextReader reader)
        {
            double r = 0;
            int step = 0;

            while (step != 1)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "R":
                        r = double.Parse(reader.ReadString());
                        step++;
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
        public FilmRectangle ParseAsFilmRectangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            double D = 0;
            int step = 0;

            while (step != 4)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "D":
                        D = double.Parse(reader.ReadString());
                        step++;
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
        public FilmTriangle ParseAsFilmTriangle(XmlTextReader reader)
        {
            double A = 0;
            double B = 0;
            double C = 0;
            int step = 0;

            while (step != 3)
            {
                reader.Read();

                switch (reader.Name)
                {
                    case "A":
                        A = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "B":
                        B = double.Parse(reader.ReadString());
                        step++;
                        break;
                    case "C":
                        C = double.Parse(reader.ReadString());
                        step++;
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

        /// <summary>
        /// Parses Object as a Xml Element
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="paperCircle"></param>
        public void ParsePaperRectangleAsXmlNode(XmlTextWriter writer, PaperRectangle paperRectangle)
        {
            try
            {
                writer.WriteStartElement(nameof(PaperRectangle));
                writer.WriteElementString(nameof(PaperRectangle.A), paperRectangle.A.ToString());
                writer.WriteElementString(nameof(PaperRectangle.B), paperRectangle.B.ToString());
                writer.WriteElementString(nameof(PaperRectangle.C), paperRectangle.C.ToString());
                writer.WriteElementString(nameof(PaperRectangle.D), paperRectangle.D.ToString());
                writer.WriteElementString(nameof(PaperCircle.Color), paperRectangle.Color.ToString());
                writer.WriteEndElement();

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
        public void ParsePaperTriangleAsXmlNode(XmlTextWriter writer, PaperTriangle paperTriangle)
        {
            try
            {
                writer.WriteStartElement(nameof(PaperTriangle));
                writer.WriteElementString(nameof(PaperTriangle.A), paperTriangle.A.ToString());
                writer.WriteElementString(nameof(PaperTriangle.B), paperTriangle.B.ToString());
                writer.WriteElementString(nameof(PaperTriangle.C), paperTriangle.C.ToString());
                writer.WriteElementString(nameof(PaperTriangle.Color), paperTriangle.Color.ToString());
                writer.WriteEndElement();
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
        public void ParseFilmCircleAsXmlNode(XmlTextWriter writer, FilmCircle filmCircle)
        {
            try
            {
                writer.WriteStartElement(nameof(FilmCircle));
                writer.WriteElementString(nameof(FilmCircle.R), filmCircle.R.ToString());
                writer.WriteEndElement();
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
        public void ParseFilmRectangleAsXmlNode(XmlTextWriter writer, FilmRectangle filmRectangle)
        {
            try
            {
                writer.WriteStartElement(nameof(FilmRectangle));
                writer.WriteElementString(nameof(FilmRectangle.A), filmRectangle.A.ToString());
                writer.WriteElementString(nameof(FilmRectangle.B), filmRectangle.B.ToString());
                writer.WriteElementString(nameof(FilmRectangle.C), filmRectangle.C.ToString());
                writer.WriteElementString(nameof(FilmRectangle.D), filmRectangle.D.ToString());
                writer.WriteEndElement();

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
        public void ParseFilmTriangleAsXmlNode(XmlTextWriter writer, FilmTriangle filmTriangle)
        {
            try
            {
                writer.WriteStartElement(nameof(FilmTriangle));
                writer.WriteElementString(nameof(FilmTriangle.A), filmTriangle.A.ToString());
                writer.WriteElementString(nameof(FilmTriangle.B), filmTriangle.B.ToString());
                writer.WriteElementString(nameof(FilmTriangle.C), filmTriangle.C.ToString());
                writer.WriteEndElement();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
