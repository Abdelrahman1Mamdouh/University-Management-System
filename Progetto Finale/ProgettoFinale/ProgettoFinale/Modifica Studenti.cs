using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoFinale
{
    public partial class Form4 : Form
    {


        private Studente studenteOriginale;
        public Studente studenteModificato { get; private set; }

        public Form4(Studente studente)
        {
            InitializeComponent();
            studenteOriginale = studente;
            MatricolaS4.Text = studente.CodiceMatricola;
            Sid4.Text = studente.Id;
            Snome4.Text = studente.Nome;
            SCognome4.Text = studente.Cognome;
            SEmail4.Text = studente.Email;
            STelefono4.Text = studente.Telefono;

        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studenteModificato = new Studente
            {
                CodiceMatricola=MatricolaS4.Text,
                Id = Sid4.Text,
                Nome= Snome4.Text,
                Cognome=SCognome4.Text,
                Email=SEmail4.Text,
                Telefono=STelefono4.Text
            };

            this.DialogResult= DialogResult.OK;
            this.Close();
        }

        

       
    }
}
