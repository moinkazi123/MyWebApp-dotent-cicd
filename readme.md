Hi there!
# .NET Web App AWS Pipeline Project

This project demonstrates a simple .NET web application with AWS CodePipeline integration for continuous deployment to a Windows EC2 instance.

## Project Structure

```
MyWebApp/
│
├── src/
│   ├── Program.cs
│   └── MyWebApp.csproj
│
├── scripts/
│   ├── stop_website.ps1
│   └── start_website.ps1
│
├── .gitignore
├── appspec.yml
├── buildspec.yml
└── README.md
```

## Prerequisites

- .NET 6.0 SDK or later
- AWS account with EC2, CodePipeline, CodeBuild, and CodeDeploy set up
- Git

## Local Development

1. Clone the repository
2. Navigate to the `src` directory
3. Run `dotnet restore`
4. Run `dotnet run`
5. Open a browser and go to `http://localhost:5000`

## Deployment

This project uses AWS CodePipeline for continuous deployment:

1. Push changes to your Git repository
2. CodePipeline will automatically:
   - Build the application using `buildspec.yml`
   - Deploy to EC2 using `appspec.yml` and the scripts in the `scripts/` directory

## Configuration Files

- `appspec.yml`: Defines the deployment process for CodeDeploy
- `buildspec.yml`: Defines the build process for CodeBuild
- `scripts/`: Contains PowerShell scripts for stopping and starting the IIS website
