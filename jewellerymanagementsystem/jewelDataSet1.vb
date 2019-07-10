Partial Class jewelDataSet1
    Partial Class suppliersDataTable

        Private Sub suppliersDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.emailidColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace jewelDataSet1TableAdapters

    Partial Public Class adminsTableAdapter
    End Class
End Namespace
