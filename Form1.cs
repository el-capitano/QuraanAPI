using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuraanAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getSurasInfo(string url,string requestParam)
        {
            try
            {
                //lstView1.Items.Clear();
                var client = new RestClient(url);
                var request = new RestRequest(requestParam);
                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string rawResponse = response.Content;
                    var QuraanSura = JsonConvert.DeserializeObject<Suras>(rawResponse);
                    // In case you want to load the data in listview instead of datagrid view
                  /*  foreach (var item in QuraanSura.data)
                    {
                        string[] row = {item.number.ToString(),item.name,
                                    item.englishName,item.englishNameTranslation,
                                    item.numberOfAyahs.ToString(),item.revelationType };
                        ListViewItem lstView = new ListViewItem(row);

                        lstView1.Items.Add(lstView);

                    }
                  */
                    dataGridView1.DataSource = QuraanSura.data;
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void getSingleSura(string url, int requestParam)
        {
             try
               {
                
                var client = new RestClient(url);
                var request = new RestRequest(requestParam.ToString());
                var response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string rawResponse = response.Content;
                    var root = JsonConvert.DeserializeObject<AllSurasModel>(rawResponse);


                    /*  // In case you want to load the data in List View
                      foreach (var item in root.data.ayahs)
                      {
                          string[] row = { item.number.ToString(),item.text,item.numberInSurah.ToString(),
                                       item.juz.ToString(),item.manzil.ToString(), item.page.ToString(),
                                       item.ruku.ToString(),item.hizbQuarter.ToString(),item.sajda.ToString()
                          };
                          ListViewItem lstView = new ListViewItem(row);

                          lstSuraDetail.Items.Add(lstView);

                      }
                    */
                    dataGridDetails.DataSource = root.data.ayahs;
                }
           }catch(Exception e)
                {
                MessageBox.Show(e.Message);
                }
        }

        private void btnFetchAPI_Click(object sender, EventArgs e)
        {
            getSurasInfo("http://api.alquran.cloud/v1","surah");
        }

        private void btnGetSingleSura_Click(object sender, EventArgs e)
        {
            if (txtParam.Text != "")
            {
                getSingleSura("http://api.alquran.cloud/v1/surah", Convert.ToInt32(txtParam.Text));
            }
            else
            {
                MessageBox.Show("Enter Parameter: e.g Sura Number");
            }
        }
    }
}
