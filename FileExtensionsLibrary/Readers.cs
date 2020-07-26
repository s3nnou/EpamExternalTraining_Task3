using CollectionLibrary;
using Figures;
using ParsersLibrary;
using System;
using System.IO;
using System.Xml;

namespace FileExtensionsLibrary
{
    /// <summary>
    /// Class for a work with a reading xml files 
    /// </summary>
    public class FileReader
    {
        /// <summary>
        /// Reads Xml file by XmlTextReader
        /// </summary>
        /// <param name="path"></param>
        /// <returns>new Box</returns>
        public Box ReadXmlByXmlTextReader(string path)
        {
            using (XmlTextReader reader = new XmlTextReader(path))
            {
                reader.MoveToContent();
                int i = 0;
                Box box = new Box();
                bool hasMore = reader.Read();
                FiguresTypes type;
                XMLTextReaderDataParser parser = new XMLTextReaderDataParser();
                while (hasMore)
                {
                    if (reader.NodeType == XmlNodeType.Element && Enum.TryParse(reader.Name, out type))
                    {
                        switch (type)
                        {
                            case FiguresTypes.PaperCircle:
                                box[i] = parser.ParseAsPaperCircle(reader);
                                i++;
                                break;
                            case FiguresTypes.PaperRectangle:
                                box[i] = parser.ParseAsPaperRectangle(reader);
                                i++;
                                break;
                            case FiguresTypes.PaperTriangle:
                                box[i] = parser.ParseAsPaperTriangle(reader);
                                i++;
                                break;
                            case FiguresTypes.FilmCircle:
                                box[i] = parser.ParseAsFilmCircle(reader);
                                i++;
                                break;
                            case FiguresTypes.FilmRectangle:
                                box[i] = parser.ParseAsFilmRectangle(reader);
                                i++;
                                break;
                            case FiguresTypes.FilmTriangle:
                                box[i] = parser.ParseAsFilmTriangle(reader);
                                i++;
                                break;
                        }
                    }
                    else hasMore = reader.Read();
                }

                return box;
            }
        }

        /// <summary>
        /// Reads Xml file by StreamReader
        /// </summary>
        /// <param name="path"></param>
        /// <returns>new Box</returns>
        public Box ReadXmlByStreamReader(string path)
        {
            string line;
            int i = 0;
            FiguresTypes type;
            Box box = new Box();

            using (StreamReader reader = new StreamReader(path))
            {

                StreamReaderDataParser parser = new  StreamReaderDataParser();
                while ((line = reader.ReadLine()) != null)
                {
                    string header = line.Trim('<', '>', '\t', ' ');
                    string[] info = line.Split();

                    if (Enum.TryParse(header, out type))
                    {
                        switch (type)
                        {
                            case FiguresTypes.PaperCircle:
                                box[i] = parser.ParseAsPaperCircle(reader);
                                i++;
                                break;
                            case FiguresTypes.PaperRectangle:
                                box[i] = parser.ParseAsPaperRectangle(reader);
                                i++;
                                break;
                            case FiguresTypes.PaperTriangle:
                                box[i] = parser.ParseAsPaperTriangle(reader);
                                i++;
                                break;

                            case FiguresTypes.FilmCircle:
                                box[i] = parser.ParseAsFilmCircle(reader);
                                i++;
                                break;
                            case FiguresTypes.FilmRectangle:
                                box[i] = parser.ParseAsFilmRectangle(reader);
                                i++;
                                break;
                            case FiguresTypes.FilmTriangle:
                                box[i] = parser.ParseAsFilmTriangle(reader);
                                i++;
                                break;
                        }
                    }
                }
            }
                return box;
        }
    }
}
