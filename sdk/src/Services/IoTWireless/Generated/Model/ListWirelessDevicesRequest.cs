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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the ListWirelessDevices operation.
    /// Lists the wireless devices registered to your AWS account.
    /// </summary>
    public partial class ListWirelessDevicesRequest : AmazonIoTWirelessRequest
    {
        private string _destinationName;
        private string _deviceProfileId;
        private string _fuotaTaskId;
        private int? _maxResults;
        private string _multicastGroupId;
        private string _nextToken;
        private string _serviceProfileId;
        private WirelessDeviceType _wirelessDeviceType;

        /// <summary>
        /// Gets and sets the property DestinationName. 
        /// <para>
        /// A filter to list only the wireless devices that use this destination.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DestinationName
        {
            get { return this._destinationName; }
            set { this._destinationName = value; }
        }

        // Check to see if DestinationName property is set
        internal bool IsSetDestinationName()
        {
            return this._destinationName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceProfileId. 
        /// <para>
        /// A filter to list only the wireless devices that use this device profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string DeviceProfileId
        {
            get { return this._deviceProfileId; }
            set { this._deviceProfileId = value; }
        }

        // Check to see if DeviceProfileId property is set
        internal bool IsSetDeviceProfileId()
        {
            return this._deviceProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property FuotaTaskId.
        /// </summary>
        [AWSProperty(Max=256)]
        public string FuotaTaskId
        {
            get { return this._fuotaTaskId; }
            set { this._fuotaTaskId = value; }
        }

        // Check to see if FuotaTaskId property is set
        internal bool IsSetFuotaTaskId()
        {
            return this._fuotaTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MulticastGroupId.
        /// </summary>
        [AWSProperty(Max=256)]
        public string MulticastGroupId
        {
            get { return this._multicastGroupId; }
            set { this._multicastGroupId = value; }
        }

        // Check to see if MulticastGroupId property is set
        internal bool IsSetMulticastGroupId()
        {
            return this._multicastGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// To retrieve the next set of results, the <code>nextToken</code> value from a previous
        /// response; otherwise <b>null</b> to receive the first set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceProfileId. 
        /// <para>
        /// A filter to list only the wireless devices that use this service profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ServiceProfileId
        {
            get { return this._serviceProfileId; }
            set { this._serviceProfileId = value; }
        }

        // Check to see if ServiceProfileId property is set
        internal bool IsSetServiceProfileId()
        {
            return this._serviceProfileId != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDeviceType. 
        /// <para>
        /// A filter to list only the wireless devices that use this wireless device type.
        /// </para>
        /// </summary>
        public WirelessDeviceType WirelessDeviceType
        {
            get { return this._wirelessDeviceType; }
            set { this._wirelessDeviceType = value; }
        }

        // Check to see if WirelessDeviceType property is set
        internal bool IsSetWirelessDeviceType()
        {
            return this._wirelessDeviceType != null;
        }

    }
}