<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GENERAR_REPORTE_UBICACION
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.cbUbicacion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ALMACEN_FACTURASDataSet = New PRUEBA1_SQL_VB.ALMACEN_FACTURASDataSet()
        Me.spListaInventarioUbicacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spListaInventarioUbicacionTableAdapter = New PRUEBA1_SQL_VB.ALMACEN_FACTURASDataSetTableAdapters.spListaInventarioUbicacionTableAdapter()
        CType(Me.ALMACEN_FACTURASDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spListaInventarioUbicacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbUbicacion
        '
        Me.cbUbicacion.FormattingEnabled = True
        Me.cbUbicacion.Location = New System.Drawing.Point(134, 57)
        Me.cbUbicacion.Name = "cbUbicacion"
        Me.cbUbicacion.Size = New System.Drawing.Size(286, 21)
        Me.cbUbicacion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione unidad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(226, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Generar Reporte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        ReportDataSource1.Name = "Ubicacion"
        ReportDataSource1.Value = Me.spListaInventarioUbicacionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PRUEBA1_SQL_VB.Reporte_Ubicacion.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 152)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(825, 314)
        Me.ReportViewer1.TabIndex = 3
        '
        'ALMACEN_FACTURASDataSet
        '
        Me.ALMACEN_FACTURASDataSet.DataSetName = "ALMACEN_FACTURASDataSet"
        Me.ALMACEN_FACTURASDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spListaInventarioUbicacionBindingSource
        '
        Me.spListaInventarioUbicacionBindingSource.DataMember = "spListaInventarioUbicacion"
        Me.spListaInventarioUbicacionBindingSource.DataSource = Me.ALMACEN_FACTURASDataSet
        '
        'spListaInventarioUbicacionTableAdapter
        '
        Me.spListaInventarioUbicacionTableAdapter.ClearBeforeFill = True
        '
        'GENERAR_REPORTE_UBICACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 466)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbUbicacion)
        Me.Name = "GENERAR_REPORTE_UBICACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GENERAR_REPORTE_UBICACION"
        CType(Me.ALMACEN_FACTURASDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spListaInventarioUbicacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbUbicacion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spListaInventarioUbicacionBindingSource As BindingSource
    Friend WithEvents ALMACEN_FACTURASDataSet As ALMACEN_FACTURASDataSet
    Friend WithEvents spListaInventarioUbicacionTableAdapter As ALMACEN_FACTURASDataSetTableAdapters.spListaInventarioUbicacionTableAdapter
End Class
