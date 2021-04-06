using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ekzamen_IS_19_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekzamen_IS_19_02.Tests
{
    [TestClass()]
    public class DominoTests
    {

        [TestMethod()]
        public void GoDominoTest_true()
        {
            Domino d = new Domino();
            Domino_bone bone = new Domino_bone(1, 6);

            int expectedTitle = 1;
            int expectedHead  = 6;
            int countExpected = 2;

            var actual = d.GoDomino(bone);
            Assert.IsTrue(actual);
            Assert.AreEqual(expectedTitle, d.tail);
            Assert.AreEqual(expectedHead, d.head);
            Assert.AreEqual(countExpected, d.dominos.Count);

            Assert.AreEqual(d.dominos[0].PointOne, 1);
            Assert.AreEqual(d.dominos[0].PointTwo, 1);

            Assert.AreEqual(d.dominos[1].PointOne, 1);
            Assert.AreEqual(d.dominos[1].PointTwo, 6);

        }

        [TestMethod()]
        public void GoDominoTest_3_true()
        {
            Domino d = new Domino();
            Domino_bone bone = new Domino_bone(1, 6);
            Domino_bone bone1 = new Domino_bone(5, 1);
            Domino_bone bone2 = new Domino_bone(5, 4);

            int expectedTitle = 4;
            int expectedHead = 6;
            int countExpected = 4;

            var actual = d.GoDomino(bone);
            actual = d.GoDomino(bone1);
            actual = d.GoDomino(bone2);

            Assert.IsTrue(actual);
            Assert.AreEqual(expectedTitle, d.tail);
            Assert.AreEqual(expectedHead, d.head);
            Assert.AreEqual(countExpected, d.dominos.Count);


            Assert.AreEqual(d.dominos[0].PointOne, 5);
            Assert.AreEqual(d.dominos[0].PointTwo, 4);

            Assert.AreEqual(d.dominos[1].PointOne, 5);
            Assert.AreEqual(d.dominos[1].PointTwo, 1);

            Assert.AreEqual(d.dominos[2].PointOne, 1);
            Assert.AreEqual(d.dominos[2].PointTwo, 1);

            Assert.AreEqual(d.dominos[3].PointOne, 1);
            Assert.AreEqual(d.dominos[3].PointTwo, 6);
        }

    }
}