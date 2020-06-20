using System;
using System.Collections.Generic;
using System.Dynamic;
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
            //var buffer = new CircularBuffer<double>(3);

            //ProcessInput(buffer);
            //ProcessBuffer(buffer);

            //var numbers = new List<int>();
            //var capacity = -1;

            //while(true)
            //{
            //    if(numbers.Capacity!=capacity)
            //    {
            //        capacity = numbers.Capacity;
            //        Console.WriteLine(capacity);

            //    }

            //    numbers.Add(1);
            //}
            ////////////////////////
            ///List
            ////////////////////////
            #endregion

            #region Queue
            ///////////////////////
            ///Queue   FIFO
            ///////////////////////
            //Queue<Employee> line = new Queue<Employee>();
            //line.Enqueue(new Employee { Name = "Alex" });
            //line.Enqueue(new Employee { Name = "Dani" });
            //line.Enqueue(new Employee { Name = "Chris" });
            //while(line.Count >0)
            //{
            //    var employee = line.Dequeue();
            //    Console.WriteLine(employee.Name);
            //}
            ///////////////////////////
            ///Queue end
            //////////////////////////

            //////////////////////////
            ///Stack
            //////////////////////////

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
            //set.Add(a);
            //set.Add(b);

            //set.Add(new Employee() { Name = "Alex", Ages = 40, DepartmentId = 1, Id = 1 });
            //set.Add(new Employee() { Name = "Alex", Ages = 40, DepartmentId = 1, Id = 1 });
            //set.Add(new Employee() { Name = "Chris" });

            //var set1 = new HashSet<Employee>() { new Employee { Name = "Peter" }, new Employee { Name = "Alex" } };
            //var set2 = new HashSet<Employee>() { new Employee { Name = "Peter" }, new Employee { Name = "Alex" },new Employee { Name = "Chris" },new Employee { Name = "Marry" } };

            //set1.SymmetricExceptWith(set2);
            //Console.WriteLine(set1);
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
            //var first = lklist.First;

            //lklist.AddAfter(first, 6);

            //lklist.AddBefore(first, 7);

            //var node = lklist.First;
            //while(node!=null)
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
            ////////////////////////////////////////////////////////////////
            ///LinkedList
            ///////////////////////////////////////////////////////////////
            #endregion

            #region Dictionary
            //////////////////////////////////////////////
            ///Dictionary
            ///

            var employeesByName = new Dictionary<string, List<Employee>>();

            employeesByName.Add("H", new List<Employee>()
                {
                    new Employee { Name = "Harirak" } });
            employeesByName.Add("A", new List<Employee>()
                {
                    new Employee { Name = "Alex" } });
            employeesByName["H"].Add(new Employee { Name = "Harirak" });



            var getValueName= employeesByName["H"];
            foreach (var item in employeesByName)
            {
                foreach(var employee in item.Value)
                {
                    Console.WriteLine(employee.Name);
                }
            }

            foreach (var item in getValueName)
            {
                Console.WriteLine(item.Name);
            }
           
            /////////////////////////////////////////////////////////////////////
            ///Dictionary
            ////////////////////////////////////////////////////////////////
            #endregion
        }

        private static void ProcessBuffer(CircularBuffer<double> buffer)
        {
            var sum = 0.0;
            Console.WriteLine("Buffer: ");
            while (!buffer.IsEmpty) //do it when true
            {
                Console.WriteLine(buffer.Read());
            }
            Console.WriteLine(sum); 
        }

        private static void ProcessInput(CircularBuffer<double> buffer)
        {
            while (true)
            {
                var value = 0.0;
                var input = Console.ReadLine();
                if (double.TryParse(input, out value))
                {
                    buffer.Write(value);
                    continue;
                }
                break;
            }
        }

    }
}
