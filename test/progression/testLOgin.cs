using Microsoft.Playwright;
using NUnit.Framework;
using System.Threading.Tasks;
using PlaywrightTests.loginPage;

[TestFixture]
public class testLOgin
{
    private IPlaywright _playwright= null!;
    private IBrowser _browser = null!;
    private IPage _page= null!;

    [OneTimeSetUp]
    public async Task GlobalSetup()
    {
        _playwright = await Playwright.CreateAsync();
        _browser = await _playwright.Chromium.LaunchAsync(
            new BrowserTypeLaunchOptions { Headless = false });
    }

    [SetUp]
    public async Task Setup()
    {
        var context = await _browser.NewContextAsync();
        _page = await context.NewPageAsync();
    }

    [Test]
    public async Task TestLoginPage()
    {
        var login = new loginPage(_page);
        await login.launchApp();
        await _page.WaitForTimeoutAsync(5000); 
    }

    [OneTimeTearDown]
    public async Task Cleanup()
    {
        await _browser.CloseAsync();
    }
}