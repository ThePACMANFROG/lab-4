Option Strict On
Public Class frmCarInventory

    Private carList As New SortedList
    Private currentCarNumber As String = String.Empty
    Private editMode As Boolean = False

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car
        Dim carItem As ListViewItem

        If IsValidInput() = True Then
            editMode = True

            lbDisplay.Text = "It Worked"

            If currentCarNumber.Trim.Length = 0 Then

                car = New Car(tbModel.Text, cmbMake.Text, CInt(tbPrice.Text), CInt(cmbYear.Text), chkNew.Checked)

                carList.Add(car.IndentificationNumber.ToString(), car)
            Else
                car = CType(carList.Item(currentCarNumber), Car)

                car.Make = cmbMake.Text
                car.Model = tbModel.Text
                car.Price = CDbl(tbPrice.Text)
                car.NewC = chkNew.Checked
            End If

            lvwCar.Items.Clear()

            For Each carEntry As DictionaryEntry In carList

                carItem = New ListViewItem()

                car = CType(carEntry.Value, Car)

                carItem.Checked = car.NewC
                carItem.SubItems.Add(car.IndentificationNumber.ToString())
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Year.ToString())
                carItem.SubItems.Add(car.Price.ToString())

                lvwCar.Items.Add(carItem)
            Next carEntry


            Reset()

            editMode = False
        End If
    End Sub


    Private Sub Reset()

        tbModel.Text = String.Empty
        tbPrice.Text = String.Empty
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        chkNew.Checked = False
        lbDisplay.Text = String.Empty

        currentCarNumber = String.Empty

    End Sub


    Private Function IsValidInput() As Boolean
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        If cmbMake.SelectedIndex = -1 Then
            outputMessage += "Please select the cars make." & vbCrLf

            returnValue = False

        End If

        If tbModel.Text.Trim.Length = 0 Then

            outputMessage += "Please enter the cars model." & vbCrLf

            returnValue = False
        End If

        If tbPrice.Text.Trim.Length = 0 Then

            outputMessage += "Please enter the cars price." & vbCrLf

            returnValue = False
        End If

        If returnValue = False Then
            lbDisplay.Text = "ERRORS" & vbCrLf & outputMessage
        End If
        Return returnValue
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lvwCar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCar.ItemCheck

        If editMode = False Then

            e.NewValue = e.CurrentValue
        End If
    End Sub

    Private Sub lvwCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCar.SelectedIndexChanged

        Const identificationSubItemIndex As Integer = 1

        currentCarNumber = lvwCar.Items(lvwCar.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        Dim car As Car = CType(carList.Item(currentCarNumber), Car)

        tbModel.Text = car.Model
        tbPrice.Text = CStr(car.Price)
        cmbMake.Text = car.Make
        cmbYear.Text = CStr(car.Year)
        chkNew.Checked = car.NewC

        lbDisplay.Text = car.GetSalutation()
    End Sub

End Class
