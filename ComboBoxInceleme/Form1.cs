﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBoxInceleme
{
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            // Items.Add metotu kullanılarak değerler combobox eklendi.. 
            // comboBoxDoldurV1();
            comboBoxDoldurV2();
        }

        private void comboBoxDoldurV2()
        {
            //To string ile object ezilmezse bu şekildede gösterilebilir
            //cmbUrunListe.DisplayMember = "urunAdi";
            cmbUrunListe.DataSource = database.UrunTablo;
        }

        void comboBoxDoldurV1()
        {
            foreach (var item in database.UrunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }

        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Yontem 
            object o1 = cmbUrunListe.SelectedItem;
            urun u1 = (urun)o1;

            // u1 = cmbUrunListe.SelectedItem == null ? null : cmbUrunListe.SelectedItem as urun;

            // 2.Yontem 

            //ComboBox secilenCombobox = sender as ComboBox;

            // 1. yontem eğer form içerisinde bulunan form elemanına özel bir metoto yazıldı ise o zaman ilgil form elemananını direkt olarak çağırmak daha mantıklıdır. 

            // 2. yontem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine tıklandığını veya işlem yapıldığını bilmediğimiz için ve metotumuz birden fazla form elemanında olay metotu olarak tanımlandığı için biz sender üzerinden gelen nesneyi kullanır kullanıcnın hangi windows form elemanında işlem yapmış olduğunu anlarız... 

            pctUrunResim.Image = Image.FromFile(u1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = u1.urunAdi;
            txtKategori.Text = u1.urunKategori;
            txtStokAdet.Text = u1.stokAdet.ToString();
            txtYazar.Text = u1.yazar;
            txtUrunAciklama.Text = u1.aciklama;



        }

    
    }
}
