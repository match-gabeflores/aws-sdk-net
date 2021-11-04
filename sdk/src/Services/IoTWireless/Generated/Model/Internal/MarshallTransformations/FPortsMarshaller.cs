/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FPorts Marshaller
    /// </summary>       
    public class FPortsMarshaller : IRequestMarshaller<FPorts, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FPorts requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetClockSync())
            {
                context.Writer.WritePropertyName("ClockSync");
                context.Writer.Write(requestObject.ClockSync);
            }

            if(requestObject.IsSetFuota())
            {
                context.Writer.WritePropertyName("Fuota");
                context.Writer.Write(requestObject.Fuota);
            }

            if(requestObject.IsSetMulticast())
            {
                context.Writer.WritePropertyName("Multicast");
                context.Writer.Write(requestObject.Multicast);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static FPortsMarshaller Instance = new FPortsMarshaller();

    }
}