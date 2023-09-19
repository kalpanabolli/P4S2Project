using SchoolLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTest
{
    [TestFixture]
    public class ClassTests
    {
        [Test]
        public void TestClassName()
        {
            // Arrange
            Class myClass = new Class();
            myClass.CName = "Hindi";

            // Act
            string className = myClass.CName;

            // Assert
            Assert.AreEqual("Hindi", className);
        }

        [Test]
        public void TestClassId()
        {
            // Arrange
            Class myClass = new Class();
            myClass.CId = 1;

            // Act
            int classId = myClass.CId;

            // Assert
            Assert.AreEqual(1, classId);
        }
    }
}
