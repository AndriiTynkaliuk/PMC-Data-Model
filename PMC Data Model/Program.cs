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
            Point<double> point2DFl = new Point<double>(4.0, 5.1);
            Point<double> point3DFl = new Point<double>(6.8, 7.7, 8.5);

            Position<int> integerPos = new Position<int>();
            integerPos.Add(point2DInt);
            integerPos.Add(point3DInt);
            Position<double> floatPos = new Position<double>();
            floatPos.Add(point2DFl);
            floatPos.Add(point3DFl);

            Console.WriteLine("Generated points: ");
            PositionEnumerator<int> eI = new PositionEnumerator<int>(integerPos);
            while(eI.MoveNext())
            {
                Console.WriteLine(eI.Current.ToString());
            }
            PositionEnumerator<double> eF = new PositionEnumerator<double>(floatPos);
            while (eF.MoveNext())
            {
                Console.WriteLine(eF.Current.ToString());
            }

            eF.Reset();
            eI.Reset();

            integerPos.Clear();
            floatPos.Remove(point3DFl);

            if (!floatPos.Contains(point3DFl))
                Console.WriteLine("No such element in the collection");

            while (eI.MoveNext())
            {
                Console.WriteLine(eI.Current.ToString());
            }
            while (eF.MoveNext())
            {
                Console.WriteLine(eF.Current.ToString());
            }

            floatPos.Add(point3DFl);
            eF.Reset();
            Console.WriteLine("double position:");
            while (eF.MoveNext())
            {
                Console.WriteLine(eF.Current.ToString());
            }
            Matrix<double> matrix = new Matrix<double>();
            matrix.Add(floatPos);
            MatrixEnumerator<double> eM = new MatrixEnumerator<double>(matrix);
            Console.WriteLine("Double matrix:");
            Position<double> newPosition = new Position<double>();
            while (eM.MoveNext())
            {
                Console.WriteLine(eM.Current + " | ");
                newPosition = eM.Current;
            }

            PositionEnumerator<double> p = new PositionEnumerator<double>(newPosition);
            Console.WriteLine("New double position:");
            while (p.MoveNext())
            {
                Console.WriteLine(p.Current.ToString());
            }
            Console.ReadKey();
        }
    }
}
