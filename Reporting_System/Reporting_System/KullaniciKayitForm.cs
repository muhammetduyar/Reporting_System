﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using MetroSet_UI.Forms;

namespace Reporting_System
{
    public partial class KullaniciKayitForm : MetroSetForm
    {
        public KullaniciKayitForm()
        {
            InitializeComponent();
        }
        Database_Process dt_Procs = new Database_Process();
        NpgsqlConnection baglan = new Database_Process().db_Baglanti("localhost", "db_Reporting_System", "postgres", "1234");
        private void kayit_ekle_Btn_Click(object sender, EventArgs e)
        {
            dt_Procs.KullaniciEkle(yetki_ChckBx.Checked,kID_TxtBx,kadi_TxtBx, sifre_TxtBx, baglan);
        }
    }
}
