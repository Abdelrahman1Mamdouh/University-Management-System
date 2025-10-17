namespace ProgettoFinale
{
    partial class Form9
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
            comboBoxDocente = new ComboBox();
            CID = new TextBox();
            Cnome = new TextBox();
            labelID = new Label();
            dataFine = new Label();
            dataInizio = new Label();
            nome = new Label();
            CDocente = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // comboBoxDocente
            // 
            comboBoxDocente.FormattingEnabled = true;
            comboBoxDocente.Location = new Point(318, 50);
            comboBoxDocente.Margin = new Padding(4, 5, 4, 5);
            comboBoxDocente.Name = "comboBoxDocente";
            comboBoxDocente.Size = new Size(251, 33);
            comboBoxDocente.TabIndex = 20;
            // 
            // CID
            // 
            CID.Location = new Point(318, 369);
            CID.Margin = new Padding(4, 5, 4, 5);
            CID.Name = "CID";
            CID.Size = new Size(251, 31);
            CID.TabIndex = 19;
            // 
            // Cnome
            // 
            Cnome.Location = new Point(318, 130);
            Cnome.Margin = new Padding(4, 5, 4, 5);
            Cnome.Name = "Cnome";
            Cnome.Size = new Size(251, 31);
            Cnome.TabIndex = 16;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(231, 369);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(30, 25);
            labelID.TabIndex = 15;
            labelID.Text = "ID";
            // 
            // dataFine
            // 
            dataFine.AutoSize = true;
            dataFine.Location = new Point(231, 295);
            dataFine.Margin = new Padding(4, 0, 4, 0);
            dataFine.Name = "dataFine";
            dataFine.Size = new Size(86, 25);
            dataFine.TabIndex = 14;
            dataFine.Text = "Data Fine";
            // 
            // dataInizio
            // 
            dataInizio.AutoSize = true;
            dataInizio.Location = new Point(231, 209);
            dataInizio.Margin = new Padding(4, 0, 4, 0);
            dataInizio.Name = "dataInizio";
            dataInizio.Size = new Size(96, 25);
            dataInizio.TabIndex = 13;
            dataInizio.Text = "Data Inizio";
            // 
            // nome
            // 
            nome.AutoSize = true;
            nome.Location = new Point(231, 130);
            nome.Margin = new Padding(4, 0, 4, 0);
            nome.Name = "nome";
            nome.Size = new Size(61, 25);
            nome.TabIndex = 12;
            nome.Text = "Nome";
            // 
            // CDocente
            // 
            CDocente.AutoSize = true;
            CDocente.Location = new Point(231, 50);
            CDocente.Margin = new Padding(4, 0, 4, 0);
            CDocente.Name = "CDocente";
            CDocente.Size = new Size(78, 25);
            CDocente.TabIndex = 11;
            CDocente.Text = "Docente";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(375, 437);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 21;
            button1.Text = "Salva";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(318, 209);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(318, 295);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 23;
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(849, 483);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(comboBoxDocente);
            Controls.Add(CID);
            Controls.Add(Cnome);
            Controls.Add(labelID);
            Controls.Add(dataFine);
            Controls.Add(dataInizio);
            Controls.Add(nome);
            Controls.Add(CDocente);
            Name = "Form9";
            Text = "Modifica Corso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxDocente;
        private TextBox CID;
        private TextBox Cnome;
        private Label labelID;
        private Label dataFine;
        private Label dataInizio;
        private Label nome;
        private Label CDocente;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}