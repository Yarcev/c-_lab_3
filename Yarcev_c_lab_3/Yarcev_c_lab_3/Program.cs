using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_c_lab_3
{
    /// <summary>
    /// в нашем случае 
    /// у наблюдателя всегда полный список 
    /// издателей (заказов на грант)
    /// </summary>
    class Program
    {
        static void lineCh(char s)
        {
            for (int i = 0; i < 80; i++)
                Console.Write(s);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" c# lab_3 author: Yarcev D.A. IS-61");
            Console.WriteLine(" variant - 7");
            lineCh('=');

            //список заявок на грант
            List<ConcreteSubject> subjects = new List<ConcreteSubject>();
            List<ConcreteObserver> observers = new List<ConcreteObserver>();
            //list stam
            List<string> status = new List<string>() { 
                "создан",
                "рассматривается",
                "отложен",
                "отклонен",
                "подтвержден",
                "отозван "
                };

            bool keyLoop = true;
            while (keyLoop)
            {
                //subjects.Add(new ConcreteSubject());
                //observers.Add(new ConcreteObserver(subjects.Last()));
                //observers.Add(new ConcreteObserver(subjects.Last()));
                //subjects.Last().Attach(observers[observers.Count - 2]);
                //subjects.Last().Attach(observers[observers.Count - 1]);
                //subjects.Last().State = "Some State ...";
                //subjects.Last().Notify();
                //Console.WriteLine(observers[observers.Count - 2].observerState);
                //Console.WriteLine(observers[observers.Count - 1].observerState);

                Console.WriteLine(" menu:");
                Console.WriteLine(" 1) add grant");
                Console.WriteLine(" 2) edit state grants");
                Console.WriteLine(" 3) show state grants");
                Console.WriteLine(" 4) close program");
                
                bool key = true;
                while (key)
                {
                    key = false;
                    Console.Write(" to do: ");
                    int chose = Convert.ToInt32(Console.ReadLine().ToString());
                    if (chose < 1 || chose > 4)
                    {
                        key = true;
                        Console.WriteLine(" Erorr!");
                    }
                    lineCh('-');
                    switch (chose)
                    {
                        case 1://create

                            //sub name
                            ConcreteSubject new_Subject = new ConcreteSubject();
                            Console.Write(" input grand name :");
                            new_Subject.Name = Console.ReadLine().ToString();
                            new_Subject.State = status[0];
                            subjects.Add(new_Subject);

                            //obs name
                            observers.Add(new ConcreteObserver(subjects.Last()));
                            observers.Add(new ConcreteObserver(subjects.Last()));
                            Console.Write(" input autor name :");
                            observers[observers.Count - 2].Name = Console.ReadLine().ToString();
                            Console.Write(" input worker name:");
                            observers[observers.Count - 1].Name = Console.ReadLine().ToString();

                            //add
                            subjects.Last().Attach(observers[observers.Count - 2]);
                            subjects.Last().Attach(observers[observers.Count - 1]);
                            //add
                            break;
                        case 2://edit
                            Console.WriteLine("list grands:");
                            for (int ii = 0; ii < subjects.Count; ii++)
                                Console.WriteLine(ii + " - " + subjects[ii].Name);
                            Console.WriteLine("list states:");
                            Console.WriteLine("0 - создан");
                            Console.WriteLine("1 - рассматривается");
                            Console.WriteLine("2 - отложен");
                            Console.WriteLine("3 - отклонен");
                            Console.WriteLine("4 - подтвержден");
                            Console.WriteLine("5 - отозван ");
                            Console.Write(" input num grand:");
                            int i = Convert.ToInt32(Console.ReadLine().ToString());
                            Console.Write(" input num status:");
                            int j = Convert.ToInt32(Console.ReadLine().ToString());
                            if (i < 0 || i > subjects.Count - 1) i = 0;
                            if (j < 0 || j > 5) j = 0;
                            //edit
                            //Console.WriteLine(subjects[i].Name);
                            //Console.WriteLine(subjects[i].State);
                            //Console.WriteLine(status[j]);
                            subjects[i].State = status[j];
                            subjects[i].Notify();
                            break;
                        case 3://show
                            Console.WriteLine("list observers:");
                            for (int ii = 0; ii < observers.Count; ii++)
                                Console.WriteLine(" " + ii + " ~ " + observers[ii].Name +" ~ "+ observers[ii].observerState);
                            break;
                        case 4:
                            keyLoop = false;
                            break;
                    }
                }
                lineCh('-');
            }
            Console.WriteLine(" Program is ending ...");
            Console.ReadKey();
        }
    }
}
