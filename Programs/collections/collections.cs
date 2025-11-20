namespace CollectionsFramework
{
    class CollectionsExample
    {
        public void CollectionsExampleMethod()
        {
            Console.WriteLine("This is and example of the collections framework in C#");
        }

        class ArrayListExample
        {
            public void ArrayLIstExampleMethod()
            {
                // ArraysList
                // there are two ways to declrare an arraylist in c#

                //datatype[] arrayName = new datatype[size]

                int[] grades = new int[5];
                grades[0] = 90;
                grades[1] = 30;
                grades[2] = 60;

                foreach (int grade in grades)
                {
                    Console.WriteLine("Grades: ", grade);
                }

                // there another way to use data as list elements

                int[] grades2 = new int[] { 90, 80, 70, 60, 50 };

                // Arryay Methods
                Console.WriteLine("Length of grades2 array: " + grades2.Length);
            }
        }

        class ListExample
        {
            public void ListExampleMethod()
            {
                // List
                // List is a generic collection that can hold elements of any data type.
                // It is part of the System.Collections.Generic namespace and provides dynamic resizing, allowing you to add or remove elements as needed.

                List<string> fruits = new List<string>();
                List<int> grades = new List<int> { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
                fruits.Add("Apple");
                fruits.Add("Banana");
                fruits.Add("Orange");
                grades.Add(11);
                grades.Add(12);
                grades.Add(12);

                Console.WriteLine("Fruits in the list:");
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
                Console.WriteLine("grades in the list:");
                foreach (int grade in grades)
                {
                    Console.WriteLine(grade);
                }

                // List Methods
                Console.WriteLine("Number of fruits in the list: " + fruits.Count);
                fruits.Remove("Banana");
                Console.WriteLine("Fruits after removing Banana:");
                foreach (string fruit in fruits)
                {
                    Console.WriteLine(fruit);
                }
            }
        }
    }
}
