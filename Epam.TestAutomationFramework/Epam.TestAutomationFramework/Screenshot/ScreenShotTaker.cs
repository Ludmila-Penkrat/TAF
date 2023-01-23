using Epam.TestAutomationFramework.Core.Helpers;
using OpenQA.Selenium;
using System.Drawing;

namespace Epam.TestAutomationFramework.Core.Screenshot
{
    public static class ScreenShotTaker
    {
        public static void TakeScreenShot (IWebDriver driver, string testName, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string screenFileName = $"{testName}_{DateTime.Now:dd.MM}.{ScreenshotImageFormat.Jpeg.ToString().ToLowerInvariant()}";

            string screenPath = Path.Combine(TestSettings.ScreenShotPath, screenFileName);

            //using (Image screenshot = Image.FromStream(new MemoryStream(((ITakesScreenshot)driver).GetScreenshot().AsByteArray)));

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(screenPath);
        }
    }
}
