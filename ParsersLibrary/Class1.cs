using epam_task_3._1;
using System;
using System.Xml;

namespace ParsersLibrary
{
    public class Parser
    {
        public PaperCircle ParseAsPaperCircle(XmlTextReader reader)
        {
            double r = 0;
            Color color = Color.none;

            while (reader.Read())
            {
                switch (reader.Name)
                {
                    case "R":
                        r = double.Parse(reader.ReadString());
                        break;
                    case "Color":
                        Enum.TryParse(reader.Name, out color);
                        break;
                }
            }

            return new PaperCircle(r, color);
        }
    }
}
