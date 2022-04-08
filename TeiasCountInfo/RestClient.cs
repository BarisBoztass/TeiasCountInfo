using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TeiasCountInfo.model;
using System.Globalization;

namespace TeiasCountInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable tablo = new DataTable();
        DataTable tabloVhsBody = new DataTable();
        DataTable tabloVhsBody2 = new DataTable();
        List<VhsRespBody> vhsResps = new List<VhsRespBody>();
        SayacInfo sayacInfo = new SayacInfo();
        bool sayacControl = false;
        bool kontrolSayacCtrl = false;
        string sayacAdi = "";
        string sayacAnaAdi = "";
        string sayacYedekAdi = "";
        bool resultTR;
        bool resultYD;


        private void button1_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();



            rClient.endPoint = "https://ws.teias.gov.tr/apigateway/osos/OsosTedarikciServiceRest/getPortfoyVhs";

            string strJSON = string.Empty;

            strJSON = rClient.makeRequest();


            debugOutput(strJSON);
        }

        private void debugOutput(string strDebugText)
        {
            string status = string.Empty;
            string errorCode = string.Empty;
            try
            {

                JObject json = JObject.Parse(strDebugText);
                status = json.GetValue("status").ToString();
                errorCode = json.GetValue("errorCode").ToString();
                if (status.Equals("True") || errorCode.Equals("")) // or eklendi
                {
                    List<PortfoyVhs> portfoyVhsResp = JsonConvert.DeserializeObject<List<PortfoyVhs>>(json.GetValue("vhsBody").ToString()); // burada hata var list to list olması gerekebilir!
                    for (int i = 0; i < portfoyVhsResp.Count; i++)
                    {
                        tablo.Rows.Add(i, portfoyVhsResp[i].bolgeMudurlugu, portfoyVhsResp[i].tesis_adi, portfoyVhsResp[i].sayac_id, portfoyVhsResp[i].sayac_adi, portfoyVhsResp[i].eic, portfoyVhsResp[i].seri_no);
                    }
                    vhsBodyGridView.DataSource = tablo;
                }


            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write("Error Message  = " + errorCode + "-->" + ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablo.Columns.Add("ID", typeof(int));
            tablo.Columns.Add("Bölge Müdürlüğü", typeof(string));
            tablo.Columns.Add("Tesis Adı", typeof(string));
            tablo.Columns.Add("Sayac Id", typeof(int));
            tablo.Columns.Add("Sayac Adı", typeof(string));
            tablo.Columns.Add("EIC", typeof(string));
            tablo.Columns.Add("Seri No", typeof(string));

            tabloVhsBody.Columns.Add("ID", typeof(int));
            tabloVhsBody.Columns.Add("EIC", typeof(string));
            tabloVhsBody.Columns.Add("Ölçüm Zamanı", typeof(DateTime));
            tabloVhsBody.Columns.Add("Periyod", typeof(int));
            tabloVhsBody.Columns.Add("Tüketim", typeof(float));
            tabloVhsBody.Columns.Add("Üretim", typeof(float));
            tabloVhsBody.Columns.Add("Çekiş Endüktif", typeof(float));
            tabloVhsBody.Columns.Add("Çekiş Kapasitif", typeof(float));
            tabloVhsBody.Columns.Add("Veriş Endüktif", typeof(float));
            tabloVhsBody.Columns.Add("Veriş Kapasitif", typeof(float));


            tabloVhsBody2.Columns.Add("ID", typeof(int));
            tabloVhsBody2.Columns.Add("EIC", typeof(string));
            tabloVhsBody2.Columns.Add("Ölçüm Zamanı", typeof(DateTime));
            tabloVhsBody2.Columns.Add("Periyod", typeof(int));
            tabloVhsBody2.Columns.Add("Tüketim", typeof(float));
            tabloVhsBody2.Columns.Add("Üretim", typeof(float));
            tabloVhsBody2.Columns.Add("Çekiş Endüktif", typeof(float));
            tabloVhsBody2.Columns.Add("Çekiş Kapasitif", typeof(float));
            tabloVhsBody2.Columns.Add("Veriş Endüktif", typeof(float));
            tabloVhsBody2.Columns.Add("Veriş Kapasitif", typeof(float));

            dgvVhsBody.DataSource = tabloVhsBody;
            dgvVhsBody2.DataSource = tabloVhsBody2;
            vhsBodyGridView.DataSource = tablo;

            // dtpBasTar.Value = dtpBitTar.Value.AddDays(-1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestClient rClient = new RestClient();

            rClient.endPoint = "https://ws.teias.gov.tr/apigateway/osos/OsosTedarikciServiceRest/getOsosMeteringPointDataVhs";

            string strJSON = string.Empty;
            MeteringPointDataReq meteringPointDataReq = new MeteringPointDataReq();
            SayacEicList eicList = new SayacEicList();
            meteringPointDataReq.baslangicDt = dtpBasTar.Value;
            meteringPointDataReq.bitisDt = dtpBitTar.Value;
            string a = cmbPeriod.SelectedItem.ToString();
            if (a.Trim().Equals("15 Dakika"))
            {
                meteringPointDataReq.period = 15;
            }
            else
            {
                meteringPointDataReq.period = 60;
            }
            List<SayacEicList> eicLists = new List<SayacEicList>();
            string b = lstBoxEicCode.Items[0].ToString();
            for (int i = 0; i < lstBoxEicCode.Items.Count; i++)
            {
                eicList.eic = lstBoxEicCode.Items[i].ToString();
                eicLists.Add(eicList);

            }
            meteringPointDataReq.sayacEicLists = eicLists;
            //eicList.eic = eicLists;
            //meteringPointDataReq.sayacEicLists = eicList;





            strJSON = rClient.makePostRequest(meteringPointDataReq);


            postOutput(strJSON);
        }

        private void vhsBodyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lstBoxEicCode.Items.Add(vhsBodyGridView.CurrentRow.Cells["EIC"].Value.ToString());
            sayacAdi = vhsBodyGridView.CurrentRow.Cells["Sayac Adı"].Value.ToString();
            resultTR = sayacAdi.Contains("TRANS");
            resultYD = sayacAdi.Contains("YEDEK");

            if (resultTR)
            {
                sayacAnaAdi = "TR" + sayacAdi.Substring(sayacAdi.Length - 1);
            }
            if (resultYD)
            {
                sayacYedekAdi = "YD" + sayacAdi.Substring(sayacAdi.Length - 1);
            }
        }

        private void lstBoxEicCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBoxEicCode.Items.Remove(lstBoxEicCode.SelectedItem);
        }

        private void postOutput(string strDebugText)
        {
            string status = string.Empty;
            string errorCode = string.Empty;

            try
            {

                JObject json = JObject.Parse(strDebugText);
                status = json.GetValue("status").ToString();
                errorCode = json.GetValue("errorCode").ToString();
                if (status.Equals(true) || errorCode.Equals(""))
                {
                    vhsResps = JsonConvert.DeserializeObject<List<VhsRespBody>>(json.GetValue("vhsBody").ToString());
                    anaSayac(vhsResps);
                    KontrolSayac(vhsResps);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Message  = " + errorCode + "-->" + ex.Message, ToString() + Environment.NewLine);
                //System.Diagnostics.Debug.Write("Error Message  = " + errorCode + "-->" + ex.Message, ToString() + Environment.NewLine);
            }
        }

        private void cmbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private SayacInfo convertVhsRespBodyToSayacInfo(VhsRespBody vhsResp)
        {
            SayacInfo sayacInf = new SayacInfo();

            if (vhsResp != null)
            {

                sayacInf.eic = vhsResp.eic;
                sayacInf.olcumZamani = vhsResp.olcumZamani;
                sayacInf.period = vhsResp.period;
                sayacInf.tuketim = vhsResp.tuketim;
                sayacInf.uretim = vhsResp.uretim;
                sayacInf.cekisEnduktif = vhsResp.cekisEnduktif;
                sayacInf.cekisKapasitif = vhsResp.cekisKapasitif;
                sayacInf.verisEnduktif = vhsResp.verisEnduktif;
                sayacInf.verisKapasitif = vhsResp.verisKapasitif;
            }

            return sayacInf;

        }

        private void anaSayac(List<VhsRespBody> vhsResps)
        {
            dgvVhsBody.DataSource = null;
            dgvVhsBody.ClearSelection();
            dgvVhsBody.Refresh();
            tabloVhsBody.Clear();
            List<SayacInfo> anaSayac = new List<SayacInfo>();
            if (vhsResps[0].eic.StartsWith("40"))
            {
                sayacAnaAdi = sayacAnaAdi + "_ANA_" + DateTime.Now.ToString("yyyy-MM");
            }
            for (int j = 0; j < vhsResps.Count; j++)
            {
                if (vhsResps[j].eic.StartsWith("40"))
                {
                    sayacInfo = convertVhsRespBodyToSayacInfo(vhsResps[j]);
                    anaSayac.Add(sayacInfo);
                }

            }
            for (int i = 0; i < anaSayac.Count; i++)
            {
                tabloVhsBody.Rows.Add(i, anaSayac[i].eic, anaSayac[i].olcumZamani, anaSayac[i].period, anaSayac[i].tuketim, anaSayac[i].uretim
                    , anaSayac[i].cekisEnduktif, anaSayac[i].cekisKapasitif, anaSayac[i].verisEnduktif, anaSayac[i].verisKapasitif);
            }
            dgvVhsBody.DataSource = tabloVhsBody;
            sayacControl = true;

        }

        private void KontrolSayac(List<VhsRespBody> vhsResps)
        {
            dgvVhsBody2.DataSource = null;
            dgvVhsBody2.ClearSelection();
            dgvVhsBody2.Refresh();
            tabloVhsBody2.Clear();
            List<SayacInfo> kontrolSayac = new List<SayacInfo>();
            if (vhsResps[vhsResps.Count - 1].eic.StartsWith("80"))
            {
                sayacYedekAdi = "YD" + sayacAdi.Substring(sayacAdi.Length - 1) + "_ANA_" + DateTime.Now.ToString("yyyy-MM");

            }
            for (int j = 0; j < vhsResps.Count; j++)
            {
                if (vhsResps[j].eic.StartsWith("80"))
                {
                    sayacInfo = convertVhsRespBodyToSayacInfo(vhsResps[j]);
                    kontrolSayac.Add(sayacInfo);
                }

            }
            for (int i = 0; i < kontrolSayac.Count; i++)
            {
                tabloVhsBody2.Rows.Add(i, kontrolSayac[i].eic, kontrolSayac[i].olcumZamani, kontrolSayac[i].period, kontrolSayac[i].tuketim, kontrolSayac[i].uretim
                    , kontrolSayac[i].cekisEnduktif, kontrolSayac[i].cekisKapasitif, kontrolSayac[i].verisEnduktif, kontrolSayac[i].verisKapasitif);
            }
            dgvVhsBody2.DataSource = tabloVhsBody2;
            kontrolSayacCtrl = true;
        }

        private void btnExcelAl_Click(object sender, EventArgs e)
        {

            exceleAktar(dgvVhsBody, dgvVhsBody2);
            fileSave();



        }
        private void exceleAktar(DataGridView dataGridView, DataGridView dataGridView2)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Visible = true;

            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Worksheet sheet2 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[2];


            int StartCol = 1;

            int StartRow = 1;

            int StartCol2 = 1;

            int StartRow2 = 1;


            sheet1.Name = sayacAnaAdi;
            sheet2.Name = sayacYedekAdi;
            for (int j = 0; j < dataGridView.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView.Columns[j].HeaderText;
            }


            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {

                Microsoft.Office.Interop.Excel.Range myRange2 = (Microsoft.Office.Interop.Excel.Range)sheet2.Cells[StartRow2, StartCol2 + j];
                myRange2.Value2 = dataGridView2.Columns[j].HeaderText;
            }


            StartRow++;


            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {

                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView[j, i].Value == null ? "" : dataGridView[j, i].Value.ToString();

                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Excele alırken hata Oluştu" + ex.Message);

                    }

                }

            }

            StartRow2++;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {

                    try
                    {

                        Microsoft.Office.Interop.Excel.Range myRange2 = (Microsoft.Office.Interop.Excel.Range)sheet2.Cells[StartRow2 + i, StartCol2 + j];
                        myRange2.Value2 = dataGridView2[j, i].Value == null ? "" : dataGridView2[j, i].Value.ToString();


                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("Excele alırken hata Oluştu" + ex.Message);

                    }

                }


            }



        }

        private void selectExcelAktar(DataGridView dataGridView)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j <= dataGridView.ColumnCount - 1; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];

                myRange.Value2 = dataGridView.Columns[j].HeaderText;
            }
            StartRow++;
            for (int x = 0; x < dataGridView.SelectedRows.Count; x++)
            {
                for (int j = 0; j < dataGridView.SelectedRows[x].Cells.Count; j++)
                {

                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                    myRange.Value2 = dataGridView.SelectedRows[x].Cells[j].Value == null ? "" : dataGridView.SelectedRows[x].Cells[j].Value;
                }
                StartRow++;

            }
        }

        private void selectExcel_Click(object sender, EventArgs e)
        {





        }


        private void fileSave()
        {
            if (lblFile.Text == "")
            {
                MessageBox.Show("Dosya Yolunu Seçiniz");
            }
            else
            {
                DialogResult res = MessageBox.Show(lblFile.Text + "Dosyayı Kaydetmek İstiyor musunuz?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {

                    SaveFileDialog save = new SaveFileDialog();
                    save.OverwritePrompt = true;
                    save.CreatePrompt = true;
                    save.InitialDirectory = lblFile.Text;
                    save.Title = "Excel Dosyaları";
                    save.DefaultExt = ".xlsx";
                    if (resultTR)
                    {
                        save.FileName = sayacAnaAdi;
                    }
                    if (resultYD)
                    {
                        save.FileName = sayacYedekAdi;
                    }

                    save.ShowDialog();
                }
                if (res == DialogResult.Cancel)
                {
                    MessageBox.Show("Dosya Kaydedilmedi");
                    //Some task…
                }
            }
        }



        private void btnFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "Custom Description";



            if (fbd.ShowDialog() == DialogResult.OK)

            {

                string sSelectedPath = fbd.SelectedPath;
                lblFile.Text = sSelectedPath;

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpBasTar_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
