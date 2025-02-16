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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.FSx.Model;

namespace Amazon.FSx
{
    /// <summary>
    /// Interface for accessing FSx
    ///
    /// Amazon FSx is a fully managed service that makes it easy for storage and application
    /// administrators to launch and use shared file storage.
    /// </summary>
    public partial interface IAmazonFSx : IAmazonService, IDisposable
    {
                
        #region  CreateBackup



        /// <summary>
        /// Creates a backup of an existing Amazon FSx for Windows File Server file system. Creating
        /// regular backups for your file system is a best practice that complements the replication
        /// that Amazon FSx for Windows File Server performs for your file system. It also enables
        /// you to restore from user modification of data.
        /// 
        ///  
        /// <para>
        /// If a backup with the specified client request token exists, and the parameters match,
        /// this operation returns the description of the existing backup. If a backup specified
        /// client request token exists, and the parameters don't match, this operation returns
        /// <code>IncompatibleParameterError</code>. If a backup with the specified client request
        /// token doesn't exist, <code>CreateBackup</code> does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx backup with an assigned ID, and an initial lifecycle state
        /// of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the backup.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateBackup</code> operation
        /// without the risk of creating an extra backup. This approach can be useful when an
        /// initial call fails in a way that makes it unclear whether a backup was created. If
        /// you use the same client request token and the initial call created a backup, the operation
        /// returns a successful result because all the parameters are the same.
        /// </para>
        ///  
        /// <para>
        /// The <code>CreateFileSystem</code> operation returns while the backup's lifecycle state
        /// is still <code>CREATING</code>. You can check the file system creation status by calling
        /// the <a>DescribeBackups</a> operation, which returns the backup state along with other
        /// information.
        /// </para>
        ///  <note>  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateBackup">REST API Reference for CreateBackup Operation</seealso>
        Task<CreateBackupResponse> CreateBackupAsync(CreateBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFileSystem



        /// <summary>
        /// Creates a new, empty Amazon FSx file system.
        /// 
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, <code>CreateFileSystem</code> returns the description of the existing file
        /// system. If a file system specified client request token exists and the parameters
        /// don't match, this call returns <code>IncompatibleParameterError</code>. If a file
        /// system with the specified client request token doesn't exist, <code>CreateFileSystem</code>
        /// does the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new, empty Amazon FSx file system with an assigned ID, and an initial lifecycle
        /// state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation requires a client request token in the request that Amazon FSx uses
        /// to ensure idempotent creation. This means that calling the operation multiple times
        /// with the same client request token has no effect. By using the idempotent operation,
        /// you can retry a <code>CreateFileSystem</code> operation without the risk of creating
        /// an extra file system. This approach can be useful when an initial call fails in a
        /// way that makes it unclear whether a file system was created. Examples are if a transport
        /// level timeout occurred, or your connection was reset. If you use the same client request
        /// token and the initial call created a file system, the client receives success as long
        /// as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystem</code> call returns while the file system's lifecycle state
        /// is still <code>CREATING</code>. You can check the file-system creation status by calling
        /// the <a>DescribeFileSystems</a> operation, which returns the file system state along
        /// with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidExportPathException">
        /// The path provided for data repository export isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidImportPathException">
        /// The path provided for data repository import isn't valid.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid. <code>InvalidVpcId</code>
        /// means that the ID passed for the virtual private cloud (VPC) is invalid. <code>InvalidSubnetIds</code>
        /// returns the list of IDs for subnets that are either invalid or not part of the VPC
        /// specified. <code>InvalidSecurityGroupIds</code> returns the list of IDs for security
        /// groups that are either invalid or not part of the VPC specified.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// File system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystem">REST API Reference for CreateFileSystem Operation</seealso>
        Task<CreateFileSystemResponse> CreateFileSystemAsync(CreateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateFileSystemFromBackup



        /// <summary>
        /// Creates a new Amazon FSx file system from an existing Amazon FSx for Windows File
        /// Server backup.
        /// 
        ///  
        /// <para>
        /// If a file system with the specified client request token exists and the parameters
        /// match, this call returns the description of the existing file system. If a client
        /// request token specified by the file system exists and the parameters don't match,
        /// this call returns <code>IncompatibleParameterError</code>. If a file system with the
        /// specified client request token doesn't exist, this operation does the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Creates a new Amazon FSx file system from backup with an assigned ID, and an initial
        /// lifecycle state of <code>CREATING</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Returns the description of the file system.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Parameters like Active Directory, default share name, automatic backup, and backup
        /// settings default to the parameters of the file system that was backed up, unless overridden.
        /// You can explicitly supply other settings.
        /// </para>
        ///  
        /// <para>
        /// By using the idempotent operation, you can retry a <code>CreateFileSystemFromBackup</code>
        /// call without the risk of creating an extra file system. This approach can be useful
        /// when an initial call fails in a way that makes it unclear whether a file system was
        /// created. Examples are if a transport level timeout occurred, or your connection was
        /// reset. If you use the same client request token and the initial call created a file
        /// system, the client receives success as long as the parameters are the same.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <code>CreateFileSystemFromBackup</code> call returns while the file system's lifecycle
        /// state is still <code>CREATING</code>. You can check the file-system creation status
        /// by calling the <a>DescribeFileSystems</a> operation, which returns the file system
        /// state along with other information.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFileSystemFromBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateFileSystemFromBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.ActiveDirectoryErrorException">
        /// An Active Directory error.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InvalidNetworkSettingsException">
        /// One or more network settings specified in the request are invalid. <code>InvalidVpcId</code>
        /// means that the ID passed for the virtual private cloud (VPC) is invalid. <code>InvalidSubnetIds</code>
        /// returns the list of IDs for subnets that are either invalid or not part of the VPC
        /// specified. <code>InvalidSecurityGroupIds</code> returns the list of IDs for security
        /// groups that are either invalid or not part of the VPC specified.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// File system configuration is required for this operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/CreateFileSystemFromBackup">REST API Reference for CreateFileSystemFromBackup Operation</seealso>
        Task<CreateFileSystemFromBackupResponse> CreateFileSystemFromBackupAsync(CreateFileSystemFromBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBackup



        /// <summary>
        /// Deletes an Amazon FSx for Windows File Server backup, deleting its contents. After
        /// deletion, the backup no longer exists, and its data is gone.
        /// 
        ///  
        /// <para>
        /// The <code>DeleteBackup</code> call returns instantly. The backup will not show up
        /// in later <code>DescribeBackups</code> calls.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data in a deleted backup is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBackup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBackup service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupInProgressException">
        /// Another backup is already under way. Wait for completion before initiating additional
        /// backups of this file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BackupRestoringException">
        /// You can't delete a backup while it's being used to restore a file system.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteBackup">REST API Reference for DeleteBackup Operation</seealso>
        Task<DeleteBackupResponse> DeleteBackupAsync(DeleteBackupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteFileSystem



        /// <summary>
        /// Deletes a file system, deleting its contents. After deletion, the file system no longer
        /// exists, and its data is gone. Any existing automatic backups will also be deleted.
        /// 
        ///  
        /// <para>
        /// By default, when you delete an Amazon FSx for Windows File Server file system, a final
        /// backup is created upon deletion. This final backup is not subject to the file system's
        /// retention policy, and must be manually deleted.
        /// </para>
        ///  
        /// <para>
        /// The <code>DeleteFileSystem</code> action returns while the file system has the <code>DELETING</code>
        /// status. You can check the file system deletion status by calling the <a>DescribeFileSystems</a>
        /// action, which returns a list of file systems in your account. If you pass the file
        /// system ID for a deleted file system, the <a>DescribeFileSystems</a> returns a <code>FileSystemNotFound</code>
        /// error.
        /// </para>
        ///  <important> 
        /// <para>
        /// The data in a deleted file system is also deleted and can't be recovered by any means.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ServiceLimitExceededException">
        /// An error indicating that a particular service limit was exceeded. You can increase
        /// some service limits by contacting AWS Support.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DeleteFileSystem">REST API Reference for DeleteFileSystem Operation</seealso>
        Task<DeleteFileSystemResponse> DeleteFileSystemAsync(DeleteFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBackups



        /// <summary>
        /// Returns the description of specific Amazon FSx for Windows File Server backups, if
        /// a <code>BackupIds</code> value is provided for that backup. Otherwise, it returns
        /// all backups owned by your AWS account in the AWS Region of the endpoint that you're
        /// calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all backups, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of backups in a response. If more backups remain, Amazon
        /// FSx returns a <code>NextToken</code> value in the response. In this case, send a later
        /// request with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your backups. <code>DescribeBackups</code>
        /// is called first without a <code>NextToken</code>value. Then the action continues to
        /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
        /// value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of backups returned in the response of one <code>DescribeBackups</code>
        /// call and the order of backups returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBackups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBackups service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BackupNotFoundException">
        /// No Amazon FSx backups were found based upon the supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeBackups">REST API Reference for DescribeBackups Operation</seealso>
        Task<DescribeBackupsResponse> DescribeBackupsAsync(DescribeBackupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeFileSystems



        /// <summary>
        /// Returns the description of specific Amazon FSx file systems, if a <code>FileSystemIds</code>
        /// value is provided for that file system. Otherwise, it returns descriptions of all
        /// file systems owned by your AWS account in the AWS Region of the endpoint that you're
        /// calling.
        /// 
        ///  
        /// <para>
        /// When retrieving all file system descriptions, you can optionally specify the <code>MaxResults</code>
        /// parameter to limit the number of descriptions in a response. If more file system descriptions
        /// remain, Amazon FSx returns a <code>NextToken</code> value in the response. In this
        /// case, send a later request with the <code>NextToken</code> request parameter set to
        /// the value of <code>NextToken</code> from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your file system
        /// descriptions. <code>DescribeFileSystems</code> is called first without a <code>NextToken</code>value.
        /// Then the action continues to be called with the <code>NextToken</code> parameter set
        /// to the value of the last <code>NextToken</code> value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of file systems returned in the response of one <code>DescribeFileSystems</code>
        /// call and the order of file systems returned across the responses of a multicall iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFileSystems service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFileSystems service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/DescribeFileSystems">REST API Reference for DescribeFileSystems Operation</seealso>
        Task<DescribeFileSystemsResponse> DescribeFileSystemsAsync(DescribeFileSystemsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists tags for an Amazon FSx file systems and backups in the case of Amazon FSx for
        /// Windows File Server.
        /// 
        ///  
        /// <para>
        /// When retrieving all tags, you can optionally specify the <code>MaxResults</code> parameter
        /// to limit the number of tags in a response. If more tags remain, Amazon FSx returns
        /// a <code>NextToken</code> value in the response. In this case, send a later request
        /// with the <code>NextToken</code> request parameter set to the value of <code>NextToken</code>
        /// from the last response.
        /// </para>
        ///  
        /// <para>
        /// This action is used in an iterative process to retrieve a list of your tags. <code>ListTagsForResource</code>
        /// is called first without a <code>NextToken</code>value. Then the action continues to
        /// be called with the <code>NextToken</code> parameter set to the value of the last <code>NextToken</code>
        /// value until a response has no <code>NextToken</code>.
        /// </para>
        ///  
        /// <para>
        /// When using this action, keep the following in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The implementation might return fewer than <code>MaxResults</code> file system descriptions
        /// while still including a <code>NextToken</code> value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The order of tags returned in the response of one <code>ListTagsForResource</code>
        /// call and the order of tags returned across the responses of a multi-call iteration
        /// is unspecified.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Tags an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// This action removes a tag from an Amazon FSx resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.NotServiceResourceErrorException">
        /// The resource specified for the tagging operation is not a resource type owned by Amazon
        /// FSx. Use the API of the relevant service to perform the operation.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceDoesNotSupportTaggingException">
        /// The resource specified does not support tagging.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.ResourceNotFoundException">
        /// The resource specified by the Amazon Resource Name (ARN) can't be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateFileSystem



        /// <summary>
        /// Updates a file system configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFileSystem service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateFileSystem service method, as returned by FSx.</returns>
        /// <exception cref="Amazon.FSx.Model.BadRequestException">
        /// A generic error indicating a failure with a client request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.FileSystemNotFoundException">
        /// No Amazon FSx file systems were found based upon supplied parameters.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.IncompatibleParameterErrorException">
        /// The error returned when a second request is received with the same client request
        /// token but different parameters settings. A client request token should always uniquely
        /// identify a single request.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.InternalServerErrorException">
        /// A generic error indicating a server-side failure.
        /// </exception>
        /// <exception cref="Amazon.FSx.Model.MissingFileSystemConfigurationException">
        /// File system configuration is required for this operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/fsx-2018-03-01/UpdateFileSystem">REST API Reference for UpdateFileSystem Operation</seealso>
        Task<UpdateFileSystemResponse> UpdateFileSystemAsync(UpdateFileSystemRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}