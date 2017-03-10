using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication2
{
    public class Create
    {
        static Point endPoint;
        static Pen pen = new Pen(Color.Black, 2);
        static Pen pen1 = new Pen(Color.Black, 1);
        static SolidBrush drawBrush = new SolidBrush(Color.Black);
        static Font drawFont = new Font("Arial", 8);

        public Create(List<ProtokolModel> protokol)
        {
            this.Protokol = protokol;
        }
        public List<ProtokolModel> Protokol { get; set; }       
        public void DrawGrafic(Graphics e)
        {            
            int pointY = 25;

            foreach (var element in Protokol)
            {
                for (int i = 0; i < element.Medicals.Count; i++)
                {
                    List<int> arrDays = element.Medicals[i].Days;
                    string nameMedicamnet = element.Medicals[i].Name;                   
                    e.DrawString(nameMedicamnet, drawFont, drawBrush, new Point(50, pointY)); //Draw the name of the medicine
                    e.DrawLine(pen1, new Point(arrDays[0]*10 + 40, pointY + 20),
                        new Point(arrDays[arrDays.Count - 1]*10 + 40, pointY + 20)); //horizontal line

                    for (int inderArr = 0; inderArr < arrDays.Count; inderArr++) //arrow
                    {
                        DrawLineArrow(new Point(arrDays[inderArr]*10 + 40, pointY + 20), 20, 'y', pen1, e);
                    }

                    pointY += 60;
                }


                int allLength = 350;
                DrawDeyLine(new Point(50, pointY), allLength, e); //line of constant day

                int circle = element.Circle*10 + 40;
                int lengthOne = circle/3;
                int lenghtText = 10;
                int lengthTwo = circle*2/3 - 10 - 50; //-10 to text - 50 for the beginning

                DrawLineWithVertLine(new Point(50, pointY + 50), lengthOne, 'l', e); //direction l or r
                e.DrawString("1", drawFont, drawBrush, new PointF(50 + circle/3, pointY + 43));
                DrawLineWithVertLine(new Point(50 + circle/3 + lenghtText, pointY + 50), lengthTwo, 'r', e);

                int lenghtTwoLine = allLength - circle + 20;
                DrawLineWithVertLine(new Point(circle + 10, pointY + 50), lenghtTwoLine/3, 'l', e);
                e.DrawString("2", drawFont, drawBrush, new Point(lenghtTwoLine/3 + circle + 10, pointY + 43));
                DrawLineArrow(new Point((lenghtTwoLine/3) + circle + 10 + 10, pointY + 50), lenghtTwoLine*2/3, 'x', pen,
                    e); //direction x or y

                e.DrawString("Protokol number: " + element.ProtokolID.ToString(), drawFont, drawBrush, new Point(0, 0));
            }           
        }

        private void DrawLineArrow(Point startPoint, int length, char direction, Pen pen, Graphics e)
        {
            if (direction.Equals('x'))
            {
                endPoint = new Point(length + startPoint.X, startPoint.Y);

                e.DrawLine(pen, new Point(endPoint.X, startPoint.Y - 5), new Point(endPoint.X, startPoint.Y + 6));

                e.DrawLine(pen, new Point(endPoint.X, startPoint.Y - 5), new Point(endPoint.X + 10, endPoint.Y));
                e.DrawLine(pen, new Point(endPoint.X, startPoint.Y + 5), new Point(endPoint.X + 10, endPoint.Y));
                Point[] pointsPoligon =
                {
                    new Point(endPoint.X, startPoint.Y - 5),
                    new Point(endPoint.X + 10, endPoint.Y),
                    new Point(endPoint.X, startPoint.Y + 5)
                };

                e.FillPolygon(drawBrush, pointsPoligon);
            }

            if (direction.Equals('y'))
            {
                endPoint = new Point(startPoint.X, startPoint.Y + length);

                e.DrawLine(pen, new Point(endPoint.X - 5, endPoint.Y), new Point(endPoint.X + 6, endPoint.Y));

                e.DrawLine(pen, new Point(endPoint.X - 5, endPoint.Y), new Point(endPoint.X, endPoint.Y + 10));
                e.DrawLine(pen, new Point(endPoint.X + 5, endPoint.Y), new Point(endPoint.X, endPoint.Y + 10));
                Point[] pointsPoligon =
                {
                    new Point(endPoint.X - 5, endPoint.Y),
                    new Point(endPoint.X, endPoint.Y + 10),
                    new Point(endPoint.X + 5, endPoint.Y)
                };

                e.FillPolygon(drawBrush, pointsPoligon);
            }

            e.DrawLine(pen, startPoint, endPoint);
        }

        private void DrawLineWithVertLine(Point startPoint, int length, char direction, Graphics e)
        {
            endPoint = new Point(length + startPoint.X, startPoint.Y);
            e.DrawLine(pen, startPoint, endPoint);

            if (direction.Equals('l'))
            {
                e.DrawLine(pen, new Point(startPoint.X, startPoint.Y - 5),
                    new Point(startPoint.X, startPoint.Y + 6));
            }

            if (direction.Equals('r'))
            {
                e.DrawLine(pen, new Point(endPoint.X, startPoint.Y - 5),
                    new Point(endPoint.X, startPoint.Y + 6));
            }
        }

        private void DrawDeyLine(Point startPoint, int length, Graphics e)
        {
            endPoint = new Point(length + startPoint.X, startPoint.Y);
            e.DrawLine(pen, startPoint, endPoint);
            int interval = length / 5;
            int indexDay = 1;

            for (int i = startPoint.X; i < endPoint.X; i += interval)
            {
                e.DrawLine(pen, new Point(i, startPoint.Y - 5), new Point(i, startPoint.Y + 6));

                e.DrawString(indexDay.ToString(), drawFont, drawBrush, new PointF(i - 5, startPoint.Y + 10));
                indexDay += 7;
            }
        }
    }
}