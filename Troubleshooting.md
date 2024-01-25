# Troubleshooting problems with the Millionaire Game

## Index

## Installing & Starting up
### Error: Network-related or instance-specific error in connecting to SQL Server
![SQL_Error_NRIS](https://github.com/Macronair/TheMillionaireGame/assets/43847273/33edb35a-aa8d-463f-b73b-7810dba4cb85)

When you get the error above (see screenshot), it means that no connection could be made with the SQL server or no valid SQL Server is found on the machine.

**Solution:**
> For the program to run, you must have Microsoft SQL Server LocalDB installed on your PC.
>
> You can install this using the included installer in the .zip folder, or you can find it in the README.md page/file from this repo.

### Service 'SQL Server VSS Failed to start' error when installing SQL LocalDB
![VSSService](https://github.com/Macronair/TheMillionaireGame/assets/43847273/5eeeef8e-5f2e-4780-bd28-f9e810bc54a6)

This error message from the installer of SQL LocalDB means that you probably don't have Visual C++ Redistributable packages installed.

**Solution:**
> You can find and download the packages [here](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)!

## The end
More is coming...
