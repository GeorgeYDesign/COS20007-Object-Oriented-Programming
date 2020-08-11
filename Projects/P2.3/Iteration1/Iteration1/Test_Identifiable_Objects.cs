using System;
using NUnit.Framework;

namespace Iteration1
{
    [TestFixture]
    public class Test_Identifiable_Object 
    {
        private Identifiable_Object _id;

        [SetUp]
        public void SetUp()
        {
            _id = new Identifiable_Object(new string[] { "id1", "id2" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.That(_id.AreYou("id1"), Is.True);
        }

        [Test]
        public void TestAreYouNot()
        {
            Assert.That(_id.AreYou("id3"), Is.False);
        }

        [Test]
        public void TestAreYouCaseSensative()
        {
            Assert.That(_id.AreYou("ID1"), Is.True);
        }

        [Test]
        public void TestFirstID()
        {
            Assert.AreEqual("id1", _id.FirstId(), "id1 should be First ID");

        }

        [Test]
        public void TestAddID()
        {
            _id.Add_Identifier("id3");
            Assert.That(_id.AreYou("id3"), Is.True);
        }
    }



}
