using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


  namespace Coding.Exercise
  {
    
    public class Point
    {
      public int X, Y;
        public Point()
        {
            
        }
        public Point (int X , int Y)
        {
            this.X = X;
            this.Y = Y;
            
        }

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }
    }

    public class Line
    {
      public Point Start, End;
      public Line(Point start, Point end)
      {
          this.Start = start;
          this.End = end;
      }
      public override string ToString()
      {
          return $"{nameof(Start)}: X:{Start.X} Y:{Start.Y}, {nameof(End)}: X{End.X} Y:{End.Y}";
      }

      public Line DeepCopy()
      {
        var line = new Line(new Point(Start), new Point(End));
        return line;
      }
    }


  }