using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PianoCartesiano
{
    public class cartesianPlane
    {
        private int _windowsWidht;
        private int _WindowsHeight;
        private int _origX;
        private int _origY;

        public int WindowsWidht
        {
            get { return _windowsWidht; }
        }

        public int WindowsHeight
        {
            get { return _WindowsHeight; }
        }

        public int OrigCol
        {
            get { return _origX; }
        }

        public int OrigRow
        {
            get { return _origY; }
        }

        public cartesianPlane(int windowsWidht, int windowsHeight, int origCol, int origRow)
        {
            _windowsWidht = windowsWidht;
            _WindowsHeight = windowsHeight;
            _origX = origCol;
            _origY = origRow;

        }
        public void WriteAt(string s, int x, int y)
        {

            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(s);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }

        public void WriteAxes()
        {
            for (int i = 0; i < _windowsWidht; i++)
            {
                if (i == _origX)
                {
                    WriteAt("+", _origX, _origY);
                }
                else
                {
                    WriteAt("―", i, _origY);
                }
            }
            for (int i = 0; i < _WindowsHeight; i++)
            {
                if (i != _origY)
                {
                    WriteAt("|", _origX, i);
                }
            }
        }


    }
}
