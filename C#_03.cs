using System;

namespace study
{
    class Program
    {
        static void Main(string[] args)
        {
            //값 타입과 참조 타입 비교 코드
            
            int value = 3, vcopy;
            vcopy = value;
            vcopy = 4;
            Console.WriteLine("value={0},vcopy={1}",value,vcopy);

            int[] ar, arcopy;
            ar = new int[] { 1, 2, 3, 4, 5 };
            arcopy = ar;
            arcopy[1] = 1234;
            Console.WriteLine("ar[1]={0},arcopy[1]={1}", ar[1], arcopy[1]);

        }
    }
}
