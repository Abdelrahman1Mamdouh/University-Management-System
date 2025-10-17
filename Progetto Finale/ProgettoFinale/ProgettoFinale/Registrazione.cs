using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProgettoFinale
{
    public partial class Registrazione : Form
    {
        private Form1 mainForm;
        public Registrazione(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void Registra_Click(object sender, EventArgs e)
        {



            if (radioStudente.Checked) {

                List<Studente> listaStudenti = new List<Studente>();
                Studente s = new Studente();



                s.CodiceMatricola = Matricola.Text;
                s.Id = Sid.Text;
                s.Nome = Snome.Text;
                s.Cognome = SCognome.Text;
                s.Email = SEmail.Text;
                s.Telefono = STelefono.Text;

                if (Matricola.Text=="" || Sid.Text=="" || SCognome.Text=="" || Snome.Text=="" || SEmail.Text=="" || STelefono.Text=="") { MessageBox.Show("Dati non inseriti!"); return; }

            listaStudenti.Add(s);

            string fileName = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json";

            var leggi = File.ReadAllText(fileName);
            var js = JsonSerializer.Deserialize<List<Studente>>(leggi);
            js.Add(s);
            var json = JsonSerializer.Serialize(js);
            File.WriteAllText(fileName, json);

            griglia.DataSource = js;
            griglia.Visible = true;
            griglia.AllowUserToAddRows = false;


            MessageBox.Show($"Registrazione effetuata{s.ToString()}");
            mainForm.RefreshStudenti();
            }

            else if (radioDocente.Checked)
            {
                List<Docente> listaDocenti = new List<Docente>();

                Docente prof = new Docente();
                prof.materia = (Dipartimento)comboDipartimento.SelectedItem;
                prof.Nome = Snome.Text;
                prof.Cognome = SCognome.Text;
                prof.Id = Sid.Text;
                prof.Email = SEmail.Text;
                prof.Telefono = STelefono.Text;

                if (Sid.Text=="" || SCognome.Text=="" || Snome.Text=="" || SEmail.Text=="" || STelefono.Text=="") { MessageBox.Show("Dati non inseriti!"); return; }

                listaDocenti.Add(prof);


                string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";

                var leggi = File.ReadAllText(path);
                var js = JsonSerializer.Deserialize<List<Docente>>(leggi);
                js.Add(prof);
                var json = JsonSerializer.Serialize(js);
                File.WriteAllText(path, json);

                griglia.Visible = true;
                griglia.AllowUserToAddRows = false;
                griglia.DataSource = js;
                griglia.ReadOnly = true;

                MessageBox.Show($"Registrazione effetuata{prof.ToString()}");
                mainForm.RefreshDocenti();


            }
        }


        private void Cancella_Click(object sender, EventArgs e)
        {
            Sid.Text = "";
            Snome.Text = "";
            SCognome.Text = "";
            SEmail.Text = "";
            STelefono.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioStudente.Checked)
            {
                labelExtra.Text = "Matricola";
                labelExtra.Visible = true;

                Matricola.Visible = true;
                comboDipartimento.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelExtra.Visible = false;
            Matricola.Visible = false;
            comboDipartimento.Visible = false;
            comboDipartimento.DataSource = Enum.GetValues(typeof(Dipartimento));
            comboDipartimento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void radioDocente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioDocente.Checked)
            {
                labelExtra.Text = "Dipartimento";
                labelExtra.Visible = true;

                Matricola.Visible = false;
                comboDipartimento.Visible = true;
            }
        }
    }
}
