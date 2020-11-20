using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSApplication
{
    public partial class Form1 : Form
    {
        private string RssTxt
        {
            get
            {
                return @"\RssList.txt";
            }
           
        }
        public Form1()
        {
            InitializeComponent();
            comboBoxRssUrlAddNewItem();
        }

        private void comboBoxRssUrlAddNewItem()
        {
            string currentDirectoryPath = Directory.GetCurrentDirectory();

            string dosya_yolu = currentDirectoryPath +RssTxt ;

            if (!File.Exists(dosya_yolu))
            {
                string item1 = "http://feeds.feedburner.com/scitechdaily?format=xml";
                List<string> items = new List<string>();
                items.Add(item1);
                using (var stream = File.Create(dosya_yolu))
                {
                    using (TextWriter tw = new StreamWriter(stream))
                    {

                        tw.WriteLine(item1);
                    }
                }
                comboBoxRssUrl.DataSource = items;
            }
            else
            {
                comboBoxRssUrl.DataSource = File.ReadAllLines(dosya_yolu);

            }
        }

        private void BtnGetir_Click(object sender, EventArgs e)
        {
            List<Haber> Kayitlar = XMLCevir();
            lstHaberBasliklari.DataSource = Kayitlar;
        }
        private List<Haber> XMLCevir()
        {
            List<Haber> HaberKayitlar = new List<Haber>();
            XDocument XMLKaynak = XDocument.Load(comboBoxRssUrl.Text);
            List<XElement> Rows = XMLKaynak.Descendants("item").ToList();
            foreach (XElement item in Rows)
            {
                Haber temp = new Haber();
                temp.Baslik = item.Element("title").Value ;
                temp.Link = item.Element("link").Value;
                temp.Aciklama = item.Element("description").Value;
                HaberKayitlar.Add(temp);
            }

            return HaberKayitlar;

        }

        private void LstHaberBasliklari_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listbx = sender as ListBox;
            Haber hbr = (Haber)listbx.SelectedItem;
            webBrowser.DocumentText = hbr.Aciklama;
        }

        private void btnRssAdd_Click(object sender, EventArgs e)
        {
            string currentDirectoryPath = Directory.GetCurrentDirectory();
            string dosya_yolu = currentDirectoryPath + RssTxt;
            string appendText = txtRss.Text + Environment.NewLine;
            File.AppendAllText(dosya_yolu, appendText);
            txtRss.Text = "";
            comboBoxRssUrl.DataSource = File.ReadAllLines(dosya_yolu);
        }
    }
}
