using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_c_lab_3
{
    /// <summary>
    /// конкретный сотрудник фонда или автор гранта
    /// </summary>
    class ConcreteObserver : Observer
    {
        public string observerState;
        public string Name;
        ConcreteSubject subject;
        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }
        public override void Update()
        {
            observerState = subject.State;
        }
    }
}
