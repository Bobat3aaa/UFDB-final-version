Imports System.Text.RegularExpressions

Public Class usermanagement
    Public Property UserID As Integer 'holds user id
    Public Property username As String 'holds their username
    Public Property password As String 'holds the encrypted password
    Public Property passwordlength As Integer 'holds the original length of the password
    Public Property age As Integer 'holds their age
    Public Property email As String 'holds email

    Public Property Admin As Boolean 'determines whether account is an admin or not


    Public Sub New(userid As Integer, username As String, password As String, passwordlength As Integer, age As Integer, email As String, admin As Boolean)   'constructs new user

        Me.UserID = userid
        Me.username = username
        Me.age = age
        Me.password = password
        Me.passwordlength = passwordlength
        Me.email = email
        Me.Admin = admin
    End Sub

    Public Function changeuserdetails(username As String, age As String, email As String) 'method to change user details specfically for user detail form and adding a user to userdetails
        Me.username = username
        Me.age = age
        Me.email = email
    End Function

End Class


