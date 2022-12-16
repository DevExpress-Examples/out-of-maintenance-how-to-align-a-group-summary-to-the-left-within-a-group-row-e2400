Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid

Namespace LeftAlignSummary

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim list As List(Of Record) = New List(Of Record)()
            list.Add(New Record() With {.GroupName = "Group A", .Value = 19})
            list.Add(New Record() With {.GroupName = "Group B", .Value = 30})
            list.Add(New Record() With {.GroupName = "Group A", .Value = 15})
            list.Add(New Record() With {.GroupName = "Group C", .Value = 42})
            Me.gridControl1.ItemsSource = list
            Me.gridControl1.Columns("GroupName").GroupIndex = 0
        End Sub
    End Class

    Public NotInheritable Class HiddenSummaryTemplateSelector
        Inherits DataTemplateSelector

        Private Shared ReadOnly EmptyTemplate As DataTemplate = New DataTemplate()

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            Dim data As GridGroupSummaryData = TryCast(item, GridGroupSummaryData)
            If data.SummaryItem.SummaryType = SummaryItemType.Count Then Return EmptyTemplate
            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class

    Public Class Record

        Public Property GroupName As String

        Public Property Value As Integer
    End Class
End Namespace
