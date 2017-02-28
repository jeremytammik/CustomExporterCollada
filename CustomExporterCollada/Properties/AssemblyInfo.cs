using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle( "CustomExporterCollada" )]
[assembly: AssemblyDescription( "Revit Add-In Description for CustomExporterCollada" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Autodesk Inc." )]
[assembly: AssemblyProduct( "CustomExporterCollada Revit C# .NET Add-In" )]
[assembly: AssemblyCopyright( "Copyright 2017 (C) Artur Brzegowy, Act-3D B.V. and Jeremy Tammik, Autodesk Inc." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

// Setting ComVisible to false makes the types in this assembly not visible
// to COM components.  If you need to access a type in this assembly from
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible( false )]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid( "321044f7-b0b2-4b1c-af18-e71a19252be0" )]

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
//
// 2017-02-28 2017.0.0.0 initial release based on http://thebuildingcoder.typepad.com/files/customexportercollada.zip and http://thebuildingcoder.typepad.com/blog/2013/07/graphics-pipeline-custom-exporter.html#5
// 2017-02-28 2017.0.0.1 workaround -- added exception handler around call to exporter.Export
//
[assembly: AssemblyVersion( "2017.0.0.1" )]
[assembly: AssemblyFileVersion( "2017.0.0.1" )]
