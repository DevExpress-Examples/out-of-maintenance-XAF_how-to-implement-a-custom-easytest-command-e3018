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


