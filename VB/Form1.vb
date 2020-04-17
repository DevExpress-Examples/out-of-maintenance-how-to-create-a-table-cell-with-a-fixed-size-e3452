Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditTableCellFixedSize
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			GenerateSampleTable()
		End Sub

		Private Sub GenerateSampleTable()
			Dim table As Table = richEditControl1.Document.Tables.Create(richEditControl1.Document.CaretPosition, 3, 3)

			' Major adjustments
			table.TableLayout = TableLayoutType.Fixed

			table.PreferredWidthType = WidthType.Fixed
			table.PreferredWidth = Units.InchesToDocumentsF(3f)

			table.Rows(1).HeightType = HeightType.Exact
			table.Rows(1).Height = Units.InchesToDocumentsF(0.25f)

			' Additional adjustments
			richEditControl1.Document.InsertText(table(1, 1).Range.Start, "Fixed Cell")
			table(1, 1).BackgroundColor = Color.LightBlue
			table(1, 1).LeftPadding = 0
		End Sub
	End Class
End Namespace