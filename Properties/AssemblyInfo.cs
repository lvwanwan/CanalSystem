using System.Reflection;
using System.Runtime.InteropServices;
using Rhino.PlugIns;

// Plug-in Description Attributes - all of these are optional
// These will show in Rhino's option dialog, in the tab Plug-ins
[assembly: PlugInDescription(DescriptionType.Address, "四川省成都市青羊区青华路22号")]
[assembly: PlugInDescription(DescriptionType.Country, "中华人民共和国")]
[assembly: PlugInDescription(DescriptionType.Email, "793145268@qq.com")]
[assembly: PlugInDescription(DescriptionType.Phone, "15195872328")]
[assembly: PlugInDescription(DescriptionType.Fax, "NO")]
[assembly: PlugInDescription(DescriptionType.Organization, "BIM中心 & 四川水发勘测设计研究有限公司")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl, "https://www.scswhi.com.cn/")]
[assembly: PlugInDescription(DescriptionType.WebSite, "https://www.scswhi.com.cn/")]
[assembly: PlugInDescription(DescriptionType.Icon, "Resources.lww")]

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("CanalSystem")] // Plug-In title is extracted from this
[assembly: AssemblyDescription("渠系设计系统 - CanalSystem")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("四川水发勘测设计研究有限公司")]
[assembly: AssemblyProduct("CanalSystem")]
[assembly: AssemblyCopyright("Copyright © 2022, 四川水发勘测设计研究有限公司")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(true)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b9b3c836-5b53-4f93-b359-e64bdf2a159b")] // This will also be the Guid of the Rhino plug-in

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.4")]
[assembly: AssemblyFileVersion("1.0.4.0")]
