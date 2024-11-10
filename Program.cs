using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how mane student you want enter");
            int numberStu = Convert.ToInt32(Console.ReadLine());
            List<Student> st = new List<Student>();
            for (int i=0;i<numberStu;i++)
            {
                Console.WriteLine("The name of student? ");
                string Name = Console.ReadLine();
                Console.WriteLine("The id of student? ");
                string Id = Console.ReadLine();
                Console.WriteLine("The mark of student?");
                int Mark = Convert.ToInt32(Console.ReadLine());

                st.Add(new Student { id = Id, mark =Mark, name = Name });
            }
            Console.WriteLine("The name of student who passed");
            for (int i=0;i<st.Count;i++)
            {
                if (st[i].mark >= 50)
                {

                    Console.WriteLine(i+"- "+st[i].name);
                }
            
            }
          
            Console.ReadLine();
        }
    }
}
