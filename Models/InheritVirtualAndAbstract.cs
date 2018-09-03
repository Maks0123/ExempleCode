using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons1.Models
{
    abstract class SomeClassAbstract
    {
        public virtual void Test1()
        {
            Console.WriteLine("This is Test1 from Abstract");
        }

        public void Test2()
        {
            Console.WriteLine("This is Test2 from Abstract");
        }

        public abstract void Test3();
    }

    class SomeClassBase : SomeClassAbstract
    {
        public override void Test1()
        {
            Console.WriteLine("This is Test1 from Base");
        }

        public new void Test2()
        {
            Console.WriteLine("This is Test2 from Base");
        }
        public override void Test3()
        {
            Console.WriteLine("This is Test3 from Base");
        }
    }
    

    class SomeClassChild : SomeClassBase
    {
        public override void Test1()
        {
            Console.WriteLine("This is Test1 from Child");
        }
        public new void Test2()
        {
            Console.WriteLine("This is Test2 from Child");
        }
        public override void Test3()
        {
            Console.WriteLine("This is Test3 from Child");
        }
    }

 
  /* 
            SomeClassBase baseObj = new SomeClassBase();

            baseObj.Test1();
            baseObj.Test2();

            SomeClassChild child = new SomeClassChild();

            child.Test1();
            child.Test2();


            SomeClassAbstract obj = new SomeClassChild();

            obj.Test1();
            obj.Test2();

            SomeClassAbstract o = new SomeClassBase();
            
        
   */ 
}
