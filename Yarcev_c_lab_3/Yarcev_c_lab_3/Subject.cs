using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yarcev_c_lab_3
{
    /// <summary>
    /// грант с людьми что слядят за ним
    /// </summary>
    abstract class Subject
    {
        public List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
            observer.Update();
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (Observer observer in observers)
                observer.Update();
        }
    }
}
