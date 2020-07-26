using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class FigureCreationTests
    {
        [TestMethod]
        public void PaperCircleCreation1()
        {
            double t_r = 5;
            Color t_color = Color.red;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double ex_r = 5;
            Color ex_color = Color.red;

            PaperCircle ex_paperCircle = new PaperCircle(ex_r, ex_color);

            Assert.IsTrue(ex_paperCircle.Equals(t_paperCircle));
        }

        [TestMethod]
        public void PaperCircleCreation2()
        {
            double t_r = 15;
            Color t_color = Color.blue;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double ex_r = 15;
            Color ex_color = Color.blue;

            PaperCircle ex_paperCircle = new PaperCircle(ex_r, ex_color);

            Assert.IsTrue(ex_paperCircle.Equals(t_paperCircle));
        }

        [TestMethod]
        public void PaperCircleCreation3()
        {
            double t_r = 5421;
            Color t_color = Color.green;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double ex_r = 5421;
            Color ex_color = Color.green;

            PaperCircle ex_paperCircle = new PaperCircle(ex_r, ex_color);

            Assert.IsTrue(ex_paperCircle.Equals(t_paperCircle));
        }

        [TestMethod]
        public void PaperCircleIntoRectangleConverstion1()
        {
            double t_r = 5;
            Color t_color = Color.red;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            double t_d = 1;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_paperCircle);

            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            double ex_d = 1;
            Color ex_color = Color.red;

            PaperRectangle ex_paperRectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_paperRectangle.Equals(t_paperRectangle));
        }

        [TestMethod]
        public void PaperCircleIntoRectangleConverstion2()
        {
            double t_r = 25;
            Color t_color = Color.green;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double t_a = 1;
            double t_b = 4;
            double t_c = 1;
            double t_d = 4;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_paperCircle);

            double ex_a = 1;
            double ex_b = 4;
            double ex_c = 1;
            double ex_d = 4;
            Color ex_color = Color.green;

            PaperRectangle ex_paperRectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_paperRectangle.Equals(t_paperRectangle));
        }

        [TestMethod]
        public void PaperCircleIntoRectangleConverstion3()
        {
            double t_r = 100;
            Color t_color = Color.blue;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double t_a = 10;
            double t_b = 5;
            double t_c = 10;
            double t_d = 5;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_paperCircle);

            double ex_a = 10;
            double ex_b = 5;
            double ex_c = 10;
            double ex_d = 5;
            Color ex_color = Color.blue;

            PaperRectangle ex_paperRectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_paperRectangle.Equals(t_paperRectangle));
        }

        [TestMethod]
        public void PaperCircleIntoTriangleConverstion1()
        {
            double t_r = 5;
            Color t_color = Color.red;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double t_a = 1;
            double t_b = 1;
            double t_c = 1;

            PaperTriangle t_paperTriangle = new PaperTriangle(t_a, t_b, t_c, t_paperCircle);

            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            Color ex_color = Color.red;

            PaperTriangle ex_paperTriangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);

            Assert.IsTrue(ex_paperTriangle.Equals(t_paperTriangle));
        }

        [TestMethod]
        public void PaperCircleIntooTriangleConverstion2()
        {
            double t_r = 25;
            Color t_color = Color.green;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double t_a = 5;
            double t_b = 4;
            double t_c = 5;

            PaperTriangle t_paperTriangle = new PaperTriangle(t_a, t_b, t_c, t_paperCircle);

            double ex_a = 5;
            double ex_b = 4;
            double ex_c = 5;
            Color ex_color = Color.green;

            PaperTriangle ex_paperTriangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);

            Assert.IsTrue(ex_paperTriangle.Equals(t_paperTriangle));
        }

        [TestMethod]
        public void PaperCircleIntooTriangleConverstion3()
        {
            double t_r = 100;
            Color t_color = Color.blue;

            PaperCircle t_paperCircle = new PaperCircle(t_r, t_color);

            double t_a = 10;
            double t_b = 5;
            double t_c = 10;

            PaperTriangle t_paperTriangle = new PaperTriangle(t_a, t_b, t_c, t_paperCircle);

            double ex_a = 10;
            double ex_b = 5;
            double ex_c = 10;
            Color ex_color = Color.blue;

            PaperTriangle ex_paperTriangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);

            Assert.IsTrue(ex_paperTriangle.Equals(t_paperTriangle));
        }

        [TestMethod]
        public void FilmCircleCreation1()
        {
            double t_r = 5;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double ex_r = 5;

            FilmCircle ex_filmCircle = new FilmCircle(ex_r);

            Assert.IsTrue(ex_filmCircle.Equals(t_filmCircle));
        }

        [TestMethod]
        public void FilmCircleCreation2()
        {
            double t_r = 15;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double ex_r = 15;

            FilmCircle ex_filmCircle = new FilmCircle(ex_r);

            Assert.IsTrue(ex_filmCircle.Equals(t_filmCircle));
        }

        [TestMethod]
        public void FilmCircleCreation3()
        {
            double t_r = 5421;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double ex_r = 5421;

            FilmCircle ex_filmCircle = new FilmCircle(ex_r);

            Assert.IsTrue(ex_filmCircle.Equals(t_filmCircle));
        }

        [TestMethod]
        public void FilmCircleIntoRectangleConverstion1()
        {
            double t_r = 5;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            double t_d = 1;

            FilmRectangle t_filmRectangle = new FilmRectangle(t_a, t_b, t_c, t_d);

            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            double ex_d = 1;

            FilmRectangle ex_filmRectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_filmRectangle.Equals(t_filmRectangle));
        }

        [TestMethod]
        public void FilmCircleIntoRectangleConverstion2()
        {
            double t_r = 25;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double t_a = 1;
            double t_b = 4;
            double t_c = 1;
            double t_d = 4;

            FilmRectangle t_filmRectangle = new FilmRectangle(t_a, t_b, t_c, t_d);

            double ex_a = 1;
            double ex_b = 4;
            double ex_c = 1;
            double ex_d = 4;

            FilmRectangle ex_filmRectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_filmRectangle.Equals(t_filmRectangle));
        }

        [TestMethod]
        public void FilmCircleIntoRectangleConverstion3()
        {
            double t_r = 100;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double t_a = 10;
            double t_b = 5;
            double t_c = 10;
            double t_d = 5;

            FilmRectangle t_filmRectangle = new FilmRectangle(t_a, t_b, t_c, t_d);

            double ex_a = 10;
            double ex_b = 5;
            double ex_c = 10;
            double ex_d = 5;

            FilmRectangle ex_filmRectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_filmRectangle.Equals(t_filmRectangle));
        }

        [TestMethod]
        public void FilmCircleIntoTriangleConverstion1()
        {
            double t_r = 5;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double t_a = 1;
            double t_b = 1;
            double t_c = 1;

            FilmTriangle t_filmTriangle = new FilmTriangle(t_a, t_b, t_c);

            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;

            FilmTriangle ex_filmTriangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_filmTriangle.Equals(t_filmTriangle));
        }

        [TestMethod]
        public void FilmCircleIntoTriangleConverstion2()
        {
            double t_r = 25;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double t_a = 5;
            double t_b = 4;
            double t_c = 5;

            FilmTriangle t_filmTriangle = new FilmTriangle(t_a, t_b, t_c);

            double ex_a = 5;
            double ex_b = 4;
            double ex_c = 5;

            FilmTriangle ex_filmTriangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_filmTriangle.Equals(t_filmTriangle));
        }

        [TestMethod]
        public void FilmCircleIntoTriangleConverstion3()
        {
            double t_r = 100;

            FilmCircle t_filmCircle = new FilmCircle(t_r);

            double t_a = 10;
            double t_b = 5;
            double t_c = 10;

            FilmTriangle t_filmTriangle = new FilmTriangle(t_a, t_b, t_c);

            double ex_a = 10;
            double ex_b = 5;
            double ex_c = 10;

            FilmTriangle ex_filmTriangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_filmTriangle.Equals(t_filmTriangle));
        }

        [TestMethod]
        public void PaperRectangleCreation1()
        {
            double t_a = 5;
            double t_b = 5;
            double t_c = 5;
            double t_d = 5;

            Color t_color = Color.red;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);

            double ex_a = 5;
            double ex_b = 5;
            double ex_c = 5;
            double ex_d = 5;
            Color ex_color = Color.red;

            PaperRectangle ex_paperRectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_paperRectangle.Equals(t_paperRectangle));
        }

        [TestMethod]
        public void PaperRectangleCreation2()
        {
            double t_a = 15;
            double t_b = 5;
            double t_c = 15;
            double t_d = 5;

            Color t_color = Color.blue;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);

            double ex_a = 15;
            double ex_b = 5;
            double ex_c = 15;
            double ex_d = 5;
            Color ex_color = Color.blue;

            PaperRectangle ex_paperRectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_paperRectangle.Equals(t_paperRectangle));
        }

        [TestMethod]
        public void PaperRectangleCreation3()
        {
            double t_a = 235;
            double t_b = 32;
            double t_c = 235;
            double t_d = 32;

            Color t_color = Color.blue;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);

            double ex_a = 235;
            double ex_b = 32;
            double ex_c = 235;
            double ex_d = 32;
            Color ex_color = Color.blue;

            PaperRectangle ex_paperRectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_paperRectangle.Equals(t_paperRectangle));
        }

        [TestMethod]
        public void PaperRectangleIntoCircleConverstion1()
        {
            double t_a = 15;
            double t_b = 15;
            double t_c = 15;
            double t_d = 15;
            Color t_color = Color.blue;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);


            double t_r = 3;
            PaperCircle t_paperCircle = new PaperCircle(t_r, t_paperRectangle);

            double ex_r = 3;
            Color ex_color = Color.blue;
            PaperCircle ex_paperCircle = new PaperCircle(ex_r, ex_color);

            Assert.IsTrue(ex_paperCircle.Equals(t_paperCircle));
        }

        [TestMethod]
        public void PaperRectangleIntoCircleConverstion2()
        {
            double t_a = 15;
            double t_b = 115;
            double t_c = 15;
            double t_d = 115;
            Color t_color = Color.green;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);


            double t_r = 6;
            PaperCircle t_paperCircle = new PaperCircle(t_r, t_paperRectangle);

            double ex_r = 6;
            Color ex_color = Color.green;
            PaperCircle ex_paperCircle = new PaperCircle(ex_r, ex_color);

            Assert.IsTrue(ex_paperCircle.Equals(t_paperCircle));
        }

        [TestMethod]
        public void PaperRectangleIntoCircleConverstion3()
        {
            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            double t_d = 1;
            Color t_color = Color.blue;

            PaperRectangle t_paperRectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);


            double t_r = 0.5;
            PaperCircle t_paperCircle = new PaperCircle(t_r, t_paperRectangle);

            double ex_r = 0.5;
            Color ex_color = Color.blue;
            PaperCircle ex_paperCircle = new PaperCircle(ex_r, ex_color);

            Assert.IsTrue(ex_paperCircle.Equals(t_paperCircle));
        }

        [TestMethod]
        public void FilmRectangleIntoCircleConverstion1()
        {
            double t_a = 15;
            double t_b = 115;
            double t_c = 15;
            double t_d = 115;

            FilmRectangle t_rectangle = new FilmRectangle(t_a, t_b, t_c, t_d);


            double t_r = 5;
            FilmCircle t_circle = new FilmCircle(t_r, t_rectangle);

            double ex_r = 5;

            FilmCircle ex_circle = new FilmCircle(ex_r);

            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void FilmRectangleIntoCircleConverstion2()
        {
            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            double t_d = 1;

            FilmRectangle t_rectangle = new FilmRectangle(t_a, t_b, t_c, t_d);


            double t_r = 0.25;
            FilmCircle t_circle = new FilmCircle(t_r, t_rectangle);

            double ex_r = 0.25;

            FilmCircle ex_circle = new FilmCircle(ex_r);

            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void FilmRectangleIntoCircleConverstion3()
        {
            double t_a = 15;
            double t_b = 15;
            double t_c = 15;
            double t_d = 15;

            FilmRectangle t_rectangle = new FilmRectangle(t_a, t_b, t_c, t_d);


            double t_r = 3;
            FilmCircle t_circle = new FilmCircle(t_r, t_rectangle);

            double ex_r = 3;

            FilmCircle ex_circle = new FilmCircle(ex_r);

            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void FilmRectangleCreation1()
        {
            double t_a = 5;
            double t_b = 5;
            double t_c = 5;
            double t_d = 5;


            FilmRectangle t_filmRectangle = new FilmRectangle(t_a, t_b, t_c, t_d);

            double ex_a = 5;
            double ex_b = 5;
            double ex_c = 5;
            double ex_d = 5;

            FilmRectangle ex_filmRectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_filmRectangle.Equals(t_filmRectangle));
        }

        [TestMethod]
        public void FilmRectangleCreation2()
        {
            double t_a = 15;
            double t_b = 5;
            double t_c = 15;
            double t_d = 5;

            FilmRectangle t_filmRectangle = new FilmRectangle(t_a, t_b, t_c, t_d);

            double ex_a = 15;
            double ex_b = 5;
            double ex_c = 15;
            double ex_d = 5;

            FilmRectangle ex_filmRectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_filmRectangle.Equals(t_filmRectangle));
        }

        [TestMethod]
        public void FilmRectangleCreation3()
        {
            double t_a = 235;
            double t_b = 32;
            double t_c = 235;
            double t_d = 32;

            FilmRectangle t_filmRectangle = new FilmRectangle(t_a, t_b, t_c, t_d);

            double ex_a = 235;
            double ex_b = 32;
            double ex_c = 235;
            double ex_d = 32;

            FilmRectangle ex_filmRectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_filmRectangle.Equals(t_filmRectangle));
        }

        [TestMethod]
        public void PaperRectangleIntoTriangleConverstion1()
        {
            double t_a = 15;
            double t_b = 15;
            double t_c = 15;
            double t_d = 15;
            Color t_color = Color.blue;

            PaperRectangle t_rectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);


            double t_a1 = 15;
            double t_b1 = 15;
            double t_c1 = 15;
            PaperTriangle t_triangle = new PaperTriangle(t_a1, t_b1, t_c1, t_rectangle);

            double ex_a = 15;
            double ex_b = 15;
            double ex_c = 15;
            Color ex_color = Color.blue;
            PaperTriangle ex_triangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void PaperRectangleIntoTriangleConverstion2()
        {
            double t_a = 150;
            double t_b = 150;
            double t_c = 150;
            double t_d = 150;
            Color t_color = Color.green;

            PaperRectangle t_rectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);


            double t_a1 = 15;
            double t_b1 = 15;
            double t_c1 = 15;
            PaperTriangle t_triangle = new PaperTriangle(t_a1, t_b1, t_c1, t_rectangle);

            double ex_a = 15;
            double ex_b = 15;
            double ex_c = 15;
            Color ex_color = Color.green;
            PaperTriangle ex_triangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void PaperRectangleIntoTriangleConverstion3()
        {
            double t_a = 30;
            double t_b = 150;
            double t_c = 30;
            double t_d = 150;
            Color t_color = Color.green;

            PaperRectangle t_rectangle = new PaperRectangle(t_a, t_b, t_c, t_d, t_color);


            double t_a1 = 2;
            double t_b1 = 2;
            double t_c1 = 2;

            PaperTriangle t_triangle = new PaperTriangle(t_a1, t_b1, t_c1, t_color);

            double ex_a = 2;
            double ex_b = 2;
            double ex_c = 2;
            Color ex_color = Color.green;
            PaperTriangle ex_triangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void FilmRectangleIntoTriangleConverstion1()
        {
            double t_a = 15;
            double t_b = 15;
            double t_c = 15;
            double t_d = 15;

            FilmRectangle t_rectangle = new FilmRectangle(t_a, t_b, t_c, t_d);


            double t_a1 = 15;
            double t_b1 = 15;
            double t_c1 = 15;
            FilmTriangle t_triangle = new FilmTriangle(t_a1, t_b1, t_c1, t_rectangle);

            double ex_a = 15;
            double ex_b = 15;
            double ex_c = 15;

            FilmTriangle ex_triangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void FilmRectangleIntoTriangleConverstion2()
        {
            double t_a = 150;
            double t_b = 150;
            double t_c = 150;
            double t_d = 150;

            FilmRectangle t_rectangle = new FilmRectangle(t_a, t_b, t_c, t_d);


            double t_a1 = 15;
            double t_b1 = 15;
            double t_c1 = 15;
            FilmTriangle t_triangle = new FilmTriangle(t_a1, t_b1, t_c1, t_rectangle);

            double ex_a = 15;
            double ex_b = 15;
            double ex_c = 15;
            FilmTriangle ex_triangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void FilmRectangleIntoTriangleConverstion3()
        {
            double t_a = 30;
            double t_b = 150;
            double t_c = 30;
            double t_d = 150;

            FilmRectangle t_rectangle = new FilmRectangle(t_a, t_b, t_c, t_d);


            double t_a1 = 2;
            double t_b1 = 2;
            double t_c1 = 2;
            FilmTriangle t_triangle = new FilmTriangle(t_a1, t_b1, t_c1, t_rectangle);

            double ex_a = 2;
            double ex_b = 2;
            double ex_c = 2;
            FilmTriangle ex_triangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void PaperTriangleCreation1()
        {
            double t_a = 4;
            double t_b = 5;
            double t_c = 3;
            Color t_color = Color.red;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);


            double ex_a = 4;
            double ex_b = 5;
            double ex_c = 3;
            Color ex_color = Color.red;
            PaperTriangle ex_triangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);


            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void PaperTriangleCreation2()
        {
            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            Color t_color = Color.blue;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);


            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            Color ex_color = Color.blue;
            PaperTriangle ex_triangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);


            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void PaperTriangleCreation3()
        {
            double t_a = 6;
            double t_b = 8;
            double t_c = 10;
            Color t_color = Color.green;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);


            double ex_a = 6;
            double ex_b = 8;
            double ex_c = 10;
            Color ex_color = Color.green;
            PaperTriangle ex_triangle = new PaperTriangle(ex_a, ex_b, ex_c, ex_color);


            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void FilmTriangleCreation1()
        {
            double t_a = 4;
            double t_b = 5;
            double t_c = 3;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double ex_a = 4;
            double ex_b = 5;
            double ex_c = 3;

            FilmTriangle ex_triangle = new FilmTriangle(ex_a, ex_b, ex_c);

            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void FilmTriangleCreation2()
        {
            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);


            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            FilmTriangle ex_triangle = new FilmTriangle(ex_a, ex_b, ex_c);


            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void FilmTriangleCreation3()
        {
            double t_a = 6;
            double t_b = 8;
            double t_c = 10;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);


            double ex_a = 6;
            double ex_b = 8;
            double ex_c = 10;
            FilmTriangle ex_triangle = new FilmTriangle(ex_a, ex_b, ex_c);


            Assert.IsTrue(ex_triangle.Equals(t_triangle));
        }

        [TestMethod]
        public void PaperTriangleIntoCircleConvertion1()
        {
            double t_a = 4;
            double t_b = 5;
            double t_c = 3;
            Color t_color = Color.red;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);

            double r = 0.4;

            PaperCircle t_circle = new PaperCircle(r, t_triangle);

            double ex_r = 0.4;
            Color ex_color = Color.red;
            PaperCircle ex_circle = new PaperCircle(ex_r, ex_color);


            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void PaperTriangleIntoCircleConvertion2()
        {
            double t_a = 6;
            double t_b = 8;
            double t_c = 10;
            Color t_color = Color.red;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);

            double r = 2;

            PaperCircle t_circle = new PaperCircle(r, t_triangle);

            double ex_r = 2;
            Color ex_color = Color.red;
            PaperCircle ex_circle = new PaperCircle(ex_r, ex_color);


            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void PaperTriangleIntoCircleConvertion3()
        {
            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            Color t_color = Color.red;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);

            double r = 0.02;

            PaperCircle t_circle = new PaperCircle(r, t_triangle);

            double ex_r = 0.02;
            Color ex_color = Color.red;
            PaperCircle ex_circle = new PaperCircle(ex_r, ex_color);


            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void FilmTriangleIntoCircleConvertion1()
        {
            double t_a = 4;
            double t_b = 5;
            double t_c = 3;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double r = 0.4;

            FilmCircle t_circle = new FilmCircle(r, t_triangle);

            double ex_r = 0.4;
            FilmCircle ex_circle = new FilmCircle(ex_r);


            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void FilmTriangleIntoCircleConvertion2()
        {
            double t_a = 6;
            double t_b = 8;
            double t_c = 10;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double r = 2;

            FilmCircle t_circle = new FilmCircle(r, t_triangle);

            double ex_r = 2;
            FilmCircle ex_circle = new FilmCircle(ex_r);


            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void FilmTriangleIntoCircleConvertion3()
        {
            double t_a = 1;
            double t_b = 1;
            double t_c = 1;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double r = 0.02;

            FilmCircle t_circle = new FilmCircle(r, t_triangle);

            double ex_r = 0.02;
            Color ex_color = Color.red;
            FilmCircle ex_circle = new FilmCircle(ex_r);


            Assert.IsTrue(ex_circle.Equals(t_circle));
        }

        [TestMethod]
        public void PaperTriangleIntoRectangleConvertion1()
        {
            double t_a = 4;
            double t_b = 5;
            double t_c = 3;
            Color t_color = Color.red;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);

            double t_a1 = 1;
            double t_b1 = 1;
            double t_c1 = 1;
            double t_d1 = 1;

            PaperRectangle t_rectangle= new PaperRectangle(t_a1, t_b1, t_c1, t_d1, t_triangle);

            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            double ex_d = 1;
            Color ex_color = Color.red;
            PaperRectangle ex_rectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);


            Assert.IsTrue(ex_rectangle.Equals(t_rectangle));
        }

        [TestMethod]
        public void PaperTriangleIntoRectangleConvertion2()
        {
            double t_a = 65;
            double t_b = 64;
            double t_c = 63;
            Color t_color = Color.red;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);

            double t_a1 = 1;
            double t_b1 = 2;
            double t_c1 = 1;
            double t_d1 = 2;

            PaperRectangle t_rectangle = new PaperRectangle(t_a1, t_b1, t_c1, t_d1, t_triangle);

            double ex_a = 1;
            double ex_b = 2;
            double ex_c = 1;
            double ex_d = 2;
            Color ex_color = Color.red;
            PaperRectangle ex_rectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);


            Assert.IsTrue(ex_rectangle.Equals(t_rectangle));
        }

        [TestMethod]
        public void PaperTriangleIntoRectangleConvertion3()
        {
            double t_a = 10;
            double t_b = 10;
            double t_c = 10;
            Color t_color = Color.green;
            PaperTriangle t_triangle = new PaperTriangle(t_a, t_b, t_c, t_color);

            double t_a1 = 2;
            double t_b1 = 5;
            double t_c1 = 2;
            double t_d1 = 5;

            PaperRectangle t_rectangle = new PaperRectangle(t_a1, t_b1, t_c1, t_d1, t_triangle);

            double ex_a = 2;
            double ex_b = 5;
            double ex_c = 2;
            double ex_d = 5;
            Color ex_color = Color.green;
            PaperRectangle ex_rectangle = new PaperRectangle(ex_a, ex_b, ex_c, ex_d, ex_color);

            Assert.IsTrue(ex_rectangle.Equals(t_rectangle));
        }

        [TestMethod]
        public void FilmTriangleIntoRectangleConvertion1()
        {
            double t_a = 4;
            double t_b = 5;
            double t_c = 3;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double t_a1 = 1;
            double t_b1 = 1;
            double t_c1 = 1;
            double t_d1 = 1;

            FilmRectangle t_rectangle = new FilmRectangle(t_a1, t_b1, t_c1, t_d1, t_triangle);

            double ex_a = 1;
            double ex_b = 1;
            double ex_c = 1;
            double ex_d = 1;
            FilmRectangle ex_rectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);


            Assert.IsTrue(ex_rectangle.Equals(t_rectangle));
        }

        [TestMethod]
        public void FilmTriangleIntoRectangleConvertion2()
        {
            double t_a = 65;
            double t_b = 64;
            double t_c = 63;
            Color t_color = Color.red;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double t_a1 = 1;
            double t_b1 = 2;
            double t_c1 = 1;
            double t_d1 = 2;

            FilmRectangle t_rectangle = new FilmRectangle(t_a1, t_b1, t_c1, t_d1, t_triangle);

            double ex_a = 1;
            double ex_b = 2;
            double ex_c = 1;
            double ex_d = 2;
            Color ex_color = Color.red;
            FilmRectangle ex_rectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);


            Assert.IsTrue(ex_rectangle.Equals(t_rectangle));
        }

        [TestMethod]
        public void FilmTriangleIntoRectangleConvertion3()
        {
            double t_a = 10;
            double t_b = 10;
            double t_c = 10;
            Color t_color = Color.green;
            FilmTriangle t_triangle = new FilmTriangle(t_a, t_b, t_c);

            double t_a1 = 2;
            double t_b1 = 5;
            double t_c1 = 2;
            double t_d1 = 5;

            FilmRectangle t_rectangle = new FilmRectangle(t_a1, t_b1, t_c1, t_d1, t_triangle);

            double ex_a = 2;
            double ex_b = 5;
            double ex_c = 2;
            double ex_d = 5;
            Color ex_color = Color.green;
            FilmRectangle ex_rectangle = new FilmRectangle(ex_a, ex_b, ex_c, ex_d);

            Assert.IsTrue(ex_rectangle.Equals(t_rectangle));
        }
    }
}
