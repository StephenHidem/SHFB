//===============================================================================================================
// System  : Sandcastle Help File Builder MSBuild Tasks
// File    : AssemblyInfoShared.cs
// Author  : Eric Woodruff  (Eric@EWoodruff.us)
// Updated : 07/28/2025
// Note    : Copyright 2006-2025, Eric Woodruff, All rights reserved
//
// Sandcastle Help File Builder common assembly attributes.
//
// This code is published under the Microsoft Public License (Ms-PL).  A copy of the license should be
// distributed with the code and can be found at the project website: https://GitHub.com/EWSoftware/SHFB.  This
// notice, the author's name, and all copyright notices must remain intact in all applications, documentation,
// and source files.
//
//    Date     Who  Comments
// ==============================================================================================================
// 08/02/2006  EFW  Created the code
//===============================================================================================================

using System;
using System.Reflection;
using System.Runtime.InteropServices;

// NOTE: See AssemblyInfo.cs and/or the project file for project-specific assembly attributes

// General assembly information
[assembly: AssemblyCompany("Eric Woodruff")]
[assembly: AssemblyCopyright(AssemblyInfo.Copyright)]

// Not visible to COM
[assembly: ComVisible(false)]

#if NOT_CLS_COMPLIANT
[assembly: CLSCompliant(false)]
#else
[assembly: CLSCompliant(true)]
#endif

// Version numbers.  See comments below.

// Certain assemblies may contain a specific version to maintain binary compatibility with a prior release
#if !ASSEMBLYSPECIFICVERSION
[assembly: AssemblyVersion(AssemblyInfo.StrongNameVersion)]
#endif

[assembly: AssemblyFileVersion(AssemblyInfo.FileVersion)]
[assembly: AssemblyInformationalVersion(AssemblyInfo.ProductVersion)]

// This defines constants that can be used by plug-ins and components in their metadata.
//
// All version numbers for an assembly consists of the following four values:
//
//      Year of release
//      Month of release
//      Day of release
//      Revision (typically zero unless multiple releases are made on the same day)
//
// This versioning scheme allows build component and plug-in developers to use the same major, minor, and build
// numbers as the Sandcastle tools to indicate with which version their components are compatible.
//
internal static partial class AssemblyInfo
{
    // Common assembly strong name version - DO NOT CHANGE UNLESS NECESSARY.
    //
    // This is used to set the assembly version in the strong name.  This should remain unchanged to maintain
    // binary compatibility with prior releases.  It should only be changed if a breaking change is made that
    // requires assemblies that reference older versions to be recompiled against the newer version.
    //
    // If this changes, update the version in the SandcastleCore copy as well.
    public const string StrongNameVersion = "2025.7.9.0";

    // Common assembly file version
    //
    // This is used to set the assembly file version.  This will change with each new release.  MSIs only
    // support a Major value between 0 and 255 so we drop the century from the year on this one.
    public const string FileVersion = "25.7.9.0";

    // Common product version
    //
    // This may contain additional text to indicate Alpha or Beta states.  The version number will always match
    // the file version above but includes the century on the year.
    public const string ProductVersion = "2025.7.9.0";

    // Assembly copyright information
    public const string Copyright = "Copyright \xA9 2006-2025, Eric Woodruff, All Rights Reserved";
}
