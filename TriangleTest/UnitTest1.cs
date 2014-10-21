using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 1;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 2;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 100;
            string expected = "This can be a Equilateral triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 199;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 200;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod6()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 1;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod7()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 2;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod8()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 100;
            string expected = "This can be a Equilateral triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod9()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 199;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod10()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 200;
            int c = 100;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod11()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 100;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod12()
        {
            triangle target = new triangle();
            int a = 2;
            int b = 100;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod13()
        {
            triangle target = new triangle();
            int a = 100;
            int b = 100;
            int c = 100;
            string expected = "This can be a Equilateral triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod14()
        {
            triangle target = new triangle();
            int a = 199;
            int b = 100;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestMethod15()
        {
            triangle target = new triangle();
            int a = 200;
            int b = 100;
            int c = 100;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Worstcase1()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 1;
            int c = 1;
            string expected = "This can be a Equilateral triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Worstcase2()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 1;
            int c = 2;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Worstcase3()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 1;
            int c = 100;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Worstcase4()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 1;
            int c = 199;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Worstcase5()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 1;
            int c = 200;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase6()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 2;
            int c = 1;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase7()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 2;
            int c = 2;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase8()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 2;
            int c = 100;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase9()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 2;
            int c = 199;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase10()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 2;
            int c = 200;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase11()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 100;
            int c = 1;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase12()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 100;
            int c = 2;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase13()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 100;
            int c = 100;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase14()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 100;
            int c = 199;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase15()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 100;
            int c = 200;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase16()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 199;
            int c = 1;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase17()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 199;
            int c = 2;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase18()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 199;
            int c = 100;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase19()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 199;
            int c = 199;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase20()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 199;
            int c = 200;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase21()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 200;
            int c = 1;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Worstcase22()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 200;
            int c = 2;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Worstcase23()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 200;
            int c = 100;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Worstcase24()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 200;
            int c = 199;
            string expected = "This can't be a triangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Worstcase25()
        {
            triangle target = new triangle();
            int a = 1;
            int b = 200;
            int c = 200;
            string expected = "This can be an Isosceles trangle";
            string actual;
            actual = target.checkTriangleType(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
