namespace ProgettoFinale
{
    partial class Form7
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistraBtn = new Button();
            CDocente = new Label();
            nome = new Label();
            dataInizio = new Label();
            dataFine = new Label();
            labelID = new Label();
            Cnome = new TextBox();
            CID = new TextBox();
            comboBoxDocente = new ComboBox();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // RegistraBtn
            // 
            RegistraBtn.BackColor = Color.LightGreen;
            RegistraBtn.Location = new Point(1153, 692);
            RegistraBtn.Margin = new Padding(4, 5, 4, 5);
            RegistraBtn.Name = "RegistraBtn";
            RegistraBtn.Size = new Size(107, 38);
            RegistraBtn.TabIndex = 0;
            RegistraBtn.Text = "Registra";
            RegistraBtn.UseVisualStyleBackColor = false;
            RegistraBtn.Click += RegistraBtn_Click;
            // 
            // CDocente
            // 
            CDocente.AutoSize = true;
            CDocente.Location = new Point(13, 71);
            CDocente.Margin = new Padding(4, 0, 4, 0);
            CDocente.Name = "CDocente";
            CDocente.Size = new Size(78, 25);
            CDocente.TabIndex = 1;
            CDocente.Text = "Docente";
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(13, 148);
            nome.Margin = new Padding(4, 0, 4, 0);
            nome.Name = "nome";
            nome.Size = new Size(61, 25);
            nome.TabIndex = 2;
            nome.Text = "Nome";
            nome.Click += Cnome_Click;
            // 
            // dataInizio
            // 
            dataInizio.AutoSize = true;
            dataInizio.Location = new Point(13, 238);
            dataInizio.Margin = new Padding(4, 0, 4, 0);
            dataInizio.Name = "dataInizio";
            dataInizio.Size = new Size(96, 25);
            dataInizio.TabIndex = 3;
            dataInizio.Text = "Data Inizio";
            dataInizio.Click += dataInizio_Click;
            // 
            // dataFine
            // 
            dataFine.AutoSize = true;
            dataFine.Location = new Point(13, 314);
            dataFine.Margin = new Padding(4, 0, 4, 0);
            dataFine.Name = "dataFine";
            dataFine.Size = new Size(86, 25);
            dataFine.TabIndex = 4;
            dataFine.Text = "Data Fine";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(13, 390);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(30, 25);
            labelID.TabIndex = 5;
            labelID.Text = "ID";
            // 
            // Cnome
            // 
            Cnome.Location = new Point(126, 148);
            Cnome.Margin = new Padding(4, 5, 4, 5);
            Cnome.Name = "Cnome";
            Cnome.Size = new Size(251, 31);
            Cnome.TabIndex = 6;
            // 
            // CID
            // 
            CID.Location = new Point(126, 387);
            CID.Margin = new Padding(4, 5, 4, 5);
            CID.Name = "CID";
            CID.Size = new Size(251, 31);
            CID.TabIndex = 9;
            // 
            // comboBoxDocente
            // 
            comboBoxDocente.FormattingEnabled = true;
            comboBoxDocente.Location = new Point(126, 68);
            comboBoxDocente.Margin = new Padding(4, 5, 4, 5);
            comboBoxDocente.Name = "comboBoxDocente";
            comboBoxDocente.Size = new Size(251, 33);
            comboBoxDocente.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightGray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(387, 68);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(873, 357);
            dataGridView1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(126, 238);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(126, 325);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 31);
            dateTimePicker2.TabIndex = 13;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1277, 750);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxDocente);
            Controls.Add(CID);
            Controls.Add(Cnome);
            Controls.Add(labelID);
            Controls.Add(dataFine);
            Controls.Add(dataInizio);
            Controls.Add(nome);
            Controls.Add(CDocente);
            Controls.Add(RegistraBtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form7";
            Text = "Registrazione Corso";
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistraBtn;
        private Label CDocente;
        private Label nome;
        private Label dataInizio;
        private Label dataFine;
        private Label labelID;
        private TextBox Cnome;
        private TextBox CID;
        private ComboBox comboBoxDocente;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}