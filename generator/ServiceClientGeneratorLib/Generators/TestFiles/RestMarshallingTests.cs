﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.TestFiles
{
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class RestMarshallingTests : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.IO;\r\nusing System.Text;\r\nusing Microsoft.VisualSt" +
                    "udio.TestTools.UnitTesting;\r\n\r\nusing ");
            
            #line 17 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 18 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 19 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(@".Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;
using ServiceClientGenerator;

using AWSSDK_DotNet35.UnitTests.TestTools;

namespace AWSSDK_DotNet35.UnitTests.Marshalling
{
    [TestClass]
    public partial class ");
            
            #line 29 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("MarshallingTests\r\n    {\r\n        static readonly ServiceModel service_model = Uti" +
                    "ls.LoadServiceModel(\"");
            
            #line 31 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.GetFileName(this.Config.ModelPath)));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 31 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.CustomizationsPath == null ? "" : Path.GetFileName(this.Config.CustomizationsPath)));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t");
            
            #line 32 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
		
            
            #line default
            #line hidden
            this.Write("\r\n        [TestMethod]\r\n\t\t[TestCategory(\"UnitTest\")]\r\n\t\t[TestCategory(\"");
            
            #line 39 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.ServiceModel.Type));
            
            #line default
            #line hidden
            this.Write("\")]\r\n\t\t[TestCategory(\"");
            
            #line 40 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 41 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n\t\t\tvar operation = service_model.FindOperation(\"");
            
            #line 43 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\");\r\n\r\n            var request = InstantiateClassGenerator.Execute<");
            
            #line 45 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 46 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n\r\n            var internalRequest = marshaller.Marshall(req" +
                    "uest);\r\n            RequestValidator.Validate(\"");
            
            #line 49 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("\", request, internalRequest, service_model);\t\t\t\r\n\r\n");
            
            #line 51 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

            if(operation.ResponseStructure != null)
            {

            
            #line default
            #line hidden
            this.Write("\t\t\tvar webResponse = new WebResponseData\r\n\t\t\t{\r\n\t\t\t\tHeaders = {\r\n");
            
            #line 58 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

if( operation.ResponseHeaderMembers.Count() > 0 )
		{
			foreach (var member in operation.ResponseHeaderMembers)
			{

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t{\"");
            
            #line 64 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));
            
            #line default
            #line hidden
            this.Write("\",\"");
            
            #line 64 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(member.MarshallLocationName));
            
            #line default
            #line hidden
            this.Write("_Value\"},\r\n");
            
            #line 65 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
	
			}
		}				

            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t{\"x-amzn-RequestId\", Guid.NewGuid().ToString()},\r\n\t\t\t\t\t{\"x-amz-crc32\",\"0\"}\r\n" +
                    "\t\t\t\t}\r\n\t\t\t};\r\n");
            
            #line 72 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

				if(this.Config.ServiceModel.Type == ServiceType.Rest_Xml)
				{

            
            #line default
            #line hidden
            this.Write(@"			
            var payloadResponse = new XmlSampleGenerator(service_model, operation).Execute();			
            var context = new XmlUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
			ResponseUnmarshaller unmarshaller = ");
            
            #line 79 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance;\r\n            var response = unmarshaller.Unmarshal" +
                    "l(context)\r\n\t\t\t\tas ");
            
            #line 81 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response;   \r\n            InstantiateClassGenerator.ValidateObjectFullyInstantiat" +
                    "ed(response);       \r\n");
            
            #line 83 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

				}
				else
				{

            
            #line default
            #line hidden
            this.Write(@"
            var payloadResponse = new JsonSampleGenerator(service_model, operation.ResponseStructure).Execute();
			webResponse.Headers.Add(""Content-Length"", UTF8Encoding.UTF8.GetBytes(payloadResponse).Length.ToString());
            var context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, webResponse);
			ResponseUnmarshaller unmarshaller = ");
            
            #line 92 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance;\r\n            var response = unmarshaller.Unmarshal" +
                    "l(context)\r\n\t\t\t\tas ");
            
            #line 94 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response;   \r\n            InstantiateClassGenerator.ValidateObjectFullyInstantiat" +
                    "ed(response);   \t\t\t\r\n");
            
            #line 96 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"
				
				}
            }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n\t\t");
            
            #line 102 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\RestMarshallingTests.tt"

		}
		
            
            #line default
            #line hidden
            this.Write("    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
