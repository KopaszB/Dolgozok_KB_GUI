﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_dolgozok
{
    public partial class Form1 : Form
    {
        List<Dolgozo> dolgozok = new List<Dolgozo>();
        Adatbazis db = new Adatbazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaFrissitese();
        }

        private void listaFrissitese()
        {
            listBox_dolgozok.Items.Clear();
            dolgozok = db.getAllDolgozo();
        }
    }
}
