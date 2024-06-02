using System.Collections;
using static апвпвапв3233.Program;

namespace апвпвапв3233
{
    internal class Program {

        static void Main(string[] args)
        {
            Builder b1 = new Builder { YearOfConstruction = 1980, NumberOfOffices = 90, TotalInternalArea = 3400 };
            Builder b2 = new Builder { YearOfConstruction = 2010, NumberOfOffices = 99, TotalInternalArea = 6500 };
            Builder b3 = new Builder { YearOfConstruction = 1980, NumberOfOffices = 86, TotalInternalArea = 4500 };

            ArrayList buildings = new ArrayList() { b1, b2, b3 };

            buildings.Sort();
            Console.WriteLine("Сортировка по году постройки:");
            foreach (Builder item in buildings)
            {
                Console.WriteLine($"Год постройки: {item.YearOfConstruction}");
            }

            buildings.Sort(new SortOfficceBuilderComparer());
            Console.WriteLine("Сортировка по количеству офисов;");
            foreach (Builder item in buildings)
            {
                Console.WriteLine($"Количество офисов: {item.NumberOfOffices}");
            }

            buildings.Sort(new SortAreaBuilderComparer());
            Console.WriteLine("  Сортировка по общей площади:");
            foreach (Builder item in buildings)
            {
                Console.WriteLine($"Общая площадь: {item.TotalInternalArea}");
            }
        }
        public class Builder: IComparable
        { 
        public int YearOfConstruction { get; set; }
        public int NumberOfOffices { get; set; }
        public double TotalInternalArea { get; set; }

            public int CompareTo(object? obj)
            {
                return YearOfConstruction.CompareTo(obj);
            }
        }
        public class SortOfficceBuilderComparer :IComparer
        {
         

            int IComparer.Compare(object? x, object? y)
            {
                if (x is Builder b1 && y is Builder b2)
                {
                    return b1.NumberOfOffices.CompareTo(b2.NumberOfOffices);
                }
               else
                {
                    return -1;
                }
            }
        }
public class SortAreaBuilderComparer : IComparer
        {
            int IComparer.Compare(object? x, object? y)
            {
                if (x is Builder b3 && y is Builder b4)
                {
                    return b3.TotalInternalArea.CompareTo(b4.TotalInternalArea);
                }
                else
                {
                    return -1;
                }
            }

        }
    }
}
