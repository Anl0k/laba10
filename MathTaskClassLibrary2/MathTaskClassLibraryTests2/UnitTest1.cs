using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathTaskClassLibrary2;

namespace MathTaskClassLibraryTests2
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void CylinderVolume_1and100_314returned()
        {
            double r = 1.00;
            double h = 100.00;
            double expected = 314.00;

            Geometry g = new Geometry();
            double actual = g.CylinderVolume(r, h);

            Assert.AreEqual(expected, actual);
        }
    }
}
