Imports dropboxSDK.JSON

Public Interface IGeneral


    Function RevokeToken(Optional token As Threading.CancellationToken = Nothing) As Task(Of Boolean)
    Function ContactsDelete() As Task(Of Boolean)
    Function ContactsBatchDelete(EmailAddresses As List(Of String)) As Task(Of Boolean)
    Function SpaceUsage() As Task(Of JSON_SpaceUsage)


End Interface
