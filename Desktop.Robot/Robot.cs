using System.Drawing;
using Desktop.Robot.Clicks;
using System.Runtime.InteropServices;
using System;

namespace Desktop.Robot
{
    public class Robot : IRobot
    {
        private readonly IRobot robot;

        public Robot()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                robot = new OSX.Robot();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                robot = new Windows.Robot();
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                robot = new Linux.Robot();
            }
            else
            {
                throw new PlatformNotSupportedException();
            }
        }

        public uint AutoDelay { get => robot.AutoDelay; set => robot.AutoDelay = value; }

        public void Click(IClick click)
        {
            robot.Click(click);
        }

        public Image CreateScreenCapture(Rectangle screenRect)
        {
            return robot.CreateScreenCapture(screenRect);
        }

        public void Delay(int ms)
        {
            robot.Delay(ms);
        }

        public Point GetMousePosition()
        {
            return robot.GetMousePosition();
        }

        public Color GetPixelColor(int x, int y)
        {
            return robot.GetPixelColor(x, y);
        }

        public void KeyDown(int keycode)
        {
            robot.KeyDown(keycode);
        }

        public void KeyPress(int keycode)
        {
            robot.KeyPress(keycode);
        }

        public void KeyUp(int keycode)
        {
            robot.KeyUp(keycode);
        }

        public void MouseMove(uint x, uint y)
        {
            robot.MouseMove(x, y);
        }
    }
}