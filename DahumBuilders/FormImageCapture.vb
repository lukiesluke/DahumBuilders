Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class FormImageCapture
    Dim videoCapture As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub bntCamera_Click(sender As Object, e As EventArgs) Handles bntCamera.Click
        Dim captureDeviceForm As VideoCaptureDeviceForm = New VideoCaptureDeviceForm()
        If captureDeviceForm.ShowDialog() = DialogResult.OK Then
            videoCapture = captureDeviceForm.VideoDevice
            AddHandler videoCapture.NewFrame, New NewFrameEventHandler(AddressOf camera_capture)
            videoCapture.Start()
        End If
    End Sub

    Private Sub camera_capture(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnCaptureImage_Click(sender As Object, e As EventArgs) Handles btnCaptureImage.Click
        PictureBox2.Image = PictureBox1.Image
    End Sub

    Private Sub bntSaveImage_Click(sender As Object, e As EventArgs) Handles bntSaveImage.Click
        fileLocationImage = "Z:\luke.jpg"
        PictureBox2.Image.Save(fileLocationImage, Imaging.ImageFormat.Jpeg)

        formUser.PictureBox1.Image = PictureBox2.Image
        Me.Close()
    End Sub
End Class