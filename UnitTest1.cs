using Microsoft.Playwright;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public async Task Setup()
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                SlowMo = 1000,
                Headless = false // -> Use this option to be able to see your test running
            });

            var context = await browser.NewContextAsync();

            //Initialise a page on the browser context.
            var user = await context.NewPageAsync();

            await user.GotoAsync("https://mattlangcafe.github.io/playwright--screenshot-test/");

            await user.ScreenshotAsync();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}