﻿using System.Robot;
using System.Robot.Clicks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var robot = new Robot();
            robot.AutoDelay = 1000;
            robot.MouseMove(100, 100);
            robot.MouseMove(700, 500);
            //robot.Click(Mouse.RightButton());
            while (true)
            {
                System.Console.WriteLine(robot.GetMousePosition());
            }
        }
    }
}