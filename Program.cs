using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
namespace Generic
{
    
    class Program
    {
        static void Main()
        {
            #region List
            //////////////
            ///List
            //////////////
            //var buffer = new CircularBuffer<string>();

            //ProcessInput(buffer);
            //ProcessBuffer(buffer);

            //var numbers = new List<double>();
            //var capacity = -1;

            //while (true)
            //{
            //    if (numbers.Capacity != capacity)
            //    {
            //        capacity = numbers.Capacity;
            //        Console.WriteLine(capacity);

            //    }

            //    numbers.Add(1);
            //}
            //var employees = new List<Employee>();
            //employees.Add(new Employee() { Name = "Alex" });
            //employees.Add(new Employee() { Name = "Bob" });
            //employees.Add(new Employee() { Name = "Peter" });
            //Console.WriteLine(employees[0].Name);
            ////////////////////////
            ///List
            ////////////////////////

            #endregion

            #region SortedList
            /////////////////////////////////////////////////////////////
            ///SortedList
            ////////////////////////////////////////////////////////////
            //var list = new SortedList<int, Employee>();
            //list.Add(3, new Employee { Name = "Harirak" });
            //list.Add(1, new Employee { Name = "Peter" });
            //list.Add(2, new Employee { Name = "Robert" });
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Value);
            //}


            /////////////////////////////////////////////////////////////
            ///SortedList End
            ////////////////////////////////////////////////////////////
            #endregion

            #region Queue
            ///////////////////////
            ///Queue   FIFO
            ///////////////////////
            //Queue<Employee> line = new Queue<Employee>();
            //line.Enqueue(new Employee { Name = "Alex" });
            //line.Enqueue(new Employee { Name = "Dani" });
            //line.Enqueue(new Employee { Name = "Chris" });
            //line.Enqueue(new Employee { Name = "Harirak" });
            //line.Enqueue(new Employee { Name = "Harirak" });
            //while (line.Count > 0)
            //{
            //    var employee = line.Dequeue();
            //    Console.WriteLine(employee.Name);
            //}
            ///////////////////////////
            ///Queue end
            //////////////////////////
            #endregion
            #region Stack
            //////////////////////////
            ///Stack FILO
            //////////////////////////
            //var line = new Stack<List<Employee>>();
            //line.Push(new List<Employee>() 
            //    {
            //    new Employee(){Name="Alex" },
            //    new Employee(){Name="Meena"} 
            //    });
            //line.Push(new List<Employee>()
            //    {
            //    new Employee(){Name="Peter" },
            //    new Employee(){Name="Robert"},
            //    new Employee(){Name="Chris"}
            //    });

            //line.Push(new Employee { Name = "Dani" });
            //line.Push(new Employee { Name = "Chris" });
            //line.Push(new Employee { Name = "Harirak" });
            //line.Push(new Employee { Name = "Harirak" });

            //var employees = line.Pop[1];

            //while (line.Count > 0)
            //{
            //    var employee = line.Pop();
            //    Console.WriteLine(employee[line.Count].Name);

            //}
            ///////////////////////////
            ///Stack end
            ///////////////////////////
            #endregion

            #region HashSet
            /////////////////////////////////////////////////////////
            ///HashSet
            ////////////////////////////////////////////////////////////
            //HashSet<Employee> set = new HashSet<Employee>();
            //Employee a = new Employee() { Name = "Alex", Ages = 40, DepartmentId = 1, Id = 1 };
            //Employee b = a;
            //var c = b;
            //set.Add(a);
            //set.Add(b);
            //set.Add(c);

            //set.Add(new Employee());
            //set.Add(new Employee());
            //set.Add(new Employee());

            //Employee setA1 = new Employee { Name = "Peter" };
            //Employee setA2 = new Employee { Name = "Marry" };


            //var setA = new HashSet<Employee>()
            //{   
            //    setA1,setA2,setA1

            //};

            //Employee setB1 = new Employee { Name = "Peter" };
            //Employee setB2 = new Employee { Name = "Marry" };
            //Employee setB3 = new Employee { Name = "Alex" };
            //Employee setB4 = new Employee { Name = "Meena" };
            //var setB = new HashSet<Employee>() 
            //{ 
            //    setB1,setB2,setB3,setB4,setA1

            //};



            //setA.IntersectWith(setB);
            //Employee[] employees = new Employee[10];
            //setA.CopyTo(employees);

            //for (int i = 0; i < employees.Length; i++)
            //{
            //    Console.WriteLine(employees[0].Name);

            //}



            ////////////////////////////////////////////////////////////
            ///HashSet End
            ////////////////////////////////////////////////////////////
            #endregion

            #region LinkedList
            /////////////////////////////////////////////////
            ///LinkedList
            ////////////////////////////////////////////////////
            //LinkedList<int> lklist = new LinkedList<int>();
            //lklist.AddFirst(2);
            //lklist.AddFirst(3);
            //lklist.AddFirst(4);
            //lklist.AddLast(5);
            //var valueinLinkedList = lklist.First;

            //lklist.AddAfter(valueinLinkedList, 6);

            //lklist.AddBefore(valueinLinkedList, 7);

            //var node = lklist.First;
            //while (node != null)
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;

            //}

            //var list = new LinkedList<String>();
            //list.AddFirst("Hello");
            //list.AddLast("World");
            //list.AddAfter(list.First, "there");
            //Console.WriteLine(list.First.Value);

            //list.Remove("there");

