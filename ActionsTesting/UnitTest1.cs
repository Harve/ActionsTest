using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using ActionsTestProgram;

namespace ActionsTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person person = new Person("Harvey", 21);
            Assert.AreEqual(21,person.age);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Person person = new Person("Harvey", 21);
            person.haveBirthday();
            Assert.AreEqual(22, person.age);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Person person = new Person("Harvey", 21);
            Person person2 = new Person("Harry", 20);
            person2.haveBirthday();
            Assert.AreEqual(person.age, person2.age);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Person person = new Person("Harvey", Int32.MaxValue);
            person.haveBirthday();
            Assert.AreEqual(Int32.MinValue, person.age);
        }

    }
}
