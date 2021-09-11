using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Question a = new Question();
            ManageQuestion manage = new ManageQuestion();
            manage.CreateQuestion(a);
          
        }
    }
}
