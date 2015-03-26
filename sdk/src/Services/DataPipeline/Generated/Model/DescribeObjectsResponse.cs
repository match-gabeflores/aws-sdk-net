/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the datapipeline-2012-10-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DataPipeline.Model
{
    /// <summary>
    /// If <code>True</code>, there are more results that can be returned in another call
    /// to <a>DescribeObjects</a>.
    /// </summary>
    public partial class DescribeObjectsResponse : AmazonWebServiceResponse
    {
        private bool? _hasMoreResults;
        private string _marker;
        private List<PipelineObject> _pipelineObjects = new List<PipelineObject>();

        /// <summary>
        /// Gets and sets the property HasMoreResults. 
        /// <para>
        /// If <code>True</code>, there are more pages of results to return.
        /// </para>
        /// </summary>
        public bool HasMoreResults
        {
            get { return this._hasMoreResults.GetValueOrDefault(); }
            set { this._hasMoreResults = value; }
        }

        // Check to see if HasMoreResults property is set
        internal bool IsSetHasMoreResults()
        {
            return this._hasMoreResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  The starting point for the next page of results. To view the next page of results,
        /// call <a>DescribeObjects</a> again with this marker value. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineObjects. 
        /// <para>
        /// An array of object definitions that are returned by the call to <a>DescribeObjects</a>.
        /// </para>
        /// </summary>
        public List<PipelineObject> PipelineObjects
        {
            get { return this._pipelineObjects; }
            set { this._pipelineObjects = value; }
        }

        // Check to see if PipelineObjects property is set
        internal bool IsSetPipelineObjects()
        {
            return this._pipelineObjects != null && this._pipelineObjects.Count > 0; 
        }

    }
}