Imports dropboxSDK.Folder
Imports dropboxSDK.JSON

Public Interface IFolder


#Region "copy"
    Function CopyFolder(SourceFolder As String, DestinationFolder As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function CopyAndRenameFolder(SourceFolder As String, DestinationFolder As String, RenameTo As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function CopyMultipleFolders(SourceFolders As List(Of String), DestinationFolder As String, DestinationType As DestinationType, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_ResponseAsyncJobID)
    Function CopyMultipleFoldersStatus(jobID As String) As Task(Of JSON_DeleteMultipleFoldersStatus)
#End Region

#Region "move"
    Function MoveFolder(SourceFolder As String, DestinationFolder As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function MoveAndRenameFolder(SourceFolder As String, DestinationFolder As String, RenameTo As String, AllowSharedFolder As Boolean, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_RelocationResult)
    Function MoveMultipleFolders(SourceFolder As List(Of String), DestinationFolder As String, DestinationType As DestinationType, AutoRename As Boolean, AllowOwnershipTransfer As Boolean) As Task(Of JSON_ResponseAsyncJobID)
    Function MoveMultipleFoldersStatus(jobID As String) As Task(Of JSON_DeleteMultipleFoldersStatus)
#End Region


    Function RenameFolder(SourceFolder As String, RenameTo As String) As Task(Of JSON_RelocationResult)
    Function CreateNewFolder(DestinationFolder As String, FolderName As String, AutoRename As Boolean) As Task(Of JSON_CreateFolderResult)
    Function CreateMultipleNewFolders(DestinationFolder As String, FoldersName As List(Of String), AutoRename As Boolean, CreateAsynchronously As Boolean) As Task(Of JSON_CreateMultipleNewFolders)
    Function FolderMetadata(DestinationFolder As String, IncludeMediaInfo As Boolean, IncludeDeleted As Boolean, IncludeHasExplicitSharedMembers As Boolean) As Task(Of JSON_FolderMetadata)




#Region "delete / trash"
    Function TrashFolder(DestinationFolder As String) As Task(Of JSON_Metadata)
    Function TrashMultipleFolders(DestinationFolders As List(Of String)) As Task(Of JSON_ResponseAsyncJobID)
    Function DeleteFolder(DestinationFolder As String) As Task(Of JSON_ResponseFolderMetadata)
    Function DeleteMultipleFoldersStatus(jobID As String) As Task(Of JSON_DeleteMultipleFoldersStatus)
#End Region


    Function DownloadFolderAsZip(DestinationFolder As String, FileSavePath As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task




End Interface
