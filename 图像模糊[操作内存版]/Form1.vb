Public Class Form1
    Private Sub TestButton_Click(sender As Object, e As EventArgs) Handles Test1.Click, Test2.Click, Test3.Click, Test4.Click
        Dim D As Integer = My.Computer.Clock.TickCount

        PictureBox1.Image = CType(sender, Button).Image
        Dim TempPicture As Bitmap = CType(sender, Button).Image
        PictureBox1.Image = 模糊图像(TempPicture, SetPixel.Value)

        '显示处理事件耗时
        MsgBox("Task finished!" & vbCrLf & "共用时： 【" & (My.Computer.Clock.TickCount - D) / 1000 & "】 秒。", MsgBoxStyle.Information)
    End Sub

    Private Function 模糊图像(ByVal InitialBitmap As Bitmap, ByVal Radius As Integer) As Bitmap
        Dim ResualtBitmap As Bitmap = New Bitmap(InitialBitmap)
        Dim ResualtBitmapData As Imaging.BitmapData = New Imaging.BitmapData
        ResualtBitmapData = ResualtBitmap.LockBits(New Rectangle(0, 0, InitialBitmap.Width, InitialBitmap.Height), Imaging.ImageLockMode.WriteOnly, ResualtBitmap.PixelFormat)
        Dim DoubleRadius As Integer = Radius * 2
        Dim DataStride As Integer = ResualtBitmapData.Stride
        Dim DataWidth As Integer = ResualtBitmapData.Width
        Dim DataHeight As Integer = ResualtBitmapData.Height
        Dim InitalDataArray(DataStride * DataHeight - 1) As Byte
        Dim DataArray(DataStride * DataHeight - 1) As Byte
        Dim Position(DoubleRadius, DoubleRadius) As Integer
        Runtime.InteropServices.Marshal.Copy(ResualtBitmapData.Scan0, InitalDataArray, 0, InitalDataArray.Length)
        Dim Index = 0, IndexX, IndexY As Integer, Round, RoundX, RoundY As Integer
        Dim ByteSum, AValue, RValue, GValue, BValue As Integer
        Dim Boundary(DataHeight) As Integer, LineIndex As Integer
        For RoundY = 0 To DoubleRadius
            Index = (RoundY - Radius) * DataWidth - Radius
            For RoundX = 0 To DoubleRadius
                Position(RoundY, RoundX) = IIf((RoundX - Radius) ^ 2 + (RoundY - Radius) ^ 2 <= Radius ^ 2, 4 * (Index + RoundX), 0)
            Next
        Next
        For IndexY = 0 To DataHeight - 1
            Boundary(IndexY + 1) = Boundary(IndexY) + DataStride
        Next
        For IndexY = 0 To DataHeight - 1
            For IndexX = 0 To DataWidth - 1
                ByteSum = 0 : AValue = 0 : RValue = 0 : GValue = 0 : BValue = 0
                Index = IndexY * DataStride + IndexX * 4
                For RoundY = 0 To DoubleRadius
                    LineIndex = IndexY + RoundY - Radius
                    If 0 <= LineIndex AndAlso LineIndex < Boundary.Count - 1 Then
                        For RoundX = 0 To DoubleRadius
                            Round = Index + Position(RoundY, RoundX)
                            If Boundary(LineIndex) <= Round AndAlso Round < Boundary(LineIndex + 1) Then
                                BValue += InitalDataArray(Round)
                                GValue += InitalDataArray(Round + 1)
                                RValue += InitalDataArray(Round + 2)
                                AValue += InitalDataArray(Round + 3)
                                ByteSum += 1
                            End If
                        Next
                    End If
                Next
                AValue /= ByteSum : RValue /= ByteSum : GValue /= ByteSum : BValue /= ByteSum
                DataArray(Index) = BValue
                DataArray(Index + 1) = GValue
                DataArray(Index + 2) = RValue
                DataArray(Index + 3) = AValue
            Next
        Next
        Runtime.InteropServices.Marshal.Copy(DataArray, 0, ResualtBitmapData.Scan0, DataArray.Length)
        ResualtBitmap.UnlockBits(ResualtBitmapData)
        Return ResualtBitmap
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim B As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.CopyFromScreen(Me.Location, New Point(0, 0), Me.Size)
        PictureBox1.Image = B
        Me.Show()
        Me.Refresh()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.Hide()
        Me.Opacity = 0
        Application.DoEvents()
        Dim B As Bitmap = New Bitmap(Me.Width, Me.Height)
        Dim G As Graphics = Graphics.FromImage(B)
        G.CopyFromScreen(Me.Location, New Point(0, 0), Me.Size)
        PictureBox1.Image = 模糊图像(B, SetPixel.Value)
        Me.Opacity = 1
        'Me.Show()
        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static B As Bitmap
        B = New Bitmap(Me.Width, Me.Height)
        Static G As Graphics
        G = Graphics.FromImage(B)
        G.CopyFromScreen(New Point(0, 0), New Point(0, 0), Me.PictureBox1.Size)
        PictureBox1.Image = 模糊图像(B, SetPixel.Value)
    End Sub
End Class
