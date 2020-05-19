using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRandomRealNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 200);
            //1에서 200중에 랜덤값을 1개
            //Console.WriteLine(answer);

            while(true)
            {
                Console.Write("숫자를 입력해주세요 : ");
                int input = int.Parse(Console.ReadLine());

                if(input > answer)
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.");
                    Console.WriteLine();
                } else if(input < answer)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.");
                    Console.WriteLine();
                } else if(input == answer)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
            }
        }
    }
}
