﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 12.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace ServiceClientGenerator.Generators.SourceFiles
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class BaseServiceException : BaseGenerator
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 6 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"

	AddLicenseHeader();

            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Collections.Generic;\r\nusing System.Net;\r\nusing System" +
                    ".Text;\r\n\r\nusing Amazon.Runtime;\r\n\r\nnamespace ");
            
            #line 16 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.Namespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n    public class Amazon");
            
            #line 18 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Exception : AmazonServiceException\r\n    {\r\n        public Amazon");
            
            #line 20 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Exception(string message)\r\n            : base(message)\r\n        {\r\n        }\r\n\r\n " +
                    "       public Amazon");
            
            #line 25 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Exception(string message, Exception innerException)\r\n            : base(message, " +
                    "innerException)\r\n        {\r\n        }\r\n\r\n        public Amazon");
            
            #line 30 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Exception(Exception innerException)\r\n            : base(innerException.Message, i" +
                    "nnerException)\r\n        {\r\n        }\r\n\r\n        public Amazon");
            
            #line 35 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write("Exception(string message, ErrorType errorType, string errorCode, string requestId" +
                    ", HttpStatusCode statusCode)\r\n            : base(message, errorType, errorCode, " +
                    "requestId, statusCode)\r\n        {\r\n        }\r\n\r\n        public Amazon");
            
            #line 40 "C:\Dev\AWS\GitFarm\AWSDotNetSDKAndTools\Modularization\sdkv3\generator\ServiceClientGeneratorLib\Generators\SourceFiles\BaseServiceException.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(this.Config.BaseName));
            
            #line default
            #line hidden
            this.Write(@"Exception(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode)
            : base(message, innerException, errorType, errorCode, requestId, statusCode)
        {
        }
    }
}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
