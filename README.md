## DropboxSDK

`Download:`[https://github.com/jamesheck2019/DropboxSDK/releases](https://github.com/jamesheck2019/DropboxSDK/releases)<br>
`NuGet:`
[![NuGet](https://img.shields.io/nuget/v/DeQmaTech.DropboxSDK.svg?style=flat-square&logo=nuget)](https://www.nuget.org/packages/DeQmaTech.DropboxSDK)<br>

**Features**
* Assemblies for .NET 4.5.2 and .NET Standard 2.0 and .NET Core 2.1
* Just one external reference (Newtonsoft.Json)
* Easy installation using NuGet
* Upload/Download tracking support
* Proxy Support
* Upload/Download cancellation support

# Functions:
* GetToken
* GetTokenFromCode
* RevokeToken
* ContactsDelete
* ContactsBatchDelete
* SpaceUsage
* UserInfo
* Copy
* CopyMultiple
* CopyMultipleStatus
* Move
* MoveMultiple
* MoveMultipleStatus
* Trash
* TrashMultiple
* TrashMultipleStatus
* Delete
* Rename
* Upload
* UploadFolder
* UploadRemote
* UploadRemoteStatus
* Metadata
* Thumbnail
* ThumbnailMultiple
* Download
* DownloadAsStream
* DownloadFolderAsZip
* CreateNewFolder
* CreateNewFolderMultiple
* ListAllFiles
* ListFolder
* ListFolderContinue
* LatestUploadedOrModifiedInFolder
* Temporary
* Link
* LinkWithSettings
* UnLink
* Metadata
* Download
* Browse
* DownloadFileFromFolder
* ListFolder
* ListContinue
* ListUser


# Code simple:
```vb.net
 Sub Get_Token()
        Dim tkn = DropboxSDK.Authorization.Get_Token(DropboxSDK.Authorization.ResponseType.token, "ApplicationKey", "https://www.mysite.com/success", "random_String", Nothing, False, False, Nothing, True)
        Process.Start(tkn)
    End Sub
```
```vb.net
    Sub SetClient()
        Dim MyClient As DropboxSDK.IClient = New DropboxSDK.DClient("token_string")
    End Sub
```
```vb.net
    Sub SetClientWithOptions()
        Dim Optians As New DropboxSDK.ConnectionSettings With {.CloseConnection = True, .TimeOut = TimeSpan.FromMinutes(30), .Proxy = New DropboxSDK.ProxyConfig With {.ProxyIP = "172.0.0.0", .ProxyPort = 80, .ProxyUsername = "myname", .ProxyPassword = "myPass", .SetProxy = True}}
        Dim MyClient As DropboxSDK.IClient = New DropboxSDK.DClient("token_string", Optians)
    End Sub
```
```vb.net
    Async Sub ListFilesAndFolders()
        Dim rootNode As New DropboxSDK.JSON.INode
        Dim result = Await MyClient.Data.ListFolder(rootNode, False, False, False, True, True, 15)
        For Each vid In result.MetadataS
            DataGridView1.Rows.Add(vid.Name, vid.Path, vid.Size, vid.Url)
        Next
    End Sub
```
```vb.net
    Async Sub DeleteAFile()
        Dim result = Await MyClient.Data.Delete(fileNode)
        DataGridView1.Rows.Add(result)
    End Sub
```
```vb.net
    Async Sub GetFileMetadata()
        Dim result = Await MyClient.Data.Metadata(fileNode, True, False, False)
        DataGridView1.Rows.Add(result.Name, result.Path, result.Dimensions_height, result.Dimensions_width, result.Size)
    End Sub
```
```vb.net
    Async Sub ShareFile()
        Dim result = Await MyClient.Share.Link(fileNode)
        DataGridView1.Rows.Add(result)
    End Sub
```
```vb.net
    Async Sub ShareFileFor4Hours()
        Dim result = Await MyClient.Share.Temporary(fileNode)
        DataGridView1.Rows.Add(result)
    End Sub
```
```vb.net
    Async Sub Upload_Local_WithProgressTracking()
        Dim UploadCancellationToken As New Threading.CancellationTokenSource()
        Dim _ReportCls As New Progress(Of DropboxSDK.ReportStatus)(Sub(ReportClass As DropboxSDK.ReportStatus)
                                                                       Label1.Text = String.Format("{0}/{1}", (ReportClass.BytesTransferred), (ReportClass.TotalBytes))
                                                                       ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                       Label2.Text = CStr(ReportClass.TextStatus)
                                                                   End Sub)
        Dim RSLT = Await MyClient.Data.Upload("J:\DB\myvideo.mp4", SentType.file, folderNode, "myvideo.mp4", WriteMode.overwrite, False, True, _ReportCls, UploadCancellationToken.Token)
    End Sub
```
```vb.net
    Async Sub DownloadFileLocateInPublicBucket_WithProgressTracking()
        Dim DownloadCancellationToken As New Threading.CancellationTokenSource()
        Dim _ReportCls As New Progress(Of DropboxSDK.ReportStatus)(Sub(ReportClass As DropboxSDK.ReportStatus)
                                                                       Label1.Text = String.Format("{0}/{1}", (ReportClass.BytesTransferred), (ReportClass.TotalBytes))
                                                                       ProgressBar1.Value = CInt(ReportClass.ProgressPercentage)
                                                                       Label2.Text = CStr(ReportClass.TextStatus)
                                                                   End Sub)
        Await MyClient.Data.Download(fileNode, "J:\DB\myvideo.mp4", _ReportCls, DownloadCancellationToken.Token)
    End Sub
```
