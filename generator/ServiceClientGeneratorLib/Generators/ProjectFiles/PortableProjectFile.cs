﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.ProjectFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using ServiceClientGenerator;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class PortableProjectFile : PortableProjectFileBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write(@"<?xml version=""1.0"" encoding=""utf-8""?>
<Project ToolsVersion=""12.0"" DefaultTargets=""Build"" xmlns=""http://schemas.microsoft.com/developer/msbuild/2003"">
  <Import Project=""$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props"" Condition=""Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')"" />
  <PropertyGroup>
    <MinimumVisualStudioVersion>12.0</MinimumVisualStudioVersion>
    <Configuration Condition="" '$(Configuration)' == '' "">Debug</Configuration>
    <Platform Condition="" '$(Platform)' == '' "">AnyCPU</Platform>
    <ProjectGuid>");
            
            #line 14 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["ProjectGuid"]));
            
            #line default
            #line hidden
            this.Write("</ProjectGuid>\r\n    <OutputType>Library</OutputType>\r\n    <AppDesignerFolder>Prop" +
                    "erties</AppDesignerFolder>\r\n    <RootNamespace>");
            
            #line 17 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["RootNamespace"]));
            
            #line default
            #line hidden
            this.Write("</RootNamespace>\r\n    <AssemblyName>");
            
            #line 18 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["AssemblyName"]));
            
            #line default
            #line hidden
            this.Write(@"</AssemblyName>
    <DefaultLanguage>en-US</DefaultLanguage>
    <FileAlignment>512</FileAlignment>
    <ProjectTypeGuids>{786C830F-07A1-408B-BD7F-6EE04809D6DB};{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}</ProjectTypeGuids>
    <TargetFrameworkProfile>Profile157</TargetFrameworkProfile>
    <TargetFrameworkVersion>v4.6</TargetFrameworkVersion>
    <SolutionDir Condition=""$(SolutionDir) == '' Or $(SolutionDir) == '*Undefined*'"">.\</SolutionDir>
    <RestorePackages>true</RestorePackages>
    <BaseIntermediateOutputPath>obj\");
            
            #line 26 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write(@"</BaseIntermediateOutputPath>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' "">
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\");
            
            #line 32 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>DEBUG;TRACE;");
            
            #line 33 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write(@"</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <NoWarn>419,1591,1573</NoWarn>
  </PropertyGroup>
  <PropertyGroup Condition="" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' "">
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\");
            
            #line 41 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["BinSubfolder"]));
            
            #line default
            #line hidden
            this.Write("</OutputPath>\r\n    <DefineConstants>TRACE;");
            
            #line 42 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["DefineConstants"]));
            
            #line default
            #line hidden
            this.Write(@"</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
    <NoWarn>419,1591,1573</NoWarn>
  </PropertyGroup>
  <ItemGroup>
    <!-- A reference to the entire .NET Framework is automatically included -->
    <TargetPlatform Include=""Windows Phone, Version=8.1"" />
    <TargetPlatform Include=""Windows, Version=8.1"" />
    <TargetPlatform Include=""WindowsPhoneApp, Version=8.1"" />
  </ItemGroup>
  <ItemGroup>
");
            
            #line 54 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

    foreach(string subDirectory in ((IList<string>)this.Session["SourceDirectories"]))
    {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 58 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(subDirectory));
            
            #line default
            #line hidden
            this.Write("\\*.cs\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 61 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n  <ItemGroup>\r\n");
            
            #line 66 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

    if(this.Session.ContainsKey("IndividualFileIncludes"))
    {
        foreach(string file in ((IList<string>)this.Session["IndividualFileIncludes"]))
        {
            if(file.EndsWith(".cs"))
            {

            
            #line default
            #line hidden
            this.Write("    <Compile Include=\"");
            
            #line 74 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Code</SubType>\r\n    </Compile>\r\n");
            
            #line 77 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

            }
            else
            {

            
            #line default
            #line hidden
            this.Write("    <EmbeddedResource Include=\"");
            
            #line 82 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(file));
            
            #line default
            #line hidden
            this.Write("\">\r\n      <SubType>Designer</SubType>\r\n    </EmbeddedResource>\r\n");
            
            #line 85 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

            }
        }
    }

            
            #line default
            #line hidden
            this.Write("  </ItemGroup>\r\n");
            
            #line 91 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

    if(this.Session.ContainsKey("ProjectReferences"))
    {
        foreach(var projectReferences in (List<ProjectFileCreator.ProjectReference>)this.Session["ProjectReferences"])
        {

            
            #line default
            #line hidden
            this.Write("  <ItemGroup>\r\n    <ProjectReference Include=\"");
            
            #line 98 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.IncludePath));
            
            #line default
            #line hidden
            this.Write("\">\r\n        <Project>");
            
            #line 99 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.ProjectGuid));
            
            #line default
            #line hidden
            this.Write("</Project>\r\n        <Name>");
            
            #line 100 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(projectReferences.Name));
            
            #line default
            #line hidden
            this.Write("</Name>\r\n    </ProjectReference>\r\n  </ItemGroup>\r\n");
            
            #line 103 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write(@"  <ItemGroup>
    <Compile Include=""Properties\AssemblyInfo.cs"" />
  </ItemGroup>
  <ItemGroup>
    <Service Include=""{508349B6-6B84-4DF5-91F0-309BEEBAD82D}"" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include=""System"" />
    <Reference Include=""System.Core"" />
    <Reference Include=""System.Xml.Linq"" />
    <Reference Include=""System.Xml"" />
    <Reference Include=""System.Net.Http"">
      <HintPath>");
            
            #line 119 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("Microsoft.Net.Http.2.2.28\\lib\\portable-net40+sl4+win8+wp71+wpa81\\System.Net.Http." +
                    "dll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Net.Http.Extens" +
                    "ions\">\r\n      <HintPath>");
            
            #line 122 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("Microsoft.Net.Http.2.2.28\\lib\\portable-net40+sl4+win8+wp71+wpa81\\System.Net.Http." +
                    "Extensions.dll</HintPath>\r\n    </Reference>\r\n    <Reference Include=\"System.Net." +
                    "Http.Primitives\">\r\n      <HintPath>");
            
            #line 125 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write(@"Microsoft.Net.Http.2.2.28\lib\portable-net40+sl4+win8+wp71+wpa81\System.Net.Http.Primitives.dll</HintPath>
    </Reference>
  </ItemGroup>
  <Import Project=""$(MSBuildExtensionsPath32)\Microsoft\Portable\$(TargetFrameworkVersion)\Microsoft.Portable.CSharp.targets"" />
  <Import Condition=""Exists('$(MSBuildExtensionsPath)\Microsoft\VisualStudio\TextTemplating\v10.0\Microsoft.TextTemplating.targets')"" Project=""$(MSBuildExtensionsPath)\Microsoft\VisualStudio\TextTemplating\v10.0\Microsoft.TextTemplating.targets"" />
  <Import Project=""");
            
            #line 130 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("Microsoft.Bcl.Build.1.0.14\\tools\\Microsoft.Bcl.Build.targets\" Condition=\"Exists(\'" +
                    "");
            
            #line 130 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write("Microsoft.Bcl.Build.1.0.14\\tools\\Microsoft.Bcl.Build.targets\')\" />\r\n  <Target Nam" +
                    "e=\"EnsureBclBuildImported\" BeforeTargets=\"BeforeBuild\" Condition=\"\'$(BclBuildImp" +
                    "orted)\' == \'\'\">\r\n    <Error Condition=\"!Exists(\'");
            
            #line 132 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write(@"Microsoft.Bcl.Build.1.0.14\tools\Microsoft.Bcl.Build.targets')"" Text=""This project references NuGet package(s) that are missing on this computer. Enable NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=317567."" HelpKeyword=""BCLBUILD2001"" />
    <Error Condition=""Exists('");
            
            #line 133 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\ProjectFiles\PortableProjectFile.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Session["NugetPackagesLocation"]));
            
            #line default
            #line hidden
            this.Write(@"Microsoft.Bcl.Build.1.0.14\tools\Microsoft.Bcl.Build.targets')"" Text=""The build restored NuGet packages. Build the project again to include these packages in the build. For more information, see http://go.microsoft.com/fwlink/?LinkID=317568."" HelpKeyword=""BCLBUILD2002"" />
  </Target>
  <Import Project=""$(SolutionDir)\.nuget\NuGet.targets"" Condition=""Exists('$(SolutionDir)\.nuget\NuGet.targets')"" />
  <Target Name=""EnsureNuGetPackageBuildImports"" BeforeTargets=""PrepareForBuild"">
    <PropertyGroup>
      <ErrorText>This project references NuGet package(s) that are missing on this computer. Enable NuGet Package Restore to download them.  For more information, see http://go.microsoft.com/fwlink/?LinkID=322105. The missing file is {0}.</ErrorText>
    </PropertyGroup>
    <Error Condition=""!Exists('$(SolutionDir)\.nuget\NuGet.targets')"" Text=""$([System.String]::Format('$(ErrorText)', '$(SolutionDir)\.nuget\NuGet.targets'))"" />
  </Target>
  <!-- To modify your build process, add your task inside one of the targets below and uncomment it. 
       Other similar extension points exist, see Microsoft.Common.targets.
  <Target Name=""BeforeBuild"">
  </Target>
  <Target Name=""AfterBuild"">
  </Target>
  -->
</Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class PortableProjectFileBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
