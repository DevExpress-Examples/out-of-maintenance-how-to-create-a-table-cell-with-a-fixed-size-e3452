using System.Drawing;
using System.Windows.Forms;
using DevExpress.Office.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditTableCellFixedSize {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            GenerateSampleTable();
        }

        private void GenerateSampleTable() {
            Table table = richEditControl1.Document.Tables.Add(richEditControl1.Document.CaretPosition, 3, 3);

            // Major adjustments
            table.TableLayout = TableLayoutType.Fixed;
            
            table.PreferredWidthType = WidthType.Fixed;
            table.PreferredWidth = Units.InchesToDocumentsF(3f);

            table.Rows[1].HeightType = HeightType.Exact;
            table.Rows[1].Height = Units.InchesToDocumentsF(0.25f);

            // Additional adjustments
            richEditControl1.Document.InsertText(table[1, 1].Range.Start, "Fixed Cell");
            table[1, 1].BackgroundColor = Color.LightBlue;
            table[1, 1].LeftPadding = 0;
        }
    }
}