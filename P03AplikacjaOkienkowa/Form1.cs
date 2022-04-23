using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03AplikacjaOkienkowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            PolaczenieZBaza pzb = new PolaczenieZBaza();

            object[][] wynik= pzb.WyslijPolecenieSQL(txtPolecenieSQL.Text);

            dgvDane.Rows.Clear();
            dgvDane.ColumnCount = wynik[0].Length;
            for (int i = 0; i < wynik.Length; i++)
                dgvDane.Rows.Add(wynik[i]);


        }
    }
}
