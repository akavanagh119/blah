Public Class Form1

    Private Structure Customer
        'public variables
        Public FirstName As String
        Public LastName As String
        Public Email As String
        Public ReadOnly Property Name() As String
            Get
                Return FirstName & " " & LastName
            End Get
        End Property
    End Structure

    Private objCustomer As Customer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOutput.Click
        objCustomer.FirstName = "Jim"
        objCustomer.LastName = "Johnson"
        objCustomer.Email = "JimJohnsonsemail"

        DisplayCustomer(objCustomer)
    End Sub

    Private Sub DisplayCustomer(ByVal cust As Customer)
        txtName.Text = cust.Name
        txtFirstName.Text = cust.FirstName
        txtSecondName.Text = cust.LastName
        txtEmail.Text = cust.Email

    End Sub
End Class
