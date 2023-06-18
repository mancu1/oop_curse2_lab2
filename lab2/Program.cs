/*
Объявить класс, содержащий одномерный целочисленный массив 
размерностью 10, индексатор для работы с этим массивом. Создать 
объект данного класса. Ввести с клавиатуры элементы массива 
объекта. Найти элемент массива наиболее близкий по своему 
значению средне арифметическому значению элементов массива. 
Распечатать значение этого элемента и его индекс 
 */



namespace lab2
{
    class ClassForArrayWithAvg
    {
        private double[] _arr =new double[10];
        public double this[int j]
        {
            get
            {
                return _arr[j];
            }
            set
            {
                _arr[j]=value;
            }
        }
    }
    class Class1
    {
        static void Main(string[] args)
        {
            ClassForArrayWithAvg obj = new ClassForArrayWithAvg();
            for(int i=0; i<10;i++)
            {
                obj[i] = Convert.ToDouble(Console.ReadLine());
            }
            
            // calc arithmetic mean
            
            double avg =0;
            for(int i=0; i<10;i++)
            {
                avg+=obj[i];
            }
            avg /= 10;
            
            // find closest to arithmetic mean

            int closestIndex = 0;
            for (int i = 0; i < 10; i++)
            {
                closestIndex = Math.Abs(obj[i] - avg) < Math.Abs(obj[closestIndex] - avg) ? i : closestIndex;
            }
            
            // print result close value and index
            
            Console.WriteLine("Close value to avg: {0} with index {1}", obj[closestIndex], closestIndex);
            
            
            
            
        }
    }
}