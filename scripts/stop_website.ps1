Import-Module WebAdministration
Stop-Website -Name "Default Web Site"
Remove-Item -Recurse -Force C:\inetpub\wwwroot\MyWebApp -ErrorAction SilentlyContinue
