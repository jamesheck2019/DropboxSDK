Imports dropboxSDK.File
Imports dropboxSDK.JSON

Public Interface IFile

#Region "copy"
    Function CopyFile(SourceFile As String, DestinationFolder As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function CopyAndRenameFile(SourceFile As String, DestinationFolder As String, RenameTo As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function CopyMultipleFiles(SourceFiles As List(Of String), DestinationFolder As String, DestinationType As DestinationType, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_ResponseAsyncJobID)
    Function CopyMultipleFilesStatus(jobID As String) As Task(Of JSON_DeleteMultipleFilesStatus)
#End Region


#Region "move"
    Function MoveFile(SourceFile As String, DestinationFolder As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function MoveAndRenameFile(SourceFile As String, DestinationFolder As String, RenameTo As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function MoveMultipleFiles(SourceFiles As List(Of String), DestinationFolder As String, DestinationType As DestinationType, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_ResponseAsyncJobID)
    Function MoveMultipleFilesStatus(jobID As String) As Task(Of JSON_DeleteMultipleFilesStatus)


#End Region



#Region "delete / trash"
    Function TrashFile(DestinationFile As String) As Task(Of JSON_filefoldermetadata)
    Function TrashMultipleFiles(DestinationFiles As List(Of String)) As Task(Of JSON_ResponseAsyncJobID)

    Function DeleteFile(DestinationFile As String) As Task(Of JSON_ResponseFileMetadata)
    Function DeleteMultipleFilesStatus(jobID As String) As Task(Of JSON_DeleteMultipleFilesStatus)
#End Region



    Function RenameFile(SourceFile As String, RenameTo As String) As Task(Of JSON_RelocationResult)
    Function UploadLocalFile(FileToUP As Object, TheUpType As SentType, DestinationFolder As String, Optional Filename As String = Nothing, Optional WhatIfFileAlreadyExists As WriteMode = WriteMode.add, Optional AutoRename As Boolean = False, Optional StrictAboutConflict As Boolean = False, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSON_FileMetadata)
    Function UploadRemoteFile(UrlToUP As String, DestinationFolder As String, Optional Filename As String = Nothing) As Task(Of JSON_UploadRemote)
    Function UploadRemoteFileStatus(RemoteJobID As String) As Task(Of JSON_UploadRemoteStatus)







    Function FileMetadata(DestinationFile As String, IncludeMediaInfo As Boolean, IncludeDeleted As Boolean, IncludeHasExplicitSharedMembers As Boolean) As Task(Of JSON_FileMetadata)
    Function FileThumbnail(DestinationFile As String, ImgFormat As FileThumbnailOptions.ThumbnailFormat, Size As FileThumbnailOptions.ThumbnailSize, Mode As FileThumbnailOptions.ThumbnailMode, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional token As Threading.CancellationToken = Nothing) As Task(Of IO.Stream)
    Function MultipleFilesThumbnail(DestinationFiles As List(Of String), DestinationType As DestinationType, ImgFormat As FileThumbnailOptions.ThumbnailFormat, Size As FileThumbnailOptions.ThumbnailSize, Mode As FileThumbnailOptions.ThumbnailMode) As Task(Of JSON_MultipleFilesThumbnail)

    Function DownloadFile(DestinationFile As String, FileSavePath As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task
    Function DownloadFileAsStream(DestinationFile As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task(Of IO.Stream)




End Interface
