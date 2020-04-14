using System;

namespace Switch2
{
    class MainApp
    {
        static void Main(string[] args)
        {

            object obj = null;

            string s = Console.ReadLine();

            if (int.TryParse(s, out int out_i))
                obj = out_i;

            else if (float.TryParse(s, out float out_f))
                obj = out_f;

            else obj = s;

            
            Console.WriteLine("{1}는 {0}형식입니다.",obj.GetType().Name,s);
                    
            

        }
    }
}
