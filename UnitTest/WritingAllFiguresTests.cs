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
    public class WritingAllFiguresTests
    {
        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest1()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox1.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest2()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox2.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest3()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox3.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
           

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest4()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox4.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
           

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest5()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox5.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1); 

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByStreamReaderTest6()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox6.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);
            t_box[5] = new FilmTriangle(1, 1, 1);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest1()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox1.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest2()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox2.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest3()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox3.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);


            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest4()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox4.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);


            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest5()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox5.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByStreamWriterAndReadingByXmlTextReaderTest6()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox6.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);
            t_box[5] = new FilmTriangle(1, 1, 1);

            writer.WriteFiguresByStreamWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByXmlTextReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }

        [TestMethod]
        public void WritingByXmlTextWriterAndReadingByStreamReaderTest1()
        {
            string path = @"..\..\..\..\epam_task_3.1\Res\NewBox11.xml";

            FileWriter writer = new FileWriter();

            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            writer.WriteFiguresByXmlTextWriter(t_box, path);

            FileReader reader = new FileReader();
            Box r_box = reader.ReadXmlByStreamReader(path);

            CollectionAssert.AreEqual(t_box.Items, r_box.Items);
        }
    }
}
