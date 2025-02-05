Imports System.Drawing.Text
Imports System.Drawing


Module Customfonts
    Public customfontcollection As New PrivateFontCollection
    Public Sub loadcustomfonts()
        Dim font1 As String = Application.StartupPath & "\Fonts\ClashDisplay-Bold.otf"
        Dim font2 As String = Application.StartupPath & "\Fonts\ClashDisplay-Regular.otf"
        Dim font3 As String = Application.StartupPath & "\Fonts\Supreme-Regular.otf"

        If IO.File.Exists(font1) Then customfontcollection.AddFontFile(font1)
        If IO.File.Exists(font2) Then customfontcollection.AddFontFile(font2)
        If IO.File.Exists(font3) Then customfontcollection.AddFontFile(font3)

    End Sub
End Module
