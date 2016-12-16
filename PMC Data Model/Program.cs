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
            Console.WriteLine("Welcome to the next PMC apllication");
            Point<int> point2DInt = new Point<int>(4, 5);
            Point<int> point3DInt = new Point<int>(6, 7, 8);
            Point<float> point2DFl = new Point<float>(4f, 5f);
            Point<float> point3DFl = new Point<float>(6f, 7f, 8f);

            Position<int> integerPos = new Position<int>();
            integerPos.Add(point2DInt);
            integerPos.Add(point3DInt);
            Position<float> floatPos = new Position<float>();
            floatPos.Add(point2DFl);
            floatPos.Add(point3DFl);

            Console.WriteLine("Generated points: ");
            PositionEnumerator<int> eI = new PositionEnumerator<int>(integerPos);
            while(eI.MoveNext())
            {
                Console.WriteLine(eI.Current.ToString());
            }
            PositionEnumerator<float> eF = new PositionEnumerator<float>(floatPos);
            while (eF.MoveNext())
            {
                Console.WriteLine(eF.Current.ToString());
            }
            Console.ReadKey();
        }
    }
}
