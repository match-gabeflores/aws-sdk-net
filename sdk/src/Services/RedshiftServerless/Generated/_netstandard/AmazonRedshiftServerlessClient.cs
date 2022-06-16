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
 * Do not modify this file. This file is generated from the redshiftserverless-2021-04-21.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.RedshiftServerless.Model;
using Amazon.RedshiftServerless.Model.Internal.MarshallTransformations;
using Amazon.RedshiftServerless.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.RedshiftServerless
{
    /// <summary>
    /// Implementation for accessing RedshiftServerless
    ///
    /// <i>This is prerelease documentation for Amazon Redshift Serverless, which is in preview
    /// release. The documentation and the feature are both subject to change. We recommend
    /// that you use this feature only in test environments, and not in production environments.
    /// For preview terms and conditions, see Beta Service Participation in <a href="https://docs.aws.amazon.com/https:/aws.amazon.com/service-terms">Amazon
    /// Web Services Service Terms</a>.</i> 
    /// 
    ///  
    /// <para>
    /// This is an interface reference for Amazon Redshift Serverless. It contains documentation
    /// for one of the programming or command line interfaces you can use to manage Amazon
    /// Redshift Serverless. 
    /// </para>
    ///  
    /// <para>
    /// Amazon Redshift Serverless automatically provisions data warehouse capacity and intelligently
    /// scales the underlying resources based on workload demands. Amazon Redshift Serverless
    /// adjusts capacity in seconds to deliver consistently high performance and simplified
    /// operations for even the most demanding and volatile workloads. Amazon Redshift Serverless
    /// lets you focus on using your data to acquire new insights for your business and customers.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  To learn more about Amazon Redshift Serverless, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-whatis.html">What
    /// is Amazon Redshift Serverless</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonRedshiftServerlessClient : AmazonServiceClient, IAmazonRedshiftServerless
    {
        private static IServiceMetadata serviceMetadata = new AmazonRedshiftServerlessMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonRedshiftServerlessClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftServerlessConfig()) { }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRedshiftServerlessConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(AmazonRedshiftServerlessConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials)
            : this(credentials, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRedshiftServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Credentials and an
        /// AmazonRedshiftServerlessClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(AWSCredentials credentials, AmazonRedshiftServerlessConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRedshiftServerlessConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRedshiftServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftServerlessConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRedshiftServerlessConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRedshiftServerlessClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRedshiftServerlessClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRedshiftServerlessClient Configuration Object</param>
        public AmazonRedshiftServerlessClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRedshiftServerlessConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRedshiftServerlessPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRedshiftServerlessPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new RedshiftServerlessPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  ConvertRecoveryPointToSnapshot

        internal virtual ConvertRecoveryPointToSnapshotResponse ConvertRecoveryPointToSnapshot(ConvertRecoveryPointToSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConvertRecoveryPointToSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConvertRecoveryPointToSnapshotResponseUnmarshaller.Instance;

            return Invoke<ConvertRecoveryPointToSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Converts a recovery point to a snapshot. For more information about recovery points
        /// and snapshots, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">Working
        /// with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConvertRecoveryPointToSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConvertRecoveryPointToSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ConvertRecoveryPointToSnapshot">REST API Reference for ConvertRecoveryPointToSnapshot Operation</seealso>
        public virtual Task<ConvertRecoveryPointToSnapshotResponse> ConvertRecoveryPointToSnapshotAsync(ConvertRecoveryPointToSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConvertRecoveryPointToSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConvertRecoveryPointToSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ConvertRecoveryPointToSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpointAccess

        internal virtual CreateEndpointAccessResponse CreateEndpointAccess(CreateEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/CreateEndpointAccess">REST API Reference for CreateEndpointAccess Operation</seealso>
        public virtual Task<CreateEndpointAccessResponse> CreateEndpointAccessAsync(CreateEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNamespace

        internal virtual CreateNamespaceResponse CreateNamespace(CreateNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return Invoke<CreateNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/CreateNamespace">REST API Reference for CreateNamespace Operation</seealso>
        public virtual Task<CreateNamespaceResponse> CreateNamespaceAsync(CreateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Creates a snapshot of all databases in a namespace. For more information about snapshots,
        /// see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/serverless-snapshots-recovery.html">
        /// Working with snapshots and recovery points</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateUsageLimit

        internal virtual CreateUsageLimitResponse CreateUsageLimit(CreateUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<CreateUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Creates a usage limit for a specified Amazon Redshift Serverless usage type. The usage
        /// limit is identified by the returned usage limit identifier.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/CreateUsageLimit">REST API Reference for CreateUsageLimit Operation</seealso>
        public virtual Task<CreateUsageLimitResponse> CreateUsageLimitAsync(CreateUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUsageLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkgroup

        internal virtual CreateWorkgroupResponse CreateWorkgroup(CreateWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkgroupResponseUnmarshaller.Instance;

            return Invoke<CreateWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Creates an workgroup in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/CreateWorkgroup">REST API Reference for CreateWorkgroup Operation</seealso>
        public virtual Task<CreateWorkgroupResponse> CreateWorkgroupAsync(CreateWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWorkgroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpointAccess

        internal virtual DeleteEndpointAccessResponse DeleteEndpointAccess(DeleteEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Deletes an Amazon Redshift Serverless managed VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/DeleteEndpointAccess">REST API Reference for DeleteEndpointAccess Operation</seealso>
        public virtual Task<DeleteEndpointAccessResponse> DeleteEndpointAccessAsync(DeleteEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNamespace

        internal virtual DeleteNamespaceResponse DeleteNamespace(DeleteNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a namespace from Amazon Redshift Serverless. Before you delete the namespace,
        /// you can create a final snapshot that has all of the data within the namespace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/DeleteNamespace">REST API Reference for DeleteNamespace Operation</seealso>
        public virtual Task<DeleteNamespaceResponse> DeleteNamespaceAsync(DeleteNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Deletes a snapshot from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteUsageLimit

        internal virtual DeleteUsageLimitResponse DeleteUsageLimit(DeleteUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return Invoke<DeleteUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Deletes a usage limit from Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/DeleteUsageLimit">REST API Reference for DeleteUsageLimit Operation</seealso>
        public virtual Task<DeleteUsageLimitResponse> DeleteUsageLimitAsync(DeleteUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUsageLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkgroup

        internal virtual DeleteWorkgroupResponse DeleteWorkgroup(DeleteWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkgroupResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes a workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/DeleteWorkgroup">REST API Reference for DeleteWorkgroup Operation</seealso>
        public virtual Task<DeleteWorkgroupResponse> DeleteWorkgroupAsync(DeleteWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWorkgroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCredentials

        internal virtual GetCredentialsResponse GetCredentials(GetCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsResponseUnmarshaller.Instance;

            return Invoke<GetCredentialsResponse>(request, options);
        }



        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log in to Amazon Redshift Serverless.
        /// 
        ///  
        /// <para>
        /// By default, the temporary credentials expire in 900 seconds. You can optionally specify
        /// a duration between 900 seconds (15 minutes) and 3600 seconds (60 minutes).
        /// </para>
        ///  <pre><code> &lt;p&gt; The Identity and Access Management (IAM) user or role that
        /// runs GetCredentials must have an IAM policy attached that allows access to all necessary
        /// actions and resources. &lt;/p&gt; &lt;p&gt; If the &lt;code&gt;DbName&lt;/code&gt;
        /// parameter is specified, the IAM policy must allow access to the resource dbname for
        /// the specified database name.&lt;/p&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCredentials service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetCredentials">REST API Reference for GetCredentials Operation</seealso>
        public virtual Task<GetCredentialsResponse> GetCredentialsAsync(GetCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEndpointAccess

        internal virtual GetEndpointAccessResponse GetEndpointAccess(GetEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<GetEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Returns information, such as the name, about a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetEndpointAccess">REST API Reference for GetEndpointAccess Operation</seealso>
        public virtual Task<GetEndpointAccessResponse> GetEndpointAccessAsync(GetEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNamespace

        internal virtual GetNamespaceResponse GetNamespace(GetNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return Invoke<GetNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a namespace in Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetNamespace">REST API Reference for GetNamespace Operation</seealso>
        public virtual Task<GetNamespaceResponse> GetNamespaceAsync(GetNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<GetNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRecoveryPoint

        internal virtual GetRecoveryPointResponse GetRecoveryPoint(GetRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<GetRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetRecoveryPoint">REST API Reference for GetRecoveryPoint Operation</seealso>
        public virtual Task<GetRecoveryPointResponse> GetRecoveryPointAsync(GetRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<GetRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSnapshot

        internal virtual GetSnapshotResponse GetSnapshot(GetSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return Invoke<GetSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetSnapshot">REST API Reference for GetSnapshot Operation</seealso>
        public virtual Task<GetSnapshotResponse> GetSnapshotAsync(GetSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUsageLimit

        internal virtual GetUsageLimitResponse GetUsageLimit(GetUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageLimitResponseUnmarshaller.Instance;

            return Invoke<GetUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetUsageLimit">REST API Reference for GetUsageLimit Operation</seealso>
        public virtual Task<GetUsageLimitResponse> GetUsageLimitAsync(GetUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsageLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetWorkgroup

        internal virtual GetWorkgroupResponse GetWorkgroup(GetWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkgroupResponseUnmarshaller.Instance;

            return Invoke<GetWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specific workgroup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/GetWorkgroup">REST API Reference for GetWorkgroup Operation</seealso>
        public virtual Task<GetWorkgroupResponse> GetWorkgroupAsync(GetWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<GetWorkgroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEndpointAccess

        internal virtual ListEndpointAccessResponse ListEndpointAccess(ListEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<ListEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of <code>EndpointAccess</code> objects and relevant information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListEndpointAccess">REST API Reference for ListEndpointAccess Operation</seealso>
        public virtual Task<ListEndpointAccessResponse> ListEndpointAccessAsync(ListEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<ListEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListNamespaces

        internal virtual ListNamespacesResponse ListNamespaces(ListNamespacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return Invoke<ListNamespacesResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a list of specified namespaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNamespaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNamespaces service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListNamespaces">REST API Reference for ListNamespaces Operation</seealso>
        public virtual Task<ListNamespacesResponse> ListNamespacesAsync(ListNamespacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListNamespacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNamespacesResponseUnmarshaller.Instance;

            return InvokeAsync<ListNamespacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecoveryPoints

        internal virtual ListRecoveryPointsResponse ListRecoveryPoints(ListRecoveryPointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsResponseUnmarshaller.Instance;

            return Invoke<ListRecoveryPointsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of recovery points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecoveryPoints service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecoveryPoints service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListRecoveryPoints">REST API Reference for ListRecoveryPoints Operation</seealso>
        public virtual Task<ListRecoveryPointsResponse> ListRecoveryPointsAsync(ListRecoveryPointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecoveryPointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecoveryPointsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecoveryPointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSnapshots

        internal virtual ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return Invoke<ListSnapshotsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSnapshots service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListSnapshots">REST API Reference for ListSnapshots Operation</seealso>
        public virtual Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags assigned to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsageLimits

        internal virtual ListUsageLimitsResponse ListUsageLimits(ListUsageLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageLimitsResponseUnmarshaller.Instance;

            return Invoke<ListUsageLimitsResponse>(request, options);
        }



        /// <summary>
        /// Lists all usage limits within Amazon Redshift Serverless.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageLimits service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InvalidPaginationException">
        /// The provided pagination token is invalid.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListUsageLimits">REST API Reference for ListUsageLimits Operation</seealso>
        public virtual Task<ListUsageLimitsResponse> ListUsageLimitsAsync(ListUsageLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<ListUsageLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWorkgroups

        internal virtual ListWorkgroupsResponse ListWorkgroups(ListWorkgroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkgroupsResponseUnmarshaller.Instance;

            return Invoke<ListWorkgroupsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a list of specified workgroups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkgroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWorkgroups service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/ListWorkgroups">REST API Reference for ListWorkgroups Operation</seealso>
        public virtual Task<ListWorkgroupsResponse> ListWorkgroupsAsync(ListWorkgroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWorkgroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWorkgroupsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWorkgroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a resource policy. Currently, you can use policies to share snapshots
        /// across Amazon Web Services accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromRecoveryPoint

        internal virtual RestoreFromRecoveryPointResponse RestoreFromRecoveryPoint(RestoreFromRecoveryPointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromRecoveryPointResponseUnmarshaller.Instance;

            return Invoke<RestoreFromRecoveryPointResponse>(request, options);
        }



        /// <summary>
        /// Restore the data from a recovery point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromRecoveryPoint service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromRecoveryPoint service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/RestoreFromRecoveryPoint">REST API Reference for RestoreFromRecoveryPoint Operation</seealso>
        public virtual Task<RestoreFromRecoveryPointResponse> RestoreFromRecoveryPointAsync(RestoreFromRecoveryPointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromRecoveryPointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromRecoveryPointResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromRecoveryPointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreFromSnapshot

        internal virtual RestoreFromSnapshotResponse RestoreFromSnapshot(RestoreFromSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return Invoke<RestoreFromSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Restores a namespace from a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ServiceQuotaExceededException">
        /// The service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/RestoreFromSnapshot">REST API Reference for RestoreFromSnapshot Operation</seealso>
        public virtual Task<RestoreFromSnapshotResponse> RestoreFromSnapshotAsync(RestoreFromSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreFromSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreFromSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreFromSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Assigns one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.TooManyTagsException">
        /// The request exceeded the number of tags allowed for a resource.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes a tag or set of tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEndpointAccess

        internal virtual UpdateEndpointAccessResponse UpdateEndpointAccess(UpdateEndpointAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointAccessResponseUnmarshaller.Instance;

            return Invoke<UpdateEndpointAccessResponse>(request, options);
        }



        /// <summary>
        /// Updates an Amazon Redshift Serverless managed endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEndpointAccess service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/UpdateEndpointAccess">REST API Reference for UpdateEndpointAccess Operation</seealso>
        public virtual Task<UpdateEndpointAccessResponse> UpdateEndpointAccessAsync(UpdateEndpointAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEndpointAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEndpointAccessResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEndpointAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNamespace

        internal virtual UpdateNamespaceResponse UpdateNamespace(UpdateNamespaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamespaceResponseUnmarshaller.Instance;

            return Invoke<UpdateNamespaceResponse>(request, options);
        }



        /// <summary>
        /// Updates a namespace with the specified settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNamespace service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNamespace service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/UpdateNamespace">REST API Reference for UpdateNamespace Operation</seealso>
        public virtual Task<UpdateNamespaceResponse> UpdateNamespaceAsync(UpdateNamespaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNamespaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNamespaceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNamespaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSnapshot

        internal virtual UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return Invoke<UpdateSnapshotResponse>(request, options);
        }



        /// <summary>
        /// Updates a snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSnapshot service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/UpdateSnapshot">REST API Reference for UpdateSnapshot Operation</seealso>
        public virtual Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateUsageLimit

        internal virtual UpdateUsageLimitResponse UpdateUsageLimit(UpdateUsageLimitRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageLimitResponseUnmarshaller.Instance;

            return Invoke<UpdateUsageLimitResponse>(request, options);
        }



        /// <summary>
        /// Update a usage limit in Amazon Redshift Serverless. You can't update the usage type
        /// or period of a usage limit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsageLimit service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUsageLimit service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/UpdateUsageLimit">REST API Reference for UpdateUsageLimit Operation</seealso>
        public virtual Task<UpdateUsageLimitResponse> UpdateUsageLimitAsync(UpdateUsageLimitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateUsageLimitRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateUsageLimitResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUsageLimitResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateWorkgroup

        internal virtual UpdateWorkgroupResponse UpdateWorkgroup(UpdateWorkgroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkgroupResponseUnmarshaller.Instance;

            return Invoke<UpdateWorkgroupResponse>(request, options);
        }



        /// <summary>
        /// Updates a workgroup with the specified configuration settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkgroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWorkgroup service method, as returned by RedshiftServerless.</returns>
        /// <exception cref="Amazon.RedshiftServerless.Model.ConflictException">
        /// The submitted action has conflicts.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InsufficientCapacityException">
        /// There is an insufficient capacity to perform the action.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.InternalServerException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.RedshiftServerless.Model.ValidationException">
        /// The input failed to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshiftserverless-2021-04-21/UpdateWorkgroup">REST API Reference for UpdateWorkgroup Operation</seealso>
        public virtual Task<UpdateWorkgroupResponse> UpdateWorkgroupAsync(UpdateWorkgroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateWorkgroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWorkgroupResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWorkgroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}