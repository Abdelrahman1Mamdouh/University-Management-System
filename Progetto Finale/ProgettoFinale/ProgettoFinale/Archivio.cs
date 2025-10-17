    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace ProgettoFinale
    {
        public partial class Archivio : Form
        {
            private Form1 mainForm;
            public Archivio(Form1 mainForm)
            {
                InitializeComponent();
                this.mainForm = mainForm;
            }

            private void Form8_Load(object sender, EventArgs e)
            {
                dataGridView1.DataSource = null;


            }
            private List<Studente> studenti = new List<Studente>();
            private List<Docente> docenti = new List<Docente>();
            private List<Corso> corsi = new List<Corso>();
            private string currentType = "";


            private void LoadStudenti()
            {
                string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json";
                if (File.Exists(path))
                {


                    var leggi = File.ReadAllText(path);
                
                    studenti = JsonSerializer.Deserialize<List<Studente>>(leggi);
                    currentType="Studente";
                    dataGridView1.DataSource = studenti;
                    dataGridView1.Visible = true;
                    AddButtonColumns();
                }
            }

            private void LoadDocenti()
            {
                string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json";
                if (File.Exists(path))
                {


                    var leggi = File.ReadAllText(path);
                
                    docenti = JsonSerializer.Deserialize<List<Docente>>(leggi);
                    currentType="Docente";
                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = docenti;
                    AddButtonColumns();
                }
            }

            private void LoadCorsi()
            {
                string path = @"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json";
                if (File.Exists(path))
                {
                    var json = File.ReadAllText(path);
                    corsi = JsonSerializer.Deserialize<List<Corso>>(json);
                    dataGridView1.DataSource = corsi;
                    currentType="Corso";


                    if (dataGridView1.Columns.Contains("Prof"))
                        dataGridView1.Columns["Prof"].Visible = false;

                    if (dataGridView1.Columns.Contains("DisplayProf"))
                        dataGridView1.Columns["DisplayProf"].DisplayIndex = 0;
                    AddButtonColumns();
                }
            }

            private void AddButtonColumns()
            {
                if (dataGridView1.Columns["ModificaCol"] == null)
                {
                    DataGridViewButtonColumn Modifica = new DataGridViewButtonColumn();
                    Modifica.Name = "ModificaCol";
                    Modifica.Text = "Modifica";
                    Modifica.HeaderText = "Modifica";
                    Modifica.UseColumnTextForButtonValue = true;
                    Modifica.FlatStyle = FlatStyle.Flat;
                    Modifica.DefaultCellStyle.BackColor = Color.Green;
                    Modifica.DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Columns.Add(Modifica);

                }

                if (dataGridView1.Columns["CancellaCol"] == null)
                {
                    DataGridViewButtonColumn Cancella = new DataGridViewButtonColumn();
                    Cancella.Name = "CancellaCol";
                    Cancella.Text = "Cancella";
                    Cancella.HeaderText = "Cancella";
                    Cancella.UseColumnTextForButtonValue = true;
                    Cancella.FlatStyle = FlatStyle.Flat;
                    Cancella.DefaultCellStyle.BackColor = Color.Red;
                    Cancella.DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Columns.Add(Cancella);



                }

                if (dataGridView1.Columns.Contains("ModificaCol"))
                {
                    dataGridView1.Columns["ModificaCol"].DisplayIndex = dataGridView1.Columns.Count-1;
                }

                if (dataGridView1.Columns.Contains("CancellaCol"))
                {
                    dataGridView1.Columns["CancellaCol"].DisplayIndex = dataGridView1.Columns.Count-1;
                }
            }

            private void radio_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void radioStudenti_CheckedChanged(object sender, EventArgs e)
            {
                LoadStudenti();
            }

            private void radioDocenti_CheckedChanged(object sender, EventArgs e)
            {
                LoadDocenti();
            }

            private void radioCorsi_CheckedChanged(object sender, EventArgs e)
            {
                LoadCorsi();
            }

            private void RefreshGrid<T>(List<T> data)
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = data;
                dataGridView1.AllowUserToAddRows = false;
            if (dataGridView1.Columns.Contains("Prof"))
                dataGridView1.Columns["Prof"].Visible = false;
            AddButtonColumns();

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex < 0) return;

                var column = dataGridView1.Columns[e.ColumnIndex].HeaderText;

                if (column == "Modifica")
                {
                    if (currentType == "Studente")
                    {
                        var selected = studenti[e.RowIndex];
                        var form = new Form4(selected);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            studenti[e.RowIndex] = form.studenteModificato;
                            File.WriteAllText(@"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json", JsonSerializer.Serialize(studenti, new JsonSerializerOptions { WriteIndented = true }));
                            RefreshGrid(studenti);
                            mainForm.RefreshStudenti();
                        }
                    }

                    else if (currentType == "Docente")
                    {
                        var selected = docenti[e.RowIndex];
                        var form = new Form6(selected);
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            docenti[e.RowIndex] = form.docenteModificato;
                            File.WriteAllText(@"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json", JsonSerializer.Serialize(docenti, new JsonSerializerOptions { WriteIndented = true }));
                            RefreshGrid(docenti);
                            mainForm.RefreshDocenti();
                        }
                    } 

                    else if (currentType == "Corso")
                    {
                        var selected = corsi[e.RowIndex];
                        var form = new Form9(selected); 
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            corsi[e.RowIndex] = form.corsoModificato;
                            File.WriteAllText(@"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json", JsonSerializer.Serialize(corsi, new JsonSerializerOptions { WriteIndented = true }));
                            RefreshGrid(corsi);
                            mainForm.RefreshCorsi();

                    }
                            
                }
                }

                else if (column=="Cancella")
                {

                    if (currentType == "Studente")
                    {
                        studenti.RemoveAt(e.RowIndex);
                        File.WriteAllText(@"C:\Users\A711apulia\Desktop\Progetto\Universita\Studenti.json", JsonSerializer.Serialize(studenti, new JsonSerializerOptions { WriteIndented = true }));
                        RefreshGrid(studenti);
                        mainForm.RefreshStudenti();
                    }
                    else if (currentType == "Docente")
                    {
                        docenti.RemoveAt(e.RowIndex);
                        File.WriteAllText(@"C:\Users\A711apulia\Desktop\Progetto\Universita\Docenti.json", JsonSerializer.Serialize(docenti, new JsonSerializerOptions { WriteIndented = true }));
                        RefreshGrid(docenti);
                        mainForm.RefreshDocenti();
                    }
                    else if (currentType == "Corso")
                    {
                        corsi.RemoveAt(e.RowIndex);
                        File.WriteAllText(@"C:\Users\A711apulia\Desktop\Progetto\Universita\Corsi.json", JsonSerializer.Serialize(corsi, new JsonSerializerOptions { WriteIndented = true }));
                        RefreshGrid(corsi);
                        mainForm.RefreshCorsi();
                    }
                }
            }
        }
            }
        
    

