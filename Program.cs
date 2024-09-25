// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

Console.WriteLine("Hello, World!");

ScheduleAppointment();

void ScheduleAppointment()
{
    var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppointmentDetails.json")
            .Build();
    var formData = configuration.GetSection("FormData");
    IWebDriver driver = new ChromeDriver();

    driver.Navigate().GoToUrl("https://public.txdpsscheduler.com/");

    driver.FindElement(By.XPath("//span[text()='English']")).Click();

    driver.FindElement(By.XPath("//label[text()='Texas Card Number (DL, ID, EIC)']/following-sibling::input")).SendKeys(formData["TexasCardNumber"]);
    driver.FindElement(By.XPath("//label[text()='First Name']/following-sibling::input")).SendKeys(formData["FirstName"]);
    driver.FindElement(By.XPath("//label[text()='Last Name']/following-sibling::input")).SendKeys(formData["LastName"]);
    driver.FindElement(By.XPath("//label[text()='Date of Birth (mm/dd/yyyy)']/following-sibling::input")).SendKeys(formData["DateOfBirth"]);
    driver.FindElement(By.XPath("//label[text()='Last four of SSN']/following-sibling::input")).SendKeys(formData["LastFourSSN"]);
    driver.FindElement(By.XPath("//span[text()='Log On']")).Click();

    driver.FindElement(By.XPath("//span[text()='New Appointment']")).Click();

    driver.FindElement(By.XPath("//span[text()='Apply for first time Texas DL/Permit']")).Click();


    driver.FindElement(By.XPath("//label[text()='Email']/following-sibling::input")).SendKeys(formData["Email"]);
    driver.FindElement(By.XPath("//label[text()='Verify Email']/following-sibling::input")).SendKeys(formData["Email"]);
    driver.FindElement(By.XPath("//label[contains(text(), 'I prefer to receive notifications via text message')]/preceding-sibling::input")).Click();
    driver.FindElement(By.XPath("//label[text()='Email']/following-sibling::input")).SendKeys(formData["ZipCode"]);
}