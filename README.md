Project Overview
The Texas DPS Appointment Automation project is a console application built using .NET Core and Selenium WebDriver to automate the process of scheduling a new appointment for a Texas Driver's License or Permit. It opens a web browser, navigates through the Texas DPS scheduling website, fills out the necessary forms with pre-specified user data, selects the earliest available appointment, and confirms the booking. Finally, the project saves a PDF copy of the appointment confirmation.

Features
Opens the Texas DPS scheduling website.
Fills out a form with user data automatically.
Navigates through the appointment scheduling process.
Selects the earliest available appointment if it is earlier than the existing one.
Confirms and saves the appointment confirmation as a PDF.
Prerequisites
Before running this project, ensure you have the following installed on your machine:

.NET Core SDK - Install the latest version from here.
Google Chrome Browser - Ensure Google Chrome is installed for automation.
Chrome WebDriver - Install the Chrome WebDriver compatible with your version of Chrome.
Setup Instructions
1. Clone the repository
bash
Copy code
git clone https://github.com/your-repo/texas-dps-appointment-automation.git
cd texas-dps-appointment-automation
2. Install Dependencies
Navigate to your project folder and run the following commands to install the required NuGet packages:

bash
Copy code
dotnet add package Selenium.WebDriver
dotnet add package Selenium.WebDriver.ChromeDriver
dotnet add package Microsoft.Extensions.Configuration
dotnet add package Microsoft.Extensions.Configuration.Json
3. AppSettings Configuration
Create an appsettings.json file in the root directory of the project with the following content:

json
Copy code
{
  "FormData": {
    "TexasCardNumber": "1234567890",
    "FirstName": "Jiten",
    "LastName": "Khatri",
    "DateOfBirth": "05/04/2002",
    "LastFourSSN": "1234",
    "Email": "jitenkhatri81@gmail.com",
    "ZipCode": "75093",
    "ExistingAppointmentDate": "01/21/2025"
  }
}
Important: Replace the placeholder values with your actual data.

4. Running the Application
Once everything is set up, you can run the application with the following command:

bash
Copy code
dotnet run
This will initiate the Chrome browser and automatically fill the forms, check available appointment dates, and book the earliest one.

