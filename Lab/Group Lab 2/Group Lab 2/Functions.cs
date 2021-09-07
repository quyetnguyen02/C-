using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Group_Lab_2
{
  public  class Functions
    {
        List<Questions> questions = new List<Questions>();
        public  void PressAnyKey()
        {
            WriteLine("Press Any Key");
            ReadLine();
            Clear();

        }

        public  void SelectQuestions()
        {
            WriteLine("Xem ds cau hoi");

        }
        public  void UpdateQuestions()
        {
            WriteLine("Update cau hoi");
        }

        internal  void CreateQuestions()
        {
            String choose;
            while (true)
            {
                Questions question = new Questions();
                question.input();
                Write("Bạn muốn lưu câu hỏi này? (Y/N)");
                string a = ReadLine();
                if (a == "N")

                {
                    while (a != "Y")
                    {
                        Write("Bạn muốn lưu câu hỏi này? (Y/N)");
                        a = ReadLine();
                    }

                }
                else
                {

                    questions.Add(question);
                    WriteLine("Sign Up Success");

                }
                WriteLine("Bạn Có Nhập Tiếp KHông?(Y/N)");
                choose = ReadLine();
                if (choose.Equals("n")) break;
            }
        }

        public  void CreateTest01()
        {
            WriteLine("Tao de thi theo so luong cau hoi");
        }

        public  void CreateTest02()
        {
            WriteLine("Tao de thi theo tong diem");
        }

        public  void SelectTest()
        {
            WriteLine("Xem de thi");
        }

        public void Display()
        {
            foreach(var item in questions)
            {
                item.Display1();
            }
        }
    }
}
