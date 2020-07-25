using CollectionLibrary;
using epam_task_3._1;
using ParsersLibrary;
using System;
using System.Xml;

namespace FileExtensionsLibrary
{
    public class FileExtensions
    {
        public Box ReadXML(string path)
        {
            using (XmlTextReader reader = new XmlTextReader(path))
            {
                int i = 0;
                Box box = new Box();

                FiguresTypes type;
                Parser parser = new Parser();

                while (reader.Read())
                {
                    if(Enum.TryParse(reader.Name, out type))
                    {
                        switch (type)
                        {
                            case FiguresTypes.PaperCircle:

                                box[i] = parser.ParseAsPaperCircle(reader);
                                i++;
                                break;
                            case FiguresTypes.PaperTriangle:
                                i++;
                                break;
                            case FiguresTypes.PaperRectangle:
                                i++;
                                break;
                            case FiguresTypes.FilmCircle:
                                i++;
                                break;
                            case FiguresTypes.FilmTriangle:
                                i++;
                                break;
                            case FiguresTypes.FilmRectangle:
                                i++;

                                break;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        public void ReadXML(string path, Material material)
        {

        }
    }
}
