using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Rectangle
    {
        private static int oldlength;
        private static int oldwidth;
        private static int oldheight;

        /// <summary>
        /// Present Rectangle Constructor
        /// </summary>
        public Rectangle()
        {
            oldlength = 1;
            oldwidth = 1;
            oldheight = 1;
        }

        /// <summary>
        /// Rectangle Constructor for User to set rectangle shape size values
        /// </summary>
        /// <param name="userLength"></param>
        /// <param name="userWidth"></param>
        /// <param name="userHeight"></param>
        public Rectangle(int userLength, int userWidth, int userHeight)
        {
            oldlength = userLength;
            oldwidth = userWidth;
            oldheight = userHeight;
        }

        /// <summary>
        /// Get present rectangle lenght
        /// </summary>
        /// <returns>Rectangle lenght</returns>
        public static int GetLength()
        {
            return oldlength;
        }

        /// <summary>
        /// Set new rectangle lenght
        /// </summary>
        /// <returns>Rectangle new lenght</returns>
        public static int SetLength(int length)
        {
            oldlength = length;
            return oldlength;
        }

        /// <summary>
        /// Get present rectangle Width
        /// </summary>
        /// <returns>Rectangle new width</returns>
        public static int GetWidth()
        {
            return oldwidth;
        }


        /// <summary>
        /// set new rectangle Width
        /// </summary>
        /// <returns>Rectangle new width</returns>
        public static int SetWidth(int width)
        {
            oldwidth = width;
            return oldwidth;
        }

        /// <summary>
        /// Get present rectangle height
        /// </summary>
        /// <returns>Rectangle height</returns>
        public static int GetHeight()
        {
            return oldheight;
        }

        /// <summary>
        /// set new rectangle Height
        /// </summary>
        /// <returns>Rectangle new height</returns>
        public static int SetHeight(int height)
        {
            oldheight = height;
            return oldheight;
        }

        /// <summary>
        /// Get rectangle Valume
        /// </summary>
        /// <returns>Rectangle volume</returns>
        public static int GetVolume()
        {
            var volume = oldlength * oldheight * oldwidth;
            return volume;
        }
    }
}
