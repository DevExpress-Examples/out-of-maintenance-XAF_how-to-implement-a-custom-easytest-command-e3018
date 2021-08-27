<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128591047/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3018)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [FillDateTimeValueCommand.cs](./CS/AdditionalCommands/FillDateTimeValueCommand.cs) (VB: [FillDateTimeValueCommand.vb](./VB/AdditionalCommands/FillDateTimeValueCommand.vb))
* [Config.xml](./CS/EasyTests/Config.xml) (VB: [Config.xml](./VB/EasyTests/Config.xml))
* [Sample.ets](./CS/EasyTests/Sample.ets) (VB: [Sample.ets](./VB/EasyTests/Sample.ets))
* [ExtendedWebAdapter.cs](./CS/ExtendedWebAdapter/ExtendedWebAdapter.cs) (VB: [ExtendedWebAdapter.vb](./VB/ExtendedWebAdapter/ExtendedWebAdapter.vb))
* [AssemblyInfo.cs](./CS/ExtendedWebAdapter/Properties/AssemblyInfo.cs)
* [ExtendedWinAdapter.cs](./CS/ExtendedWinAdapter/ExtendedWinAdapter.cs) (VB: [ExtendedWinAdapter.vb](./VB/ExtendedWinAdapter/ExtendedWinAdapter.vb))
* [AssemblyInfo.cs](./CS/ExtendedWinAdapter/Properties/AssemblyInfo.cs)
<!-- default file list end -->
# How to implement a custom EasyTest command


<p>In this example, we demonstrated how to implement a custom FillDateValue command that can be used in your EasyTest scripts as follows:<br />
*FillDateValue FieldName<br />
Culture = en-US<br />
Days = +1<br />
Hours = +5<br />
Minutes = -2  <br />
This command sets the current date into the FieldName field. The Days, Hours, Minutes parameters specify the corresponding time differences.<br />
The Culture parameter specifies the culture in which the current application is working.</p><p>Our custom command was added by extending the Windows Forms and Web versions of EasyTest adapters. You can see it if you open the code of corresponding projects.</p><p>To test this example, do the following:<br />
1. Open a solution in Visual Studio;<br />
2. Modify the SolutionPath alias in the EasyTests\Config.xml file to point to the current solution folder;<br />
3. Set the current solution configuration to EasyTest;<br />
4. Open the \EasyTests\Sampe.ets file in the code editor and run it, or use the respective context menu option.</p><p><strong>See also:</strong><strong><br />
</strong><a href="http://community.devexpress.com/blogs/eaf/archive/2011/04/26/how-to-create-a-custom-easytest-command.aspx"><strong><u>How to implement a custom EasyTest command (blog)</u></strong></a><strong> </strong></p>

<br/>


