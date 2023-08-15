# UmbracoCMSSendMail
Sending mail without UmbracoForms from a Umbraco CMS application

how to run:
  1. git clone https://github.com/asqrzk/UmbracoCMSSendMail.git
  2. cd UmbracoCMSSendMail
  3. dotnet restore
  4. dotnet build
  5. dotnet run

prime points:
  1. The solution has a partial view being implemented and rendered at https://github.com/asqrzk/UmbracoCMSSendMail/blob/cf62af11acc8ee1c6906c661c54e363f8707b78a/Views/HomePage.cshtml#L31
  2. The solution has a content component being implemented and rendered at
https://github.com/asqrzk/UmbracoCMSSendMail/blob/cf62af11acc8ee1c6906c661c54e363f8707b78a/Views/HomePage.cshtml#L27C44-L27C69
  3. The solution uses a SurfaceController for business logic at https://github.com/asqrzk/UmbracoCMSSendMail/blob/cf62af11acc8ee1c6906c661c54e363f8707b78a/Controllers/HomePageController.cs#L36
  4. The solution uses MVC form to route to the SurfaceRoute action at https://github.com/asqrzk/UmbracoCMSSendMail/blob/cf62af11acc8ee1c6906c661c54e363f8707b78a/Views/HomePage.cshtml#L58
