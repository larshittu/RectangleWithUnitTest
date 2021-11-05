using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Assignment02.Tests
{
    [TestClass]
    public class RectangleTest
    {
        /// <summary>
        /// GetLenght
        /// </summary>
        [TestMethod]
        public void GetLenght()
        {
            var result = Rectangle.GetLength();
            Assert.AreEqual(result, 1);
        }

        /// <summary>
        /// GetLenght IsNotNUll
        /// </summary>
        [TestMethod]
        public void GetLenghtIsNotNUll()
        {
            var result = Rectangle.GetLength();
            Assert.IsNotNull(result);
        }


        /// <summary>
        /// GetLenght AreNotEqual
        /// </summary>
        [TestMethod]
        public void GetLenghtAreNotEqual()
        {
            var result = Rectangle.GetLength();
            Assert.AreNotEqual(result, 0);
        }


        /// <summary>
        /// SetLength
        /// </summary>
        [TestMethod]
        public void SetLength()
        {
            var result = Rectangle.SetLength(38);
            Assert.AreEqual(result, 1);
        }


        /// <summary>
        /// SetLength IsNotNUll
        /// </summary>
        [TestMethod]
        public void SetLengthIsNotNUll()
        {
            var result = Rectangle.SetLength(58);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// SetLength AreNotEqual
        /// </summary>
        [TestMethod]
        public void SetLengthAreNotEqual()
        {
            var result = Rectangle.SetLength(60);
            Assert.AreNotEqual(result, 0);
        }

        /// <summary>
        /// GetWidth
        /// </summary>
        [TestMethod]
        public void GetWidth()
        {
            var result = Rectangle.GetWidth();
            Assert.AreEqual(result, 1);
        }

        /// <summary>
        /// GetWidth IsNotNUll
        /// </summary>
        [TestMethod]
        public void GetWidthIsNotNUll()
        {
            var result = Rectangle.GetWidth();
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// GetHeight AreNotEqual
        /// </summary>
        [TestMethod]
        public void GetWidthAreNotEqual()
        {
            var result = Rectangle.GetWidth();
            Assert.AreNotEqual(result, 0);
        }


        /// <summary>
        /// SetWidth
        /// </summary>
        [TestMethod]
        public void SetWidth()
        {
            var result = Rectangle.SetWidth(68);
            Assert.AreEqual(result, 1);
        }

        /// <summary>
        /// SetWidth IsNotNUll
        /// </summary>
        [TestMethod]
        public void SetWidthIsNotNUll()
        {
            var result = Rectangle.SetWidth(28);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// SetWidth AreNotEqual
        /// </summary>
        [TestMethod]
        public void SetWidthAreNotEqual()
        {
            var result = Rectangle.SetWidth(95);
            Assert.AreNotEqual(result, 0);
        }

        /// <summary>
        /// GetHeight
        /// </summary>
        [TestMethod]
        public void GetHeight()
        {
            var result = Rectangle.GetHeight();
            Assert.AreEqual(result, 1);
        }

        /// <summary>
        /// GetHeight IsNotNUll
        /// </summary>
        [TestMethod]
        public void GetHeightIsNotNUll()
        {
            var result = Rectangle.GetHeight();
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// GetHeight AreNotEqual
        /// </summary>
        [TestMethod]
        public void GetHeightAreNotEqual()
        {
            var result = Rectangle.GetHeight();
            Assert.AreNotEqual(result, 0);
        }

        /// <summary>
        /// SetHeight of an Rectangle
        /// </summary>
        [TestMethod]
        public void SetHeight()
        {
            var result = Rectangle.SetHeight(70);
            Assert.AreEqual(result, 1);
        }

        /// <summary>
        /// SetHeight IsNotNUll
        /// </summary>
        [TestMethod]
        public void SetHeightIsNotNUll()
        {
            var result = Rectangle.SetHeight(80);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// SetHeight AreNotEqual
        /// </summary>
        [TestMethod]
        public void SetHeightAreNotEqual()
        {
            var result = Rectangle.SetHeight(54);
            Assert.AreNotEqual(result, 0);
        }

        /// <summary>
        /// GetVolume of the Rectangle
        /// </summary>
        [TestMethod]
        public void GetVolume()
        {
            var result = Rectangle.GetVolume();
            Assert.AreNotSame(result, 1);
        }

        /// <summary>
        /// GetVolume of the Rectangle IsNotNUll
        /// </summary>
        [TestMethod]
        public void GetVolumeIsNotNUll()
        {
            var result = Rectangle.GetVolume();
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// GetVolume of the Rectangle AreNotEqual
        /// </summary>
        [TestMethod]
        public void GetVolumeAreNotEqual()
        {
            var result = Rectangle.GetVolume();
            Assert.AreNotEqual(result, 0);
        }
    }
}
