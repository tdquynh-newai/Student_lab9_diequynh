using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace StudentManagement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Score_8_Shouldbe_A()
        {
            Student s = new Student();
            s.Score = 8;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }


        [TestMethod]
        public void Score_10_Shouldbe_A()
        {
            Student s = new Student();
            s.Score =10;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void Score_8half_Shouldbe_A()
        {
            Student s = new Student();
            s.Score = 8.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void Score_7_Shouldbe_B()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void Score_7half_Shouldbe_B()
        {
            Student s = new Student();
            s.Score = 7.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void Score_5_Shouldbe_C()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void Score_6half_Shouldbe_C()
        {
            Student s = new Student();
            s.Score = 6.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void Score_3half_Shouldbe_D()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void Score_4half_Shouldbe_D()
        {
            Student s = new Student();
            s.Score = 4.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
        [TestMethod]
        public void Score_34_Shouldbe_E()
        {
            Student s = new Student();
            s.Score = 3.4;
            char letter = s.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestMethod]
        public void PassingNull_Exception_Thrown()
        {
            StudentService s = new StudentService();
            Student v = null;
            bool hasException = false;
            try
            {
                s.addStudent(v);
            }
            catch
            {
                hasException = true;
            }
            Assert.IsTrue(hasException);
        }

        [TestMethod]
        public void Check_ID() 
        { 
            StudentService s = new StudentService();
            Student v = null;
            bool hasException = false;
            try
            {
                s.addStudent(v);
            }
            catch
            {
                hasException = true;
            }
            Assert.IsTrue(hasException);
        }
    }
}
