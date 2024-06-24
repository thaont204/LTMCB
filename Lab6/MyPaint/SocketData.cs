using System;
using System.Drawing;

namespace MyPaint
{
    [Serializable]
    public class SocketData
    {
        public Color PenColor { get; set; }
        public int Width { get; set; }
        public Point OldPos { get; set; }
        public Point CurrentPos { get; set; }

        // Constructor
        public SocketData(Color penColor, int width, Point oldPos, Point currentPos)
        {
            PenColor = penColor;
            Width = width;
            OldPos = oldPos;
            CurrentPos = currentPos;
        }

        // Default constructor for serialization
        public SocketData()
        {
        }
    }

}
