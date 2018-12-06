using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yarcev_c_lab_3
{
    /// <summary>
    /// заявление на получение 
    /// гранта - конкретный издатель
    /// </summary>
    class ConcreteSubject : Subject
    {
        //состояние заявления
        public string State { get; set; }
        //name
        public string Name { get; set; }
    }
}
