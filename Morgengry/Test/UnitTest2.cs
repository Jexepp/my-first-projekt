using System;
using Morgengry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest2
    {
        Book b1, b2, b3;
        Amulet a1, a2, a3;
        Course c1, c2;

        //CourseRepository courses;
        BookRepository books;
        //AmuletRepository amulets;

        [TestInitialize]
        public void Init()
        {
            // Arrange

            b1 = new Book("1");
            b2 = new Book("2", "Falling in Love with Yourself");
            b3 = new Book("3", "Spirits in the Night", 123.55);

            a1 = new Amulet("11");
            a2 = new Amulet("12", Level.high);
            a3 = new Amulet("13", Level.low, "Capricorn");

            c1 = new Course("Eufori med røg");
            c2 = new Course("Nuru Massage using Chia Oil", 157);

            //courses = new CourseRepository();
            books = new BookRepository();
            //amulets = new AmuletRepository();

        }

        [TestMethod]
        public void TestGetValueForBook1()
        {
            // Assert
            Assert.AreEqual(0.0, Utility.GetValueOfBook(b1));
        }
        [TestMethod]
        public void TestGetValueForBook2()
        {
            // Assert
            Assert.AreEqual(0.0, Utility.GetValueOfBook(b2));
        }
        [TestMethod]
        public void TestGetValueForBook3()
        {
            // Assert
            Assert.AreEqual(123.55, Utility.GetValueOfBook(b3));
        }

        [TestMethod]
        public void TestGetValueForAmulet1()
        {
            // Assert
            Assert.AreEqual(20.0, Utility.GetValueOfAmulet(a1));
        }
        [TestMethod]
        public void TestGetValueForAmulet2()
        {
            // Assert
            Assert.AreEqual(27.5, Utility.GetValueOfAmulet(a2));
        }
        [TestMethod]
        public void TestGetValueForAmulet3()
        {
            // Assert
            Assert.AreEqual(12.5, Utility.GetValueOfAmulet(a3));
        }

        [TestMethod]
        public void TestGetValueForCourse1()
        {
            // Assert
            Assert.AreEqual(0.0, Utility.GetValueOfCourse(c1));
        }
        [TestMethod]
        public void TestGetValueForCourse2()
        {
            // Assert
            Assert.AreEqual(2625.0, Utility.GetValueOfCourse(c2));
        }

        [TestMethod]
        public void TestGetTotalValueForBook()
        {
            // Act
            books.AddBook(b1);
            books.AddBook(b2);
            books.AddBook(b3);

            // Assert
            Assert.AreEqual(123.55, books.GetTotalValue());
        }
        //[TestMethod]
        //public void TestGetTotalValueForAmulet()
        //{
        //    // Act
        //    amulets.AddAmulet(a1);
        //    amulets.AddAmulet(a2);
        //    amulets.AddAmulet(a3);

        //    // Assert
        //    Assert.AreEqual(60.0, amulets.GetTotalValue());
        //}
        //[TestMethod]
        //public void TestGetTotalValueForCourse()
        //{
        //    // Act
        //    courses.AddCourse(c1);
        //    courses.AddCourse(c2);

        //    // Assert
        //    Assert.AreEqual(2625.0, courses.GetTotalValue());
        //}

    }

}
