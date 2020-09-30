Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class FormImageCapture
    Dim CAMARA As VideoCaptureDevice
    Dim BMP As Bitmap

    Private Sub bntCamera_Click(sender As Object, e As EventArgs) Handles bntCamera.Click
        Dim CAMARAS As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If CAMARAS.ShowDialog() = DialogResult.OK Then
            CAMARA = CAMARAS.VideoDevice
            AddHandler CAMARA.NewFrame, New NewFrameEventHandler(AddressOf CAPTURAR)
            CAMARA.Start()
        End If

    End Sub

    Private Sub CAPTURAR(sender As Object, eventArgs As NewFrameEventArgs)

        BMP = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnCaptureImage_Click(sender As Object, e As EventArgs) Handles btnCaptureImage.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub

    Private Sub bntSaveImage_Click(sender As Object, e As EventArgs) Handles bntSaveImage.Click
        formUser.PictureBox1.Image = PictureBox1.Image
        Me.Close()
    End Sub
End Class