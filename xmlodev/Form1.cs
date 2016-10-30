using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xmlodev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

            doc.Load("Urunler.xml");

            var urunElements = doc.GetElementsByTagName("Urun");
            List<Urun> urunlerListesi = new List<Urun>();

            foreach (XmlElement siradakiElement in urunElements)
            {
                var siradakiElementOzellikleri = "";

                Urun yeniUrun = new Urun();

                yeniUrun.Id = Convert.ToInt32(siradakiElement.Attributes["Id"].Value);

                yeniUrun.Ad = siradakiElement.Attributes["Ad"].Value;

                yeniUrun.Fiyat = string.IsNullOrEmpty (siradakiElement.Attributes["Fiyat"].Value) ? 0m : (Convert.ToDecimal(siradakiElement.Attributes["Fiyat"].Value));

                yeniUrun.KategoriAdi = siradakiElement.Attributes["KategoriAdi"].Value;

                urunlerListesi.Add(yeniUrun);



                //foreach (XmlAttribute siradakiAttr in siradakiElement.Attributes)
                //{
                //    siradakiElementOzellikleri += siradakiAttr.Value + "\t";
                //}

                //lsbUrunler.Items.Add(siradakiElementOzellikleri);
                lsbUrunler.DataSource = urunlerListesi;
                lsbUrunler.DisplayMember = "Ad";


                
                    

            }
        }

        public class Urun
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public decimal Fiyat { get; set; }
            public string KategoriAdi { get; set; }
        }
    }
}
