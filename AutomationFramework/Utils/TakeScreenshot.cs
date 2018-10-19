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

        public readonly BasePage baseDriver;

        public string Capture(string screenshotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)baseDriver._parallelConfig.Driver;
            Screenshot screenshot = ts.GetScreenshot();
            string runName = screenshotName + DateTime.Now.ToString("yyyy-MM-dd-HH_mm_ss");
            string drive = "P:\\IS\\ALL_IS\\App Groups\\Web\\QA\\CPQ\\Screenshots\\";
            string imageName = drive + runName + ".jpg";

            if (!Directory.Exists(drive))
            {
                Directory.CreateDirectory(drive);
                screenshot.SaveAsFile(imageName, ScreenshotImageFormat.Png);
            }
            else
            {
                screenshot.SaveAsFile(imageName, ScreenshotImageFormat.Png);
            }
            return imageName;
        }
    }
}
