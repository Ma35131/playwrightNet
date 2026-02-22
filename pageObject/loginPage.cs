using Microsoft.Playwright;

namespace PlaywrightTests.loginPage
{
class loginPage{

    private IPage page = null!;

   public loginPage(IPage page){
        this.page = page;
    }

    public async Task launchApp(){
        await this.page.GotoAsync("https://practicetestautomation.com/practice-test-login");
    }
}
}