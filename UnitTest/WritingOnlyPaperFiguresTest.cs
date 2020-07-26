using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionLibrary;
using Figures;
using FileExtensionsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class WritingOnlyPaperFiguresTest
    {
        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewPaperBox1.xml";

            FileWriter writer = new FileWriter();
            Material material = Material.paper;
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);
            t_box[5] = new FilmTriangle(1, 1, 1);

            writer.WriteFiguresByStreamWriter(t_box, material, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            Box ex_box = new Box();
            ex_box[0] = new PaperCircle(5, Color.red);
            ex_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            ex_box[2] = new PaperTriangle(1, 1, 1, Color.red);

            CollectionAssert.AreEqual(ex_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewPaperBox2.xml";

            FileWriter writer = new FileWriter();
            Material material = Material.paper;
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);
            t_box[5] = new FilmTriangle(1, 1, 1);

            writer.WriteFiguresByStreamWriter(t_box, material, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            Box ex_box = new Box();
            ex_box[0] = new PaperCircle(5, Color.red);
            ex_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            ex_box[2] = new PaperTriangle(1, 1, 1, Color.red);

            CollectionAssert.AreEqual(ex_box.Items, r_box.Items);
        }
    }
}
