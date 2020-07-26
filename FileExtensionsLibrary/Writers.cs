using CollectionLibrary;
using Figures;
using MaterialsLibrary;
using ParsersLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace FileExtensionsLibrary
{
    public class FileWriter
    {
        public void WriteFiguresByStreamWriter(Box box, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                writer.WriteLine("<Figures>");

                StreamReaderDataParser parser = new StreamReaderDataParser();

                FiguresTypes type;

                for (int i = 0; i < box.Size; i++)
                {
                    if(box[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (Enum.TryParse(box[i].GetType().Name.ToString(), out type))
                        {
                            switch (type)
                            {
                                case FiguresTypes.PaperCircle:
                                    parser.ParsePaperCircleAsXmlNode(writer, (PaperCircle)box[i]);
                                    break;
                                case FiguresTypes.PaperRectangle:
                                    parser.ParsePaperRectangleAsXmlNode(writer, (PaperRectangle)box[i]);
                                    break;
                                case FiguresTypes.PaperTriangle:
                                    parser.ParsePaperTriangleAsXmlNode(writer, (PaperTriangle)box[i]);
                                    break;
                                case FiguresTypes.FilmCircle:
                                    parser.ParseFilmCircleAsXmlNode(writer, (FilmCircle)box[i]);
                                    break;
                                case FiguresTypes.FilmRectangle:
                                    parser.ParseFilmRectangleAsXmlNode(writer, (FilmRectangle)box[i]);
                                    break;
                                case FiguresTypes.FilmTriangle:
                                    parser.ParseFilmTriangleAsXmlNode(writer, (FilmTriangle)box[i]);
                                    break;
                            }
                        }
                    }
                }

                writer.WriteLine("</Figures>");
            }

        }

        public void WriteFiguresByStreamWriter(Box box, Material material, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                writer.WriteLine("<Figures>");

                StreamReaderDataParser parser = new StreamReaderDataParser();

                FiguresTypes type;

                for (int i = 0; i < box.Size; i++)
                {
                    if (box[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        switch (material)
                        {
                            case Material.film:
                                if (box[i] is IFilm)
                                {
                                    if (Enum.TryParse(box[i].GetType().Name.ToString(), out type))
                                    {
                                        switch (type)
                                        {
                                            case FiguresTypes.FilmCircle:
                                                parser.ParseFilmCircleAsXmlNode(writer, (FilmCircle)box[i]);
                                                break;
                                            case FiguresTypes.FilmRectangle:
                                                parser.ParseFilmRectangleAsXmlNode(writer, (FilmRectangle)box[i]);
                                                break;
                                            case FiguresTypes.FilmTriangle:
                                                parser.ParseFilmTriangleAsXmlNode(writer, (FilmTriangle)box[i]);
                                                break;
                                        }
                                    }
                                }
                                break;
                            case Material.paper:
                                if (box[i] is IPaper)
                                {
                                    if (Enum.TryParse(box[i].GetType().Name.ToString(), out type))
                                    {
                                        switch (type)
                                        {
                                            case FiguresTypes.PaperCircle:
                                                parser.ParsePaperCircleAsXmlNode(writer, (PaperCircle)box[i]);
                                                break;
                                            case FiguresTypes.PaperRectangle:
                                                parser.ParsePaperRectangleAsXmlNode(writer, (PaperRectangle)box[i]);
                                                break;
                                            case FiguresTypes.PaperTriangle:
                                                parser.ParsePaperTriangleAsXmlNode(writer, (PaperTriangle)box[i]);
                                                break;
                                        }
                                    }
                                }
                                break;
                        }
                    }
                }

                writer.WriteLine("</Figures>");
            }

        }

        public void WriteFiguresByXmlTextWriter(Box box, string path)
        {
            using(XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Figures");

                FiguresTypes type;

                XMLTextReaderDataParser parser = new XMLTextReaderDataParser();

                for (int i = 0; i < box.Size; i++)
                {
                    if (box[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (Enum.TryParse(box[i].GetType().Name.ToString(), out type))
                        {
                            switch (type)
                            {
                                case FiguresTypes.PaperCircle:
                                    parser.ParsePaperCircleAsXmlNode(writer, (PaperCircle)box[i]);
                                    break;
                                case FiguresTypes.PaperRectangle:
                                    parser.ParsePaperRectangleAsXmlNode(writer, (PaperRectangle)box[i]);
                                    break;
                                case FiguresTypes.PaperTriangle:
                                    parser.ParsePaperTriangleAsXmlNode(writer, (PaperTriangle)box[i]);
                                    break;
                                case FiguresTypes.FilmCircle:
                                    parser.ParseFilmCircleAsXmlNode(writer, (FilmCircle)box[i]);
                                    break;
                                case FiguresTypes.FilmRectangle:
                                    parser.ParseFilmRectangleAsXmlNode(writer, (FilmRectangle)box[i]);
                                    break;
                                case FiguresTypes.FilmTriangle:
                                    parser.ParseFilmTriangleAsXmlNode(writer, (FilmTriangle)box[i]);
                                    break;
                            }
                        }
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }

        public void WriteFiguresByXmlTextWriter(Box box, Material material, string path)
        {
            using (XmlTextWriter writer = new XmlTextWriter(path, System.Text.Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("Figures");

                FiguresTypes type;

                XMLTextReaderDataParser parser = new XMLTextReaderDataParser();

                for (int i = 0; i < box.Size; i++)
                {
                    if (box[i] == null)
                    {
                        continue;
                    }
                    else
                    {
                        switch (material)
                        {
                            case Material.film:
                                if (box[i] is IFilm)
                                {
                                    if (Enum.TryParse(box[i].GetType().Name.ToString(), out type))
                                    {
                                        switch (type)
                                        {
                                            case FiguresTypes.FilmCircle:
                                                parser.ParseFilmCircleAsXmlNode(writer, (FilmCircle)box[i]);
                                                break;
                                            case FiguresTypes.FilmRectangle:
                                                parser.ParseFilmRectangleAsXmlNode(writer, (FilmRectangle)box[i]);
                                                break;
                                            case FiguresTypes.FilmTriangle:
                                                parser.ParseFilmTriangleAsXmlNode(writer, (FilmTriangle)box[i]);
                                                break;
                                        }
                                    }
                                }
                                    break;
                            case Material.paper:
                                if (box[i] is IPaper)
                                {
                                    if (Enum.TryParse(box[i].GetType().Name.ToString(), out type))
                                    {
                                        switch (type)
                                        {
                                            case FiguresTypes.PaperCircle:
                                                parser.ParsePaperCircleAsXmlNode(writer, (PaperCircle)box[i]);
                                                break;
                                            case FiguresTypes.PaperRectangle:
                                                parser.ParsePaperRectangleAsXmlNode(writer, (PaperRectangle)box[i]);
                                                break;
                                            case FiguresTypes.PaperTriangle:
                                                parser.ParsePaperTriangleAsXmlNode(writer, (PaperTriangle)box[i]);
                                                break;
                                        }
                                    }
                                }
                                break;
                        }
                        
                    }
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
        }
    }
}
