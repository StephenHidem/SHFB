using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

// General assembly information
[assembly: AssemblyCopyright(AssemblyInfo.Copyright)]

[assembly: ComVisible(false)]

[assembly: CLSCompliant(true)]

[assembly: AssemblyVersion(AssemblyInfo.ProductVersion)]
[assembly: AssemblyFileVersion(AssemblyInfo.ProductVersion)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.ProductVersion)]

// This defines constants that can be used here and in the custom presentation style export attribute
internal static partial class AssemblyInfo
{
    // Product version
    public const string ProductVersion = "1.0.0.0";

    // Assembly copyright information
    public const string Copyright = "Copyright \xA9 $year$, $username$, All Rights Reserved.";
}
