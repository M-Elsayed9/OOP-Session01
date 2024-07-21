namespace Assignment
{
        enum WeekDays
        {
            Monoday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string _Name, int _Age)
            {
                Name = _Name;
                Age = _Age;
            }

        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        enum Colors
        {
            Red,
            Green,
            Blue
        }

        struct Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int _X, int _Y)
            {
                X = _X;
                Y = _Y;
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                #region Q1
                // Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as
                // its members. Then, write a C# program that prints out all the days of the week
                // using this enum.

                //foreach(var day in Enum.GetValues(typeof(WeekDays)))
                //{
                //    Console.WriteLine(day);
                //}

                #endregion

                #region Q2
                // Define a struct "Person" with properties "Name" and "Age". Create an array of
                // three "Person" objects and populate it with data. Then, write a C# program to
                // display the details of all the persons in the array.

                //Person[] persons =
                //{
                //    new Person("Omar", 22),
                //    new Person("Mohamed", 21),
                //    new Person("Ali", 15)
                //};

                //for(int i=0;i<persons.Length;i++)
                //{
                //    Console.WriteLine($"Person Number {i+1}: Name = {persons[i].Name}, Age = {persons[i].Age}");
                //}




                #endregion

                #region Q3
                // Create an enum called "Season" with the four seasons (Spring, Summer, Autumn,
                // Winter) as its members. Write a C# program that takes a season name as input
                // from the user and displays the corresponding month range for that season.
                // Note range for seasons ( spring march to may , summer june to august ,
                // autumn September to November , winter December to February)

                //Console.Write("Enter Season Name: ");
                //string input = Console.ReadLine();

                //Season season;

                //if(Enum.TryParse(input, out season))
                //{
                //    switch (season)
                //    {
                //        case Season.Spring:
                //            Console.WriteLine("Range March to May");
                //            break;
                //        case Season.Summer:
                //            Console.WriteLine("Range June to August");
                //            break;
                //        case Season.Autumn:
                //            Console.WriteLine("Range September to November");
                //            break;
                //        case Season.Winter:
                //            Console.WriteLine("Range December to February");
                //            break;
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Invalid Season Name");
                //}


                #endregion

                #region Q4
                // Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                //Create Variable from previous Enum to Add and Remove Permission from variable,
                //check if specific Permission is existed inside variable

                //Permissions permissions = Permissions.Read;

                //Console.WriteLine(permissions);

                //permissions |= Permissions.Write;

                //Console.WriteLine(permissions);

                //permissions &= ~Permissions.Write;

                //Console.WriteLine(permissions);

                //if((permissions & Permissions.Delete) == Permissions.Delete)
                //{
                //    Console.WriteLine("Permission is Exist");
                //}
                //else
                //{
                //    Console.WriteLine("Permission is not Exist");
                //}

                #endregion

                #region Q5
                // Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its
                // members. Write a C# program that takes a color name as input from the user and
                // displays a message indicating whether the input color is a primary color or not.

                //Console.Write("Enter Color Name: ");
                //string Input = Console.ReadLine();

                //Colors color;

                //// Red == red == rEd
                //if(Enum.TryParse(Input, true, out color))
                //{
                //    Console.WriteLine("Primary Color");
                //}
                //else
                //{
                //    Console.WriteLine("Not Primary Color");
                //}

                #endregion

                #region Q6
                // Create a struct called "Point" to represent a 2D point with properties "X" and "Y"
                // . Write a C# program that takes two points as input from the user and calculates
                // the distance between them.

                //Point p1 = new Point();
                //Point p2 = new Point();

                //Console.Write("Enter x value for first point: ");
                //p1.X = int.Parse(Console.ReadLine());
                //Console.Write("Enter y value for first point: ");
                //p1.Y = int.Parse(Console.ReadLine());

                //Console.Write("Enter x value for second point: ");
                //p2.X = int.Parse(Console.ReadLine());
                //Console.Write("Enter y value for second point: ");
                //p2.Y = int.Parse(Console.ReadLine());

                //double Distance = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));

                //Console.WriteLine($"The Distance = {Distance}");
                #endregion

                #region Q7
                // Create a struct called "Person" with properties "Name" and "Age". Write a C#
                // program that takes details of 3 persons as input from the user and displays
                // the name and age of the oldest person.

                //Person[] people = new Person[3];

                //Person OldestPerson = new Person();

                //OldestPerson.Age = 0;

                //for(int i = 0; i < people.Length; i++)
                //{
                //    Console.Write($"Enter the name of person Number {i+1}");
                //    people[i].Name = Console.ReadLine();
                //    Console.Write($"Enter the Age of person Number {i + 1}");
                //    people[i].Age = Convert.ToInt32(Console.ReadLine());

                //    if (people[i].Age > OldestPerson.Age)
                //    {
                //        OldestPerson = people[i];
                //    }
                //}

                //Console.WriteLine($"The oldest person Name: {OldestPerson.Name}, Age: {OldestPerson.Age}");


                #endregion

            }
        }
}
