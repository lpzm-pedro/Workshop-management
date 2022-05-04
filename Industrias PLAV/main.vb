Public Class PLAV
    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        logoMain.Visible = True
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()    'limpia la pantalla antes de abrir el formulario
    End Sub
    Private Sub PedidoMaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PedidoMaterialesToolStripMenuItem.Click
        logoMain.Visible = False
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()    'limpia la pantalla antes de abrir el formulario
        Dim frmMateriales As New materiales With {.MdiParent = Me} 'crea la variable del formulario
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmMateriales) 'crea el formulario nuev
        frmMateriales.Show() 'muestra el formulario 
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            End
        End If
    End Sub
End Class
