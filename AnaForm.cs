using System;
using System.Data;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace ExcelToXML
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DataTable dt_veriler;
        private void buttonGoster_Click(object sender, EventArgs e)
        {
            string DosyaYolu;
            string DosyaAdi;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                textBox1.Text = DosyaYolu;
                DosyaAdi = file.SafeFileName;
                ExcelApp.Application excelApp = new ExcelApp.Application();

                if (excelApp == null)
                {
                    MessageBox.Show("Excel yüklü değil.");
                    return;
                }

                // seçilen excel açıldı
                ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DosyaYolu);
                // sayfayı seçtik
                ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                // tüm veri alanlarını aldık
                ExcelApp.Range excelRange = excelSheet.UsedRange;
                int satirSayisi = excelRange.Rows.Count;
                int sutunSayisi = excelRange.Columns.Count;
                dt_veriler = ToDataTable(excelRange, satirSayisi, sutunSayisi);

                dt_veriler.TableName = DosyaAdi.Split('.')[0]; // burası XML'e alabilmek için önemlidir.

                dataGridView1.DataSource = dt_veriler;
                dataGridView1.Refresh();

                excelApp.Quit();
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            }
        }
        public DataTable ToDataTable(ExcelApp.Range range, int rows, int cols)
        {
            DataTable table = new DataTable();
            try
            {
                for (int i = 1; i <= rows; i++)
                {
                    if (i == 1)
                    { // exceldeki ilk satır kolon adlarıdır.
                      // ilk satırı kolon başlıkları olarak alıyoruz.
                        for (int j = 1; j <= cols; j++)
                        {
                            // ilk satırda boş alan var m diye kontrol ediliyor.
                            if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                                table.Columns.Add(range.Cells[i, j].Value2.ToString());
                            else //boş ise standart isim veriyoruz.
                                table.Columns.Add(j.ToString() + ".Kolon");
                        }
                        continue;
                    }
                    // kolonlara göre bir tablo oluşturuyoruz.
                    // okunmuş verileri almak için yeni bir satır açıyoruz.
                    var yeniSatir = table.NewRow();
                    for (int j = 1; j <= cols; j++)
                    {
                        // hücrelerin dolu mu boş mu olduğuna bakılıyor.
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            yeniSatir[j - 1] = range.Cells[i, j].Value2.ToString();
                        else // boş hücrede hata vermesin diye boş bırakıyoruz.
                            yeniSatir[j - 1] = String.Empty;
                    }
                    table.Rows.Add(yeniSatir);
                }
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel, Tablo olarak alınamadı. Hatalar: " + Environment.NewLine + ex.ToString());
                return null;
            }
        }
        private void btn_verileri_xmle_al_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dt_veriler.WriteXml(sfd.FileName);
                    if (MessageBox.Show("XML dosyası hazırlandı. Dosya açılsın mı?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        System.Diagnostics.Process.Start(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


    }
}
