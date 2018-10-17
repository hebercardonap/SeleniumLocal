using AutomationFramework.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Utils
{
    public class TakeScreenshot
    {
        public static void Capture(string screenshotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)DriverContext.Driver;
            Screenshot screenshot = ts.GetScreenshot();
            string runName = screenshotName + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string drive = "C:\\Selenium\\Polaris\\Screenshots\\";
            if (!Directory.Exists(drive))
            {
                Directory.CreateDirectory(drive);
                screenshot.SaveAsFile(drive + runName + ".jpg", ScreenshotImageFormat.Png);
            }
            else
            {
                string screenshotFileName = drive + runName + ".png";
                string urlfile = "http://storage/screenshots/" + runName + ".png";
                Console.WriteLine("" + urlfile);
            }
        }
    }
}
