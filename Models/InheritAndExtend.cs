using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons1.Models
{

    static class MyExtendStr
    {
        public static void Test(this String str)
        {

        }
        public static void Test(this String str, int a)
        {

        }
    }

    interface IPeople
    {
        string FirstName { get; }
        string LastName { get; }
        int Age { get; }
    }
    class People : IPeople
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    interface IStudent : IPeople
    {
        IList<int> Marks { get; }
        void AddMark(int mark);
    }
    
    class Student : People, IStudent
    {
        public IList<int> Marks
        {
            get;
            private set;
        }

        public Student()
        {
            Marks = new List<int>();
        }

        public void AddMark(int mark)
        {
            if (mark < 1 || mark > 12) throw new ArgumentOutOfRangeException();
            Marks.Add(mark);
        }
    }

    class Student_PeopleWrapper : IStudent
    {
        private People _people;
        public int Age
        {
            get
            {
                return _people.Age;
            }
        }
        public string FirstName
        {
            get
            {
                return _people.FirstName;
            }
        }
        public string LastName
        {
            get
            {
                return _people.LastName;
            }
        }
        public IList<int> Marks { get; } = new List<int>();

        public void AddMark(int mark)
        {
            if (mark < 1 || mark > 12) throw new ArgumentOutOfRangeException();
            Marks.Add(mark);
        }
    }

    
    /*            String str = "Vasa";
            str.Test();
            str.Test(10);

            IStudent st = new Student { FirstName = "Vasa", LastName = "Pupkin", Age = 18 };
            st.AddMark(12);
        
    */
}
 