using Microsoft.Playwright;

class createLaunchBrowser{

    IPlaywright playwright;
    IBrowser browser;
    IPage page;

    public async Task<IPage> createBrowser(){
        this.playwright = await Playwright.CreateAsync();
        this.browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
        {
            Headless = false
        });
        this.page = await this.browser.NewPageAsync();

        return this.page;
    }


}