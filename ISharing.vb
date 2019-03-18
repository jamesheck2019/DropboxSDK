Imports dropboxSDK.JSON
Imports dropboxSDK.Sharing

Public Interface ISharing


#Region "File"
    

#End Region



#Region "Share"


    



    

    Function ShareFile(DestinationFile As String, ShareWithEmails_or_DropboxUserId As List(Of String), SharedFilePermission As AccessLevel, Optional notify As Boolean = False, Optional Message As String = Nothing) As Task(Of List(Of JSON_FileMemberAction))
    Function UnShareFile(FileID As String) As Task(Of Boolean)

    Function ShareFolder(DestinationFolder As String, ShareWithEmails_or_DropboxUserId As List(Of String), SharedFolderPermission As AccessLevel, Optional notify As Boolean = False, Optional Message As String = Nothing) As Task(Of Boolean)
    Function UnshareFolder(SharedFolderID As String, LeaveACopyOfFolderAtMembersAccounts As Boolean) As Task(Of JSON_LaunchEmptyResult)


    Function RemoveMemberUserFromSharedFile(FileID As String, ShareWithEmails_or_DropboxUserId As String) As Task(Of JSON_FileMemberRemoveActionResult)
    Function RemoveMemberUserFromSharedFolder(SharedFolderID As String, ShareWithEmails_or_DropboxUserId As String, LeaveACopyOfFolderAtRemovedUserAccount As Boolean) As Task(Of JSON_LaunchEmptyResult)

    

#End Region





    Function SharedFileMetadata(DestinationFile As String, Optional Actions As Dictionary(Of Enums.FileAction, Boolean) = Nothing) As Task(Of JSON_SharedFileMetadata)
    Function MultipleSharedFilesMetadata(DestinationFiles As List(Of String), Optional Actions As Dictionary(Of Enums.FileAction, Boolean) = Nothing) As Task(Of List(Of JSON_SharedFilesMetadata))
    Function SharedFolderMetadata(SharedFolderID As String, Optional Actions As Dictionary(Of Enums.FileAction, Boolean) = Nothing) As Task(Of JSON_SharedFolderMetadata)

    Function ListAllSharesFoldersOfUser(Optional LimitResultsTo As Integer = 1000, Optional Actions As Dictionary(Of Enums.FolderAction, Boolean) = Nothing) As Task(Of JSON_ListSharedFolderResult)
    Function ListAllSharesFoldersOfUser_Continue(ContinueCursor As String) As Task(Of JSON_ListSharedFolderResult)


    Function ListFilesShareRequestsReceived(Optional LimitResultsTo As Integer = 1000, Optional Actions As Dictionary(Of Enums.FileAction, Boolean) = Nothing) As Task(Of JSON_ListSharedFileMetadata)
    Function ListFilesShareRequestsReceived_Continue(ContinueCursor As String) As Task(Of JSON_ListSharedFileMetadata)

    Function AcceptFolderShareRequest(SharedFolderID As Integer) As Task(Of JSON_SharedFolderMetadata)


End Interface
