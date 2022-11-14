# log4net_practise

  Created this project to demo the log4net in console application.
  
  Step 1: Started Visual Studio 2022 and selected the console Application with .Net Core 3.1.
        ![image](https://user-images.githubusercontent.com/1579649/201664702-ad008c3e-3b82-46c7-adc7-fddfc36b3f0c.png)

  Step 2: Add log4net dll from Nuget Manager.
        ![image](https://user-images.githubusercontent.com/1579649/201664802-bb1af1eb-989b-4385-b104-b72345f71793.png)

  Step 3: Adding log4net config in App.config file.
        Challenge: unable to find Config file in Add new item panel        
        ![image](https://user-images.githubusercontent.com/1579649/201665133-c1c6879a-1841-48df-9422-f3c9aaf2efd8.png)
        Resolution: Go to Tools ==> Get Tools and Feature ==> Make sure ".Net desktop development" is checked and proceed with installation.
        ![image](https://user-images.githubusercontent.com/1579649/201665342-273a6c63-85a9-4be2-89f3-8102274c74d2.png)
        After installation
        ![image](https://user-images.githubusercontent.com/1579649/201665912-39eb1d9b-d05e-4d2f-a85b-fdce0812ef65.png)

  Step 4: Adding log4net watch in AssemblyInfo.cs file.
        Challenge: AssemblyInfo.cs file is missing in project files.
        ![image](https://user-images.githubusercontent.com/1579649/201666693-e69e71af-a838-4112-8bcd-ad0d3ba50ca8.png)
        Resolution: Goto .csproj file and add GenerateAssemblyInfo and GeneratedAssemblyInfoFile
        ![image](https://user-images.githubusercontent.com/1579649/201667256-e8770fcb-51c9-49b0-94b2-fe3c31a122ff.png)
        Once added build the project you will get Assemblyinfo.cs file.
        ![image](https://user-images.githubusercontent.com/1579649/201667840-cddb0b05-0775-4704-a2df-eb1748900294.png)
        Now edit the .csproj file to remove the settings GeneratedAssemblyInfoFile and GenerateAssemblyInfo to false
        Add the log4net watch in assemblyinfo.cs file
        ![image](https://user-images.githubusercontent.com/1579649/201669851-8d7f9645-2cc5-4606-bd64-89ef3a8759dd.png)
        ![image](https://user-images.githubusercontent.com/1579649/201668329-25a5070a-a739-457f-80ae-6a330287e176.png)

Step 5: Initialize the log4net and do some logging
        ![image](https://user-images.githubusercontent.com/1579649/201670104-8d69cdab-6140-4618-b0ef-cb0feef74182.png)

Final Result: 
        ![image](https://user-images.githubusercontent.com/1579649/201670164-ae8c8e6d-5598-4232-945c-de08da9246e8.png)

        
        
