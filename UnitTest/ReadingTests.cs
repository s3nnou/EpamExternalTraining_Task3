using System;
using CollectionLibrary;
using Figures;
using FileExtensionsLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class ReadingTests
    {
        [TestMethod]
        public void Reading1()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);

            Assert.IsTrue(boxToAssure[1].Equals(boxTest[1]));

        }

        [TestMethod]
        public void Reading2()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1,1,1,1, Color.red);

            Assert.IsTrue(boxToAssure[2].Equals(boxTest[2]));

        }
        [TestMethod]
        public void Reading3()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);

            Assert.IsTrue(boxToAssure[3].Equals(boxTest[3]));

        }

        [TestMethod]
        public void Reading4()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);
            boxToAssure[4] = new FilmCircle(5);

            Assert.IsTrue(boxToAssure[4].Equals(boxTest[4]));

        }

        [TestMethod]
        public void Reading5()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);
            boxToAssure[4] = new FilmCircle(5);
            boxToAssure[5] = new FilmRectangle(1, 1, 1, 1);

            Assert.IsTrue(boxToAssure[5].Equals(boxTest[5]));

        }

        [TestMethod]
        public void Reading6()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);
            boxToAssure[4] = new FilmCircle(5);
            boxToAssure[5] = new FilmRectangle(1, 1, 1, 1);
            boxToAssure[6] = new FilmTriangle(1, 1, 1);

            Assert.IsTrue(boxToAssure[6].Equals(boxTest[6]));

        }
        [TestMethod]
        public void Reading7()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByStreamReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);

            Assert.IsTrue(boxToAssure[0].Equals(boxTest[0]));

        }

        [TestMethod]
        public void Reading8()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByStreamReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);

            Assert.IsTrue(boxToAssure[1].Equals(boxTest[1]));

        }

        [TestMethod]
        public void Reading9()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);

            Assert.IsTrue(boxToAssure[2].Equals(boxTest[2]));

        }

        [TestMethod]
        public void Reading10()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);


            Assert.IsTrue(boxToAssure[3].Equals(boxTest[3]));

        }

        [TestMethod]
        public void Reading11()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);
            boxToAssure[4] = new FilmCircle(5);
            boxToAssure[5] = new FilmRectangle(1, 1, 1, 1);
            boxToAssure[6] = new FilmTriangle(1, 1, 1);

            Assert.IsTrue(boxToAssure[4].Equals(boxTest[4]));

        }

        [TestMethod]
        public void Reading12()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);
            boxToAssure[4] = new FilmCircle(5);
            boxToAssure[5] = new FilmRectangle(1, 1, 1, 1);
            boxToAssure[6] = new FilmTriangle(1, 1, 1);

            Assert.IsTrue(boxToAssure[5].Equals(boxTest[5]));

        }

        [TestMethod]
        public void Reading13()
        {
            string path = @"..\..\..\..\epam_task_3.1\Box.xml";

            Box boxTest = new Box();

            FileReader fileExtensions = new FileReader();
            boxTest = fileExtensions.ReadXmlByXmlTextReader(path);

            Box boxToAssure = new Box();
            boxToAssure[0] = new PaperCircle(5, Color.red);
            boxToAssure[1] = new PaperCircle(1, Color.red);
            boxToAssure[2] = new PaperRectangle(1, 1, 1, 1, Color.red);
            boxToAssure[3] = new PaperTriangle(1, 1, 1, Color.red);
            boxToAssure[4] = new FilmCircle(5);
            boxToAssure[5] = new FilmRectangle(1, 1, 1, 1);
            boxToAssure[6] = new FilmTriangle(1, 1, 1);

            Assert.IsTrue(boxToAssure[6].Equals(boxTest[6]));

        }

    }
}