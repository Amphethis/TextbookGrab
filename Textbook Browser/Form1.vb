Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pnumber As String = CStr(Int(InputBox("input page number.")) + 10)
        For i = 1 To 3 - Len(pnumber)
            pnumber = "0" & pnumber
        Next
        Process.Start(String.Format("{0}{1}{2}", "https://my.dynamic-learning.co.uk/Titles/AQAALComSciWeT_9781471839542/Content/OEBPS/page", pnumber, ".xhtml"))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pnumber, pnumber2 As String
        pnumber = InputBox("Starting page number (even, please).")
        pnumber2 = CStr(Int(pnumber) + 1)
        For i = 1 To 4 - (Len(pnumber))
            pnumber = "0" & pnumber
            pnumber2 = "0" & pnumber2
        Next
        pnumber = pnumber & "-" & pnumber2
        Process.Start(String.Format("{0}{1}{2}", "https://my.dynamic-learning.co.uk/ViewPage.aspx?i=8b80f129-15b2-478b-9059-24781966b43d&tid=4C571ECD-DFED-4A4A-8DB0-CC4642652A0A&fn=dps", pnumber, ".swf&pf=0&exsrc=lp&u=786c943e-4f53-42d3-94ee-48da3aaddf60&vle=true&r=false&stb=false"))
    End Sub
End Class

'https://my.dynamic-learning.co.uk/Titles/AQAALComSciWeT_9781471839542/Content/OEBPS/page020.xhtml
'                                                                                        XXX <- edit for page (example - p20)
'https://my.dynam"))ic-learning.co.uk/ViewPage.aspx?i=8b80f129-15b2-478b-9059-24781966b43d&tid=4C571ECD-DFED-4A4A-8DB0-CC4642652A0A&fn=dps0008-0009.swf&pf=0&exsrc=lp&u=786c943e-4f53-42d3-94ee-48da3aaddf60&vle=true&r=false&stb=false
'                                                                                                                                    XXXX-XXXX <- Edit for pages (example - p8-p9)

