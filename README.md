# VintaSoft WinForms Multi Camera Demo

This C# project uses <a href="https://www.vintasoft.com/vsimaging-dotnet-index.html">VintaSoft Imaging .NET SDK</a> and demonstrates how to work with multiple DirectX cameras in WinForms:
* Capture images from multiple DirectX cameras
* Change capturing format of capture device
* Monitor available image capture devices (webcams)
* Capture image from camera and save to a file


## Screenshot
<img src="vintasoft-multi-camera-demo.png" title="VintaSoft Multi Camera Demo">


## Usage
1. Get the 30 day free evaluation license for <a href="https://www.vintasoft.com/vsimaging-dotnet-index.html" target="_blank">VintaSoft Imaging .NET SDK</a> as described here: <a href="https://www.vintasoft.com/docs/vsimaging-dotnet/Licensing-Evaluation.html" target="_blank">https://www.vintasoft.com/docs/vsimaging-dotnet/Licensing-Evaluation.html</a>

2. Update the evaluation license in "CSharp\MainForm.cs" file:
   ```
   Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");
   ```

3. Build the project ("MultiCameraDemo.Net8.csproj" file) in Visual Studio or using .NET CLI:
   ```
   dotnet build MultiCameraDemo.Net8.csproj
   ```

4. Run compiled application and try to work with multiple DirectX cameras.


## Documentation
VintaSoft Imaging .NET SDK on-line User Guide and API Reference for .NET developer is available here: https://www.vintasoft.com/docs/vsimaging-dotnet/


## Support
Please visit our <a href="https://myaccount.vintasoft.com/">online support center</a> if you have any question or problem.
