Public Class Form1
#Region "Globales"

#End Region

#Region "Métodos y Funciones"

#End Region

#Region "Eventos"

    ''' <summary>
    ''' Setup COM on default values.
    ''' Load combo with coms ports availables.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set baud rate on default
        cboBaud.SelectedIndex = 2

        'Set parity on default
        cboParity.SelectedIndex = 1

        'List ports on combo box
        For Each sp As String In My.Computer.Ports.SerialPortNames
            cboPtos.Items.Add(sp)
        Next

        'Handle Errors
        Try
            'Set port on default
            cboPtos.SelectedIndex = 0

            'Enable Test button
            BtnTestCOM.Enabled = True

        Catch ex As Exception

            'Show error message
            MsgBox("No se pudo abrir el puerto serial. Por favor verifique que el puerto este conectado y que el driver de Windows este instalado.", MsgBoxStyle.Critical, "Error")

        End Try

    End Sub

    ''' <summary>
    ''' Try open serial port and test if it is open.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtnTestCOM_Click(sender As Object, e As EventArgs) Handles BtnTestCOM.Click

        'Setup serial port
        Dim sp As IO.Ports.SerialPort = Nothing

        'Handle Errors
        Try

            With sp
                sp.PortName = cboPtos.SelectedItem.ToString
                sp.BaudRate = cboBaud.SelectedItem
                sp.Parity = IO.Ports.Parity.Even
                sp.DataBits = 7
                sp.StopBits = IO.Ports.StopBits.One
                sp.Handshake = IO.Ports.Handshake.None
                sp.ReadTimeout = 1000
                sp.RtsEnable = True
                sp.DtrEnable = True
                sp.Open()
                sp.Close()

            End With
            'Show message
            MsgBox("El puerto serial se abrió correctamente.", MsgBoxStyle.Information, "Información")
        Catch ex As Exception
            'Show error message
            MsgBox("No se pudo abrir el puerto serial. Por favor verifique que el puerto este conectado y que el driver de Windows este instalado.", MsgBoxStyle.Critical, "Error")
        End Try



    End Sub

#End Region


End Class
