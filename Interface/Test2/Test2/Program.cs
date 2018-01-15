using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Demo : abc, def
    {
        static void Main(string[] args)
        {
            abc test = new Demo();
            test.xyz();
            abc test1 = new Sample();
            test1.xyz();
            def test2 = new Demo();
            test2.asd();

            //

            Notebook notebook = new Notebook();
            iMonitor mon = notebook as iMonitor;//반드시 형변환 하여 사용
            mon.turnon();
            DisplayObject(new computer());
            DisplayObject(new Person("semisysco"));
          
        }


        public void xyz()
        {
            Console.WriteLine("Test");
        }

        public void asd()
        {
            Console.WriteLine("Testtt");
        }

        public static void DisplayObject(object obj)
        {
            if (obj is IobjectTOstring) // 인터페이스로 형변환이 가능한가 ?
            {
                Console.WriteLine(obj.ToString());
            }
            
        }


    }

    class computer
    {
    }

    interface abc
    {
        void xyz();
    }
    interface def : abc
    {
        void asd();
    }

    class Sample : abc
    {
        public void xyz()
        {
            Console.WriteLine("Test2");
        }
    }

    class Computer
    {
    }

    interface iMonitor
    {
        void turnon();


    }
    interface IkeyBoard
    {

    }

    class Notebook : Computer, iMonitor, IkeyBoard
    {
        public void turnon()
        {
        }
        int inch;
        public int Inch
        {
            get { return inch; }
            set { inch = value; }
        }

    }
    interface IobjectTOstring // 인터페이스로 빈값 정의
    {

    }

    class Person : IobjectTOstring // tostring 으로 재정의했다는 의미로 상속
    {
        string name;
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return "Person: " + this.name;
        }
    }
}