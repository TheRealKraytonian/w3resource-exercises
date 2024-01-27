$rootFolder = "C:\Users\billionaire\Documents\Projects\w3resource-exercises"  # Replace with the actual root folder path
$readmeContent = "# This is a readme file"  # Replace with your desired readme content

Get-ChildItem -Path $rootFolder -Directory -Recurse | ForEach-Object {
  $readmePath = Join-Path $_.FullName "readme.md"
  if (!(Test-Path $readmePath)) {
    New-Item -Path $readmePath -ItemType File -Force
    Set-Content -Path $readmePath -Value $readmeContent
  }
}

