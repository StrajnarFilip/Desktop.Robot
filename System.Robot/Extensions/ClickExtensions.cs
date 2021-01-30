﻿using System.Robot.Clicks;

namespace System.Robot.Extensions
{
    public static class ClickExtensions
    {
        public static void Click(this IRobot robot)
        {
            robot.Click(Mouse.LeftButton());
        }
    }
}