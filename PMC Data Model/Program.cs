using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMCLib;

namespace PMC_Data_Model
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> p = new Point<int>(10, 10);
            Position<int> pos = new Position<int>();
            Matrix<int> matrix = new Matrix<int>();
            Container<int> con = new Container<int>();
            Containers<int> cons = new Containers<int>();

            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                pos.Clear();
                for (int j = 0; j < 400; j++)
                {
                        pos.Add(new Point<int>(random.Next(1, 99), random.Next(1, 99)));
                }
                matrix.Add(pos);
            }

            con.Add(matrix);

            cons.Add(con);

            Console.WriteLine("Points: " + pos.Count + " Matrixs: " + matrix.Count + " Container: " + con.Count
                + " Containers: " + cons.Count);

            Position<int> p2 = new Position<int>();
            p2.Add(new Point<int>(0, 0));
            PositionEnumerator<int> en = new PositionEnumerator<int>(p2);

            Point<int>[] pArr = new Point<int>[] { new Point<int>(1, 1), new Point<int>(2, 2) };
            p2.CopyTo(pArr, 1);
            foreach (var element in pArr)
            {
                Console.WriteLine(element.ToString());
            }

            pos.Remove(0);
            Console.WriteLine("Position contains: " + pos.Count);            
            p2.Add(p);
            en.Reset();
            Console.WriteLine("New element Point(10,10) was added");
            while(en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
            if (p2.Contains(p))
                Console.WriteLine("Position p2 contains Point(10, 10)");
            p2.Remove(p);
            en.Reset();
            Console.WriteLine("Eelement Point(10,10) was removed");
            while (en.MoveNext())
            {
                Console.WriteLine(en.Current);
            }
            Console.ReadKey();
        }
    }
}
