using Middle.Config.Core;
using Middle.Pages;

namespace Middle.Steps
{
    public class HomeSteps
    {
        private HomePage homePage = new HomePage();

        public void NavigateToJobPayGrades()
        {
            DriverHolder.Driver.FindElement(homePage.SideBarAdminBlock).Click();
            DriverHolder.Driver.FindElement(homePage.JobDropDown).Click();
            DriverHolder.Driver.FindElement(homePage.PayGradesDropDownValue).Click();

        }
    }
}
