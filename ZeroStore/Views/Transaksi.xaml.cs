using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;

namespace ZeroStore.Views
{
    /// <summary>
    /// Interaction logic for Transaksi.xaml
    /// </summary>
    public partial class Transaksi : Page
    {
        List<Transaksi> ObjTransaksi = new List<Transaksi>();
        string unduh = @"H:\semester 3\pemrog lanjut\ZeroStore\Transaksi.xls";
        public Transaksi()
        {
            InitializeComponent();
        }

        private void BukaFile()
        {
            try 
            {
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Workbooks books = excelApp.Workbooks;
                Workbook Sheets = books.Open(unduh);
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];

            for (int j = 0; j < dgTransaksi.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[1, j + 1];
                sheet1.Cells[1, j + 1].Font.Bold = true; 
                sheet1.Columns[j + 1].ColumnWidth = 15; 
                myRange.Value2 = dgTransaksi.Columns[j].Header;
            }
            for (int i = 0; i < dgTransaksi.Columns.Count; i++)
            { 
                for (int j = 0; j < dgTransaksi.Items.Count; j++)
                {
                    TextBlock b = dgTransaksi.Columns[i].GetCellContent(dgTransaksi.Items[j]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)
                        sheet1.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }
        }
    }
}
 