            //var listEmployee = new LinkedList<List<Employee>>();
            //listEmployee.AddFirst(new List<Employee> 
            //{
            //    new Employee{Name="Peter" },
            //    new Employee{Name="Harirak"} 
            //});
            //listEmployee.AddFirst(new List<Employee>
            //{
            //    new Employee{Name="Marry" },
            //    new Employee{Name="Robert"},
            //    new Employee{Name="Meena"}
            //});
            //listEmployee.AddLast(new List<Employee>
            //{
            //    new Employee{Name="Chris" },
            //    new Employee{Name="John"},
            //    new Employee{Name="Bob"}
            //});

            ////////////////////////////////////////////////////////////////
            ///LinkedList
            ///////////////////////////////////////////////////////////////
            #endregion

            #region Dictionary
            //////////////////////////////////////////////
            ///Dictionary
            ///

            //var  employeesByName = new Dictionary<string, List<Employee>>();

            //employeesByName.Add("H", new List<Employee>()
            //{
            //        new Employee { Name = "Harirak" },
            //        new Employee { Name = "Hero" }
            //});

            //employeesByName.Add("A", new List<Employee>()
            //{
            //        new Employee { Name = "Alex" } 
            //});

            //employeesByName["H"].Add(new Employee { Name = "Horde" });




            //foreach (var item in employeesByName)
            //{
            //    foreach (var employee in item.Value)
            //    {
            //        Console.WriteLine(employee.Name);
            //    }
            //}

            //var getValueName = employeesByName["H"];//employeesByName["key"]
            //getValueName.Add(new Employee { Name = "Aum" });
            //foreach (var item in getValueName)
            //{
            //    Console.WriteLine(item.Name);
            //}

            /////////////////////////////////////////////////////////////////////
            ///Dictionary
            ////////////////////////////////////////////////////////////////
            #endregion

            #region SortedDictionary
            ////////////////////////////////////////////////////////////////
            ///SortedDictionary
            ////////////////////////////////////////////////////////////////
            ///
            //var list = new SortedList<int, Employee>();
            //list.Add(3, new Employee { Name = "Harirak" });
            //list.Add(1, new Employee { Name = "Peter" });
            //list.Add(2, new Employee { Name = "Robert" });

            //var employeesByNameSort = new SortedDictionary<string, SortedList<int, Employee>>();

            //var slist = new SortedList<int, Employee>();

            //slist.Add(1, new Employee { Name = "Harirak" });

            //employeesByNameSort.Add("A", slist);
            //employeesByNameSort.Add("B", new SortedList<int, Employee> { slist.Add(1, new Employee { Name = "Harirak" });



            //foreach (var item in employeesByNameSort)
            //{
            //    Console.WriteLine($"The count of Employees for {item.Key} is {item.Value.Count}");
            //}
            ////////////////////////////////////////////////////////////////
            ///SortedDictionary End
            ////////////////////////////////////////////////////////////////
            #endregion



            #region AllBuffer

            var buffer = new CircularBuffer<double>(capacity:3);

            buffer.ItemDiscarded += ItemDiscarded;
            ProcessInput(buffer);
            
            //var asDate = buffer.Map(a => new DateTime(2020, 1, 1).AddDays(a));

            //foreach (var date in asDate)
            //{
            //    Console.WriteLine(date);

            //}

            //Printer<double> del = new Printer<double>(ConsoleWrite);

            //Action<bool> print = d => Console.WriteLine(d);
            //Func<double, double> sq = (d) => (d * d);
            //Func<double, double, double> add = (x, y) => (x + y);
            //Predicate<double> islessThanTen = (d) => d < 10;

            //print(islessThanTen(sq(add(3, 5))));

            buffer.Dump(d => Console.WriteLine(d));

            
            
            ProcessBuffer(buffer);
          
            #endregion

            #region Chainning
            //var departments = new SortedDictionary<string, SortedSet<Employee>>();
            //var departments = new DepartmentCollection();


            //departments.Add("Sales", new Employee() { Name = "Danni" })
            //           .Add("Sales", new Employee() { Name = "Bob" })
            //           .Add("Sales", new Employee() { Name = "Bobby" })
            //           .Add("Sales", new Employee() { Name = "Alex" })
            //           .Add("Sales", new Employee() { Name = "Alex" });
                       
                      





            //departments.Add("Engineering", new Employee() { Name = "Meena" })
            //           .Add("Engineering", new Employee { Name = "Scott" })
            //           .Add("Engineering", new Employee { Name = "Alex" })
            //           .Add("Engineering", new Employee { Name = "Dani" });




            //foreach (var department in departments)
            //{
            //    Console.WriteLine(department.Key);
            //    foreach (var employee in department.Value)
            //    {
            //        Console.WriteLine($"\t{employee.Name}");
            //    }
            //}

            #endregion

        }

        private static void ItemDiscarded(object sender, 
            ItemDiscardedEventArgs<double> e)
        {
            Console.WriteLine($"Buffer full. Discarding {e.ItemDiscarded} New Item is {e.NewItem}");
        }

        private static void ProcessBuffer(IBuffer<double> buffer)
        {
            //var sum = 0.0;
            string sum = "";
            Console.WriteLine("Buffer: ");
            
            while (!buffer.IsEmpty) //do it when true
            {
                Console.WriteLine(buffer.Read());
            }

        }

        private static void ProcessInput(IBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();
                if (double.TryParse(input, out value))// //input != "q"
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }

    }
}
