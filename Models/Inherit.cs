sing System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Lessons1.Models
 {
     
  }  Lessons1.Models
  {
    interface ITest
    {
        void Test();
    }
    interface IMyInterface
    {
        void SomeMethod();
        int MyProp { get; }

        void Test();
    }

    interface ISomeInterface
    {
        void Test();
    }


    class SomeClass : IMyInterface, ISomeInterface, ITest
    {
        public void SomeMethod()
        {

        }
        public int MyProp
        {
            get;
            set;
        }
        public void Test()
        {
            Console.WriteLine("This is test");
        }

        void ISomeInterface.Test()
        {
            Console.WriteLine("This is test from ISomeInterface");
        }
        void IMyInterface.Test()
        {
            Console.WriteLine("This is test from IMyInterface");
        }
    }    

    
            ISomeInterface si = new SomeClass();
            si.Test();

            (si as SomeClass).Test();


            IMyInterface mi = new SomeClass();
            mi.Test();

            IList<int> myIntList = new List<int>();

        
    
}
