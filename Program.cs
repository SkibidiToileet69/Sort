namespace Sort
{
    

class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
            new Student("Стефан", 15),
            new Student("Иван", 17),
            new Student("Йоан", 16),
            new Student("Петър", 14)
        };

            BubbleSort(students);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} - {student.Age} години");
            }
        }

        static void BubbleSort(Student[] array)
        {
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].Age > array[j + 1].Age)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
}