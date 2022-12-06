using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false;
            const int WAIT_TICK = 1000 / 30;
            const char CIRCLE = '\u25cf';
            int lastTick = 0;


            while (true)
            {
                #region [프레임 관리]
                // FPS 프레임 (60프레임 OK 30프레임 이하 NO)

                // 시스템이 시작된후 ms (1초는 1000ms)
                int currentTick = System.Environment.TickCount;
                

                // 만약 경과시간이 1/30초 보다 작다면 
                if (currentTick - lastTick < WAIT_TICK)
                {
                    continue;
                }
                lastTick = currentTick;
                #endregion

                // 입력

                // 로직

                // 렌더링
                Console.SetCursorPosition(0, 0);
                
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++ )
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
