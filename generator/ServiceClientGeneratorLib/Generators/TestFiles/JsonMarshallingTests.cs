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
    
    #line 1 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class JsonMarshallingTests : Generators.BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 7 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("\r\n\r\nusing System;\r\nusing System.IO;\r\nusing System.Text;\r\nusing Microsoft.VisualSt" +
                    "udio.TestTools.UnitTesting;\r\n\r\nusing ");
            
            #line 17 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(";\r\nusing ");
            
            #line 18 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model;\r\nusing ");
            
            #line 19 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write(".Model.Internal.MarshallTransformations;\r\nusing Amazon.Runtime.Internal.Transform" +
                    ";\r\n\r\nusing ServiceClientGenerator;\r\n\r\nusing AWSSDK_DotNet35.UnitTests.TestTools;" +
                    "\r\n\r\nnamespace AWSSDK_DotNet35.UnitTests.Marshalling\r\n{\r\n    [TestClass]\r\n    pub" +
                    "lic class ");
            
            #line 29 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("MarshallingTests\r\n    {\r\n        static readonly ServiceModel service_model = Uti" +
                    "ls.LoadServiceModel(\"");
            
            #line 31 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Path.GetFileName(this.Config.ModelPath)));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 31 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.CustomizationsPath == null ? "" : Path.GetFileName(this.Config.CustomizationsPath)));
            
            #line default
            #line hidden
            this.Write("\");\r\n\t\t");
            
            #line 32 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

		foreach(var operation in this.Config.ServiceModel.Operations)
		{
		
            
            #line default
            #line hidden
            this.Write("\r\n        [TestMethod]\r\n\t\t[TestCategory(\"UnitTest\")]\r\n\t\t[TestCategory(\"Json\")]\r\n\t" +
                    "\t[TestCategory(\"");
            
            #line 40 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("\")]\r\n        public void ");
            
            #line 41 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("MarshallTest()\r\n        {\r\n            var request = InstantiateClassGenerator.Ex" +
                    "ecute<");
            
            #line 43 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>();\r\n            var marshaller = new ");
            
            #line 44 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("RequestMarshaller();\r\n\r\n            var internalRequest = marshaller.Marshall(req" +
                    "uest);\r\n");
            
            #line 47 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            if(operation.RequestStructure != null)
            {

            
            #line default
            #line hidden
            this.Write("            var jsonRequest = UTF8Encoding.UTF8.GetString(internalRequest.Content" +
                    ");\t\t\t            \r\n\t\t\tComparer.CompareObjectToJson<");
            
            #line 52 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Request>(request,jsonRequest);\r\n\r\n");
            
            #line 54 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            }

            if(operation.ResponseStructure != null)
            {

            
            #line default
            #line hidden
            this.Write(@"			var webResponse = new WebResponseData
			{
				Headers = {
					{""x-amzn-RequestId"", Guid.NewGuid().ToString()},
					{""x-amz-crc32"",""0""}
				}
			};
            var jsonResponse = new JsonSampleGenerator(service_model, service_model.FindOperation(""");
            
            #line 67 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write(@""").ResponseStructure).Execute();
			webResponse.Headers.Add(""Content-Length"", UTF8Encoding.UTF8.GetBytes(jsonResponse).Length.ToString());
            UnmarshallerContext context = new JsonUnmarshallerContext(Utils.CreateStreamFromString(jsonResponse), false, webResponse);
            var response = ");
            
            #line 70 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("ResponseUnmarshaller.Instance.Unmarshall(context)\r\n\t\t\t\tas ");
            
            #line 71 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(operation.Name));
            
            #line default
            #line hidden
            this.Write("Response;\r\n\t\t\tInstantiateClassGenerator.ValidateObjectFullyInstantiated(response)" +
                    ";\r\n");
            
            #line 73 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

            }

            
            #line default
            #line hidden
            this.Write("        }\r\n\r\n\t\t");
            
            #line 78 "C:\codebase\GitBranches\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\TestFiles\JsonMarshallingTests.tt"

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
