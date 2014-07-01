Imports System.Text
Imports System.Net
Imports System.Security.Cryptography
Imports System.IO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmMain

    Private strApiKey As String                                         'holds the user's API key 
    Private strSecretKey As String                                      'holds the user's Secret key
    Private boolValidated As Boolean                                    'determines whether authorization has been passed


    Private Sub frmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'initialize strApiKey and strSecretKey Strings to empty on start-up
        strApiKey = ""
        strSecretKey = ""

        'set boolean variable to be false
        boolValidated = False
    End Sub

    Private Sub btnRequirements_Click(sender As System.Object, e As System.EventArgs) Handles btnRequirements.Click
        'set boolValidated to false
        boolValidated = False

        'set api and secret key, if nothing was entered, display error message and exit procedure
        If txtApiKey.Text.Equals("") = False And txtSecretKey.Text.Equals("") = False Then
            strApiKey = txtApiKey.Text
            strSecretKey = txtSecretKey.Text
        Else
            lblAuthorize.Text = "Please enter both an API key and a secret key"
            Exit Sub
        End If

        'Make the getRows call
        Dim result As HttpWebResponse = getRows()

        'Create streamReader and set it to the result's response stream
        Dim reader As StreamReader = New StreamReader(result.GetResponseStream())
        Dim content As String
        Using (reader)
            'content String to hold reader's content
            content = reader.ReadToEnd
        End Using

        'if the credentials were validated, pull the data and display the table
        If boolValidated = True Then
            'Create variables to parse the content string
            Dim t As JObject = JObject.Parse(content)                                                                   'Holds the entire JSON String
            Dim total As Integer = t("Total")                                                                           'Holds the total number of results
            Dim leftToShow As Integer = total                                                                           'holds the # of results that still need to be displayed. Initialized at total # of results to start

            'keep looping while there are still results to display (accounts for multiple pages of results)
            While leftToShow > 0
                Dim startPoint As Integer = content.IndexOf("[")                                                        'Holds the start of the string
                Dim endPoint As Integer = content.IndexOf("]")                                                          'Holds the End of the String
                Dim contentLength As Integer = ((endPoint + 1) - (startPoint + 1))                                      'Holds the length of the String

                'substring that holds the JSON values of the content String
                Dim cSub As String = content.Substring(startPoint, contentLength + 1)

                'Define variables used for next Page url
                Dim nextUrl As String
                Dim n As JObject = JObject.Parse(content)

                'Parse the array and add necessary values to the list boxes
                Dim a As JArray = JArray.Parse(cSub)
                'for each object in the Results array, pull all information and add to the lists
                For Each o As JObject In a.Children(Of JObject)()
                    frmRequirements.lstFirstName.Items.Add(o("FirstName"))
                    frmRequirements.lstLastName.Items.Add(o("LastName"))
                    frmRequirements.lstPhone.Items.Add(o("Phone"))
                    frmRequirements.lstEmail.Items.Add(o("Email"))

                    'Decrement leftToShow for each row displayed
                    leftToShow = leftToShow - 1
                Next

                'call the next page of results
                nextUrl = n("NextPage")

                'Call getMoreRows to get the next page of results
                result = getMoreRows(nextUrl)

                'Redefine reader to the new result Response Stream
                reader = New StreamReader(result.GetResponseStream())

                Using (reader)
                    'content String to hold reader's content
                    content = reader.ReadToEnd
                End Using

                'Set t to be the new parsed contents 
                t = JObject.Parse(content)

            End While

            'show the form
            frmRequirements.Show()
            'display the confirmation message
            lblAuthorize.Text = "Call Successful"
        Else
            'display the error message
            lblAuthorize.Text = "Invalid API key or Secret key. Please check to see if both keys were entered correctly."
        End If

    End Sub

    Private Sub btnAuthorize_Click(sender As System.Object, e As System.EventArgs) Handles btnAuthorize.Click
        'reset boolValidated to false to start
        boolValidated = False

        'set api and secret key, if not, display error and exit sub
        If txtApiKey.Text.Equals("") = False And txtSecretKey.Text.Equals("") = False Then
            strApiKey = txtApiKey.Text
            strSecretKey = txtSecretKey.Text
        Else
            lblAuthorize.Text = "Please enter both an API key and a secret key"
            Exit Sub
        End If

        Dim result As HttpWebResponse = makeCall(strApiKey)

        'create stream reader and set it to result's response stream
        Dim reader As StreamReader = New StreamReader(result.GetResponseStream())
        Dim content As String
        Using (reader)
            'content String to hold reader's content
            content = reader.ReadToEnd

        End Using

        If boolValidated Then
            lblAuthorize.Text = "Credentials Authorized"
        ElseIf Not boolValidated Then
            lblAuthorize.Text = "Credentials Not Authorized. Please check to see if your API key and Secret key were entered correctly."
        End If

    End Sub

    'Determines whether Api key is valid
    Private Function Authorize(ByVal Request As WebRequest, ByVal secretKey As String)
        Dim strNonceHeaderName As String = "Nonce"
        Dim strTimeStampHeaderName As String = "Timestamp"

        'Check that request has TimeStamp Header, if it doesn't add one
        If Request.Headers.AllKeys.Contains(strTimeStampHeaderName) = False Then
            Request.Headers.Add(strTimeStampHeaderName, DateTime.UtcNow.ToString("o"))
        End If

        'Check that request has Nonce Header, if it doesn't add one
        If Request.Headers.AllKeys.Contains(strNonceHeaderName) = False Then
            Request.Headers.Add(strNonceHeaderName, Guid.NewGuid().ToString())
        End If

        'Append text to the string
        Dim sb As New StringBuilder

        'Append the request method
        sb.Append(Request.Method.ToUpper() + vbCrLf)

        'Append the API URL
        sb.Append(Request.RequestUri.AbsolutePath.ToLower() + vbCrLf)

        'Append the query string
        sb.Append(Uri.UnescapeDataString(Request.RequestUri.Query) + vbCrLf)
        
        'Append the nonce and Timestamp
        sb.Append("nonce=" & Request.Headers.Get(strNonceHeaderName).ToLower() & "&timestamp=" & Request.Headers.Get(strTimeStampHeaderName).ToLower() & vbCrLf)

        'Append blank space for Request body
        sb.Append(vbCrLf)

        'Append the secret key
        sb.Append(secretKey)

        'hash the String
        Dim sha2 As SHA256 = SHA256.Create()
        Using (sha2)
            Dim hash = sha2.ComputeHash(Encoding.UTF8.GetBytes(sb.ToString()))
            Return Convert.ToBase64String(hash)
        End Using

    End Function

    'function that handles the call for authorization
    Private Function makeCall(apiKey As String)
        Dim strUriString As String

        'Create the Uri String with appended API key
        strUriString = "http://api.rightonin.com/api/v1/tables/contacts/?apiKey=" & apiKey

        'define the uri to the form of (uri, endPoint)
        Dim uri As New Uri(strUriString, UriKind.Absolute)

        Dim request As HttpWebRequest
        request = WebRequest.Create(uri)

        'set the request's method
        request.Method = "GET"

        'Call Authorize function and set it to hash
        Dim hash As String
        hash = Authorize(request, strSecretKey)

        'add the authorization header to request
        request.Headers(HttpRequestHeader.Authorization) = "ROI " & hash

        'allow return type to be of type httpWebResponse
        Dim response As HttpWebResponse
        Try
            response = request.GetResponse
            'set the boolValidated variable to true; apikey was verified
            boolValidated = True
            Return response

        Catch ex As WebException
            response = ex.Response
            Return response
        End Try

    End Function

    'Function that handles the call for getting required column info
    Private Function getRows()
        'Hold the string for the Uri to be used
        Dim strUriString As String

        'set endpoint with apikey & parameters
        strUriString = "http://api.rightonin.com/api/v1/Tables/contacts/?apiKey=" & strApiKey & "&Limit200&ID=1_"

        'Create the uri with the correct apiKey
        Dim uri As New Uri(strUriString, UriKind.Absolute)

        'Create the Request of type httpWebRequest
        Dim request As HttpWebRequest
        request = WebRequest.Create(uri)

        'set the request's method
        request.Method = "GET"

        'Call Authorize function and set it to hash
        Dim hash As String
        hash = Authorize(request, strSecretKey)

        'Add authorization header to web request
        request.Headers(HttpRequestHeader.Authorization) = "ROI " & hash

        'allow return type to be of type httpWebResponse
        Dim response As HttpWebResponse
        Try
            response = request.GetResponse

            'set the boolValidated variable to true; apikey was verified
            boolValidated = True
            Return response

        Catch ex As WebException
            response = ex.Response
            Return response
        End Try
    End Function

    'Called when there are more rows to be displayed
    Private Function getMoreRows(ByVal nu As String)
        'Hold the string for the Uri to be used
        Dim strUriString As String

        'set the endpoint with nextUrl, apikey, and parameters included
        strUriString = "http://api.rightonin.com" & nu & "?apiKey=" & strApiKey & "&Limit=200&ID=1_"

        'Create the uri with the correct apiKey
        Dim uri As New Uri(strUriString, UriKind.Absolute)

        'Create the Request of type httpWebRequest
        Dim request As HttpWebRequest
        request = WebRequest.Create(uri)

        'set the request's method
        request.Method = "GET"

        'Call Authorize function and set it to hash
        Dim hash As String
        hash = Authorize(request, strSecretKey)

        'Add the Authorization Header to the Web Request
        request.Headers(HttpRequestHeader.Authorization) = "ROI " & hash

        'allow return type to be of type httpWebResponse
        Dim response As HttpWebResponse
        Try
            response = request.GetResponse

            'set the boolValidated variable to true; apikey was verified
            boolValidated = True
            Return response

        Catch ex As WebException
            response = ex.Response
            Return response
        End Try
    End Function
End Class
