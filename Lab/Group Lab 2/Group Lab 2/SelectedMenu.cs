using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;



namespace Group_Lab_2
{
    
  public  class SelectedMenu
    {
  

        public SelectedMenu()
        {

        }
        public  int DisplayMenu()
        {
            return ToInt32(MainMenu());
        }

        public  int MainMenu ()
        {
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine("--Chương trình quản lý đề thi----");
            WriteLine("=================================");
            WriteLine("1. Quản lý câu hỏi/trả lời.");
            WriteLine("2. Quản lý đề thi");
            var result = ReadLine();                      
               return string.IsNullOrEmpty(result) ? 0 : ToInt32(result);
            
        }
        public  void MangeQuestions()
        {
            

            Functions fun = new Functions();
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine("======Quản lý Câu hỏi/Trả lời=======");
            WriteLine("1. Xem danh sách");
            WriteLine("2. Cập nhật câu hỏi");
            WriteLine("3. Tạo mới một câu hỏi");
            WriteLine("0. Trờ về menu chính.");
            int result = ToInt32(ReadLine());
            
            {
                switch (result)
                {
                    case 1:
                        Clear();
                        SeeListOfQuestions();

                        break;
                    case 2:
                        Clear();
                        fun.UpdateQuestions();
                        MangeQuestions();
                        break;
                    case 3:
                        Clear();
                        
                        fun.CreateQuestions();
                        MangeQuestions();

                        break;
                    case 0:
                      Clear();
                        fun.PressAnyKey();
                        break;
                }
            }
           




        }

        public  void SeeListOfQuestions()
        {
            Functions fun = new Functions();
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine("======Danh sách các câu hỏi=========");
            WriteLine("1. Kiến thức phổ thông");
            WriteLine("2. C Programming");
            WriteLine("3. Toán");
            WriteLine("0. Trờ về menu chính.");
            int result = ToInt32(ReadLine());


            switch (result)
            {
                case 1:
                    
                    fun.Display();
                 
                    break;
                case 2:
                    Clear();
                    fun.SelectQuestions();
                    MangeQuestions();
                    break;
                case 3:
                    Clear();
                    fun.SelectQuestions();
                    MangeQuestions();
                    break;
                case 0:

                    Clear();
                    MangeQuestions();
                    break;
            }


        }

        public  void MangeTest()
        {
            Functions fun = new Functions();
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine("====Quản lý đề thi=================");
            WriteLine("1. Xem đề thi");
            WriteLine("2. Tạo đề thi");         
            WriteLine("0. Trờ về menu chính.");
            int result = ToInt32(ReadLine());
            switch (result)
            {
                case 1:
                    Clear();
                    fun.SelectTest();
                    MangeTest();
                    break;
                case 2:
                    Clear();
                    CreateTest();
                    break;
                
                case 0:
                    Clear();
                     fun.PressAnyKey();
                    break;
            }


        }

        public void CreateTest()
        {
            Functions fun = new Functions();
            Console.OutputEncoding = Encoding.UTF8;
            WriteLine("====Tạo đề thi===================");
            WriteLine("1. Đề thi theo số lượng câu hỏi");
            WriteLine("2. Đề thi theo tổng số điểm");
            WriteLine("0. Trờ về menu chính.");
            int result = ToInt32(ReadLine());
            switch (result)
            {
                case 1:
                    Clear();
                   fun.CreateTest01();
                    CreateTest();
                    break;
                case 2:
                    Clear();
                    fun.CreateTest02();
                   CreateTest();
                    break;

                case 0:
                   Clear();
                    MangeTest();
                    break;
            }

        }


    }
}
