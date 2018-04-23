Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Collections
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid

Namespace LeftAlignSummary
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim list As New List(Of Record)()
			list.Add(New Record() With {.GroupName = "Group A", .Value = 19})
			list.Add(New Record() With {.GroupName = "Group B", .Value = 30})
			list.Add(New Record() With {.GroupName = "Group A", .Value = 15})
			list.Add(New Record() With {.GroupName = "Group C", .Value = 42})
			gridControl1.DataSource = list
			gridControl1.Columns("GroupName").GroupIndex = 0
		End Sub
	End Class

	Public NotInheritable Class HiddenSummaryTemplateSelector
		Inherits DataTemplateSelector
		Private Shared ReadOnly EmptyTemplate As New DataTemplate()

		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			Dim data As GridGroupSummaryData = TryCast(item, GridGroupSummaryData)
			If data.SummaryItem.SummaryType = SummaryItemType.Count Then
				Return EmptyTemplate
			End If

			Return MyBase.SelectTemplate(item, container)
		End Function
	End Class

	Public Class Record
		Private privateGroupName As String
		Public Property GroupName() As String
			Get
				Return privateGroupName
			End Get
			Set(ByVal value As String)
				privateGroupName = value
			End Set
		End Property
		Private privateValue As Integer
		Public Property Value() As Integer
			Get
				Return privateValue
			End Get
			Set(ByVal value As Integer)
				privateValue = value
			End Set
		End Property
	End Class
End Namespace
