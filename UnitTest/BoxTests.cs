using CollectionLibrary;
using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class BoxTests
    {
        [TestMethod]
        public void GetActualBoxSize()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);
            t_box[5] = new FilmTriangle(1, 1, 1);

            int ex_size = 6;

            Assert.AreEqual(ex_size, t_box.Size);
        }

        [TestMethod]
        public void AddFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);

            double t_r = 15;
            Color t_color = Color.green;
            PaperCircle t_circle = new PaperCircle(t_r, t_color);

            t_box.Add(t_circle);

            Box ex_box = new Box();
            ex_box[0] = new PaperCircle(5, Color.red);
            ex_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            ex_box[2] = new PaperCircle(t_r, t_color);

            CollectionAssert.AreEqual(ex_box.Items, t_box.Items);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddFigureToFullBox()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            t_box[4] = new FilmRectangle(1, 1, 1, 1);
            t_box[5] = new FilmTriangle(1, 1, 1);
            t_box[6] = new PaperCircle(3, Color.red);
            t_box[7] = new PaperRectangle(2, 1, 2, 1, Color.red);
            t_box[8] = new PaperTriangle(2, 2, 2, Color.red);
            t_box[9] = new FilmCircle(6);
            t_box[10] = new FilmRectangle(7, 7, 7, 7);
            t_box[11] = new FilmTriangle(5, 5, 5);
            t_box[12] = new PaperCircle(1, Color.blue);
            t_box[13] = new PaperRectangle(1, 1, 1, 1, Color.green);
            t_box[14] = new PaperTriangle(1, 1, 1, Color.blue);
            t_box[15] = new FilmCircle(6);
            t_box[16] = new FilmRectangle(10, 10, 10, 10);
            t_box[17] = new FilmTriangle(3, 4, 5);
            t_box[18] = new PaperCircle(13, Color.red);
            t_box[19] = new PaperRectangle(9, 1, 9, 1, Color.red);

            double t_r = 15;
            Color t_color = Color.green;
            PaperCircle t_circle = new PaperCircle(t_r, t_color);

            t_box.Add(t_circle);          
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddSameFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            double t_r = 15;
            Color t_color = Color.green;
            PaperCircle t_circle = new PaperCircle(t_r, t_color);
            t_box[1] = t_circle;

            t_box.Add(t_circle);
           
        }

        [TestMethod]
        public void ShowFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            int i = 0;

            Figure t_circle = t_box.Show(i);
            PaperCircle ex_circle = new PaperCircle(5, Color.red);
            Assert.AreEqual(ex_circle, t_circle);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ShowWrongIndexFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            int i = 5;

            PaperCircle t_circle = (PaperCircle)t_box.Show(i);
            PaperCircle ex_circle = new PaperCircle(5, Color.red);
            Assert.AreEqual(ex_circle, t_circle);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void WrongSetFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);

            PaperCircle t_circle = new PaperCircle(5, Color.red);
            int i = -5;
            t_box.Set(i, t_circle);
        }

        [TestMethod]
        public void GetArea()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);

            double t_Area = t_box.GetTotalArea();
            double ex_Area = 79.972;

            Assert.AreEqual(ex_Area, t_Area, 0.001);
        }

        [TestMethod]
        public void GetPerimeter()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);

            double t_Perimeter= t_box.GetTotalPerimeter();
            double ex_Perimeter = 38.416;

            Assert.AreEqual(ex_Perimeter, t_Perimeter, 0.001);
        }

        [TestMethod]
        public void GetCircles()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new PaperRectangle(1, 1, 1, 1, Color.red);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);

            List<Figure> t_circles = new List<Figure>();

            t_circles = t_box.GetCircles();

            List<Figure> ex_circles = new List<Figure>
            {
                new PaperCircle(5, Color.red),
                new FilmCircle(5)

            };
            CollectionAssert.AreEqual(ex_circles, t_circles);
        }

        [TestMethod]
        public void GetFilmFigures()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new FilmRectangle(1, 1, 1, 1);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);

            List<Figure> t_circles = new List<Figure>();

            t_circles = t_box.GetFilmFigures();

            List<Figure> ex_circles = new List<Figure>
            {
                new FilmRectangle(1, 1, 1, 1),
                new FilmCircle(5)

            };
            CollectionAssert.AreEqual(ex_circles, t_circles);
        }

        [TestMethod]
        public void FindFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new FilmRectangle(1, 1, 1, 1);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);
            PaperCircle ex_circle = new PaperCircle(5, Color.red);

            Assert.IsTrue(t_box.Find(ex_circle));
        }

        [TestMethod]
        public void SetFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new FilmRectangle(1, 1, 1, 1);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);

            FilmTriangle ex_circle = new FilmTriangle(1,1,1);

            t_box.Set(1, ex_circle);

            Box ex_box = new Box();
            ex_box[0] = new PaperCircle(5, Color.red);
            ex_box[1] = new FilmTriangle(1, 1, 1);
            ex_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            ex_box[3] = new FilmCircle(5);

            CollectionAssert.AreEqual(ex_box.Items, t_box.Items);

        }

        [TestMethod]
        public void TakeFigure()
        {
            Box t_box = new Box();
            t_box[0] = new PaperCircle(5, Color.red);
            t_box[1] = new FilmRectangle(1, 1, 1, 1);
            t_box[2] = new PaperTriangle(1, 1, 1, Color.red);
            t_box[3] = new FilmCircle(5);

            Figure takenFigure = t_box.Take(2);
  
            Box ex_box = new Box();
            ex_box[0] = new PaperCircle(5, Color.red);
            ex_box[1] = new FilmRectangle(1, 1, 1, 1);
            ex_box[2] = new FilmCircle(5);

            CollectionAssert.AreEqual(ex_box.Items, t_box.Items);

        }
    }
}
