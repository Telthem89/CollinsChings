﻿Public Class Login
    Private Sub btnEx_Click(sender As Object, e As EventArgs) Handles btnEx.Click
        Application.Exit()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        If txtUser.Text = "" Then
            MsgBox("Username is required", MsgBoxStyle.Critical)

        ElseIf txtPass.Text = "" Then
            MsgBox("Password is required", MsgBoxStyle.Critical)

        Else
            sql = "SELECT * FROM `user` WHERE `username`='" & txtUser.Text & "' AND `password`='" & txtPass.Text & "' "
            bookfindthis(sql)

            If GetNumRows() = 1 Then
                MsgBox("Welcome to library System" + txtUser.Text, MsgBoxStyle.Information)
                LoadSingleResult("login")
                txtPass.Text = ""
                txtUser.Text = ""

            Else
                MsgBox("Username or Passwrord is not correct, Please try again!!")
                txtPass.Text = ""
                txtUser.Text = ""

            End If
        End If
    End Sub
End Class
