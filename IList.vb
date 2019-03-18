Imports dropboxSDK.JSON
Imports dropboxSDK.List

Public Interface IList

    Function ListAllFiles() As Task(Of JSON_ListAllFiles)

    Function ListFolder(DestinationFolder As String, IncludeSubfolders As Boolean, IncludeMediaInfo As Boolean, IncludeDeleted As Boolean, IncludeHasExplicitSharedMembers As Boolean, Include_app_shared_team_Folders As Boolean, Optional Limit As String = Nothing) As Task(Of JSON_ListFolderResult)
    Function ListRootFolders(IncludeMediaInfo As Boolean, IncludeDeleted As Boolean, IncludeHasExplicitSharedMembers As Boolean, Include_app_shared_team_Folders As Boolean, Optional Limit As Integer = 50) As Task(Of JSON_ListFolderResult)
    Function ListFolderContinue(Cursor As String) As Task(Of JSON_ListFolderResult)

    Function LatestUploadedOrModifiedInFolder(DestinationFolder As String, DestinationType As DestinationType, IncludeSubfolders As Boolean, IncludeMediaInfo As Boolean, IncludeDeleted As Boolean, IncludeHasExplicitSharedMembers As Boolean, IncludeMountedFolders As Boolean, Optional Limit As String = Nothing) As Task(Of JSON_LatestUploadedOrModifiedIntoFolder)



End Interface
