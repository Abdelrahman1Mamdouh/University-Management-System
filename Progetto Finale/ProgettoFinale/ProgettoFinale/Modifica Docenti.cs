using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoFinale
{
    public partial class Form6 : Form
    {
        private Docente docenteOriginale;
        public Docente docenteModificato { get; private set; }
        public Form6(Docente d)
        {
            InitializeComponent();
            comboDipartimento.DataSource = Enum.GetValues(typeof(Dipartimento));
            comboDipartimento.DropDownStyle = ComboBoxStyle.DropDownList;

            docenteOriginale = d;
            comboDipartimento.SelectedItem = d.materia;
            Dnome6.Text=d.Nome;
            DCognome6.Text=d.Cognome;
            Did6.Text=d.Id;
            DEmail6.Text=d.Email;
            DTelefono6.Text=d.Telefono;


        }


        private void Form6_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            docenteModificato= new Docente 
            {
                materia = (Dipartimento)comboDipartimento.SelectedItem,
                Nome = Dnome6.Text,
                Cognome = DCognome6.Text,
                Id = Did6.Text,
                Email = DEmail6.Text,
                Telefono= DTelefono6.Text



            };
            this.DialogResult= DialogResult.OK;
            this.Close();
        }
    }
}
