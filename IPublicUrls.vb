Imports dropboxSDK.PublicUrls
Imports dropboxSDK.JSON

Public Interface IPublicUrls


    Function TemporaryFileLink(DestinationFile As String, Optional ShortenLink As Boolean = False) As Task(Of JSON_GetTemporaryLinkResult)
    Function PublicFile(DestinationFile As String, visibility As requestedvisibility, Optional Password As String = Nothing, Optional ExpireDate As String = Nothing) As Task(Of JSON_FileMetadata) 'System.DateTime
    Function PublicFolder(DestinationFolder As String, visibility As requestedvisibility, Optional Password As String = Nothing, Optional ExpireDate As String = Nothing) As Task(Of JSON_FolderMetadata)

    Function PublicFileFolder(DestinationFileFolder As String, visibility As requestedvisibility, Optional Password As String = Nothing, Optional ExpireDate As String = Nothing) As Task(Of JSON_FileMetadata)
    Function UnPublicFileFolder(PFileFolderLink As String) As Task(Of Boolean)


    Function PFileMetadata(PFileLink As String, Optional SharedLinkPassword As String = Nothing) As Task(Of JSON_FileLinkMetadata)
    Function DownloadPFile(FileSharedLink As String, SharedLinkPassword As String, OutputDirPath As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task(Of JSON_FileLinkMetadata)

    Function PFolderMetadata(PFolderLink As String, Optional SharedLinkPassword As String = Nothing) As Task(Of JSON_FolderLinkMetadata)
    Function ExplorerPFolder(PFolderLink As String, Optional SharedFolderPassword As String = Nothing, Optional StartingFromPath As String = Nothing) As Task(Of JSON_ListFolderResult)
    Function DownloadFileFromPFolder(PFolderLink As String, FilePathToDownload As String, SharedLinkPassword As String, OutputDirPath As String, Optional ReportCls As IProgress(Of ReportStatus) = Nothing, Optional _proxi As ProxyConfig = Nothing, Optional TimeOut As Integer = 60, Optional token As Threading.CancellationToken = Nothing) As Task '(Of JSON_FileLinkMetadata)

    Function ListAllPublicLinksOfFolder(DestinationFolder As String, Optional LinksToParentFolders As Boolean = False) As Task(Of JSON_ListSharedLinksResult)
    Function ListAllPublicLinks_Continue(ContinueCursor As String) As Task(Of JSON_ListSharedLinksResult)
    Function ListAllPublicLinksOfUser() As Task(Of JSON_ListSharedLinksResult)


End Interface
