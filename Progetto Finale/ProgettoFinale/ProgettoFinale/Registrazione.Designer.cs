namespace ProgettoFinale
{
    partial class Registrazione
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
            Sid = new TextBox();
            Snome = new TextBox();
            SCognome = new TextBox();
            SEmail = new TextBox();
            STelefono = new TextBox();
            Registra = new Button();
            Id = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            griglia = new DataGridView();
            Cancella = new Button();
            Matricola = new TextBox();
            labelExtra = new Label();
            radioStudente = new RadioButton();
            radioDocente = new RadioButton();
            comboDipartimento = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)griglia).BeginInit();
            SuspendLayout();
            // 
            // Sid
            // 
            Sid.Location = new Point(190, 105);
            Sid.Margin = new Padding(1, 2, 1, 2);
            Sid.Name = "Sid";
            Sid.Size = new Size(321, 31);
            Sid.TabIndex = 0;
            // 
            // Snome
            // 
            Snome.Location = new Point(193, 168);
            Snome.Margin = new Padding(1, 2, 1, 2);
            Snome.Name = "Snome";
            Snome.Size = new Size(320, 31);
            Snome.TabIndex = 1;
            // 
            // SCognome
            // 
            SCognome.Location = new Point(193, 232);
            SCognome.Margin = new Padding(1, 2, 1, 2);
            SCognome.Name = "SCognome";
            SCognome.Size = new Size(320, 31);
            SCognome.TabIndex = 2;
            // 
            // SEmail
            // 
            SEmail.Location = new Point(190, 293);
            SEmail.Margin = new Padding(1, 2, 1, 2);
            SEmail.Name = "SEmail";
            SEmail.Size = new Size(320, 31);
            SEmail.TabIndex = 3;
            // 
            // STelefono
            // 
            STelefono.Location = new Point(190, 367);
            STelefono.Margin = new Padding(1, 2, 1, 2);
            STelefono.Name = "STelefono";
            STelefono.Size = new Size(320, 31);
            STelefono.TabIndex = 4;
            // 
            // Registra
            // 
            Registra.BackColor = Color.FromArgb(0, 192, 0);
            Registra.ForeColor = Color.White;
            Registra.Location = new Point(404, 493);
            Registra.Margin = new Padding(1, 2, 1, 2);
            Registra.Name = "Registra";
            Registra.Size = new Size(110, 35);
            Registra.TabIndex = 5;
            Registra.Text = "Registra";
            Registra.UseVisualStyleBackColor = false;
            Registra.Click += Registra_Click;
            // 
            // Id
            // 
            Id.AutoSize = true;
            Id.ForeColor = SystemColors.ActiveCaptionText;
            Id.Location = new Point(80, 105);
            Id.Margin = new Padding(1, 0, 1, 0);
            Id.Name = "Id";
            Id.Size = new Size(30, 25);
            Id.TabIndex = 7;
            Id.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(80, 172);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 8;
            label2.Text = "Nome ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(80, 232);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 9;
            label3.Text = "Cognome ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(80, 297);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 10;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(80, 368);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 11;
            label5.Text = "Telefono";
            // 
            // griglia
            // 
            griglia.BackgroundColor = Color.LightGray;
            griglia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            griglia.GridColor = SystemColors.ControlText;
            griglia.Location = new Point(607, 23);
            griglia.Margin = new Padding(1, 2, 1, 2);
            griglia.Name = "griglia";
            griglia.RowHeadersWidth = 102;
            griglia.Size = new Size(511, 463);
            griglia.TabIndex = 12;
            griglia.Visible = false;
            // 
            // Cancella
            // 
            Cancella.BackColor = Color.Red;
            Cancella.ForeColor = SystemColors.ButtonHighlight;
            Cancella.Location = new Point(210, 493);
            Cancella.Margin = new Padding(1, 2, 1, 2);
            Cancella.Name = "Cancella";
            Cancella.Size = new Size(110, 35);
            Cancella.TabIndex = 15;
            Cancella.Text = "Cancella";
            Cancella.UseVisualStyleBackColor = false;
            Cancella.Click += Cancella_Click;
            // 
            // Matricola
            // 
            Matricola.Location = new Point(193, 45);
            Matricola.Margin = new Padding(1, 2, 1, 2);
            Matricola.Name = "Matricola";
            Matricola.Size = new Size(317, 31);
            Matricola.TabIndex = 16;
            // 
            // labelExtra
            // 
            labelExtra.AutoSize = true;
            labelExtra.BackColor = SystemColors.GradientInactiveCaption;
            labelExtra.ForeColor = SystemColors.ActiveCaptionText;
            labelExtra.Location = new Point(80, 47);
            labelExtra.Margin = new Padding(1, 0, 1, 0);
            labelExtra.Name = "labelExtra";
            labelExtra.Size = new Size(85, 25);
            labelExtra.TabIndex = 17;
            labelExtra.Text = "Matricola";
            // 
            // radioStudente
            // 
            radioStudente.AutoSize = true;
            radioStudente.Location = new Point(210, 437);
            radioStudente.Margin = new Padding(4, 5, 4, 5);
            radioStudente.Name = "radioStudente";
            radioStudente.Size = new Size(107, 29);
            radioStudente.TabIndex = 18;
            radioStudente.TabStop = true;
            radioStudente.Text = "Studente";
            radioStudente.UseVisualStyleBackColor = true;
            radioStudente.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // radioDocente
            // 
            radioDocente.AutoSize = true;
            radioDocente.Location = new Point(404, 437);
            radioDocente.Margin = new Padding(4, 5, 4, 5);
            radioDocente.Name = "radioDocente";
            radioDocente.Size = new Size(103, 29);
            radioDocente.TabIndex = 19;
            radioDocente.TabStop = true;
            radioDocente.Text = "Docente";
            radioDocente.UseVisualStyleBackColor = true;
            radioDocente.CheckedChanged += radioDocente_CheckedChanged;
            // 
            // comboDipartimento
            // 
            comboDipartimento.FormattingEnabled = true;
            comboDipartimento.Location = new Point(193, 47);
            comboDipartimento.Margin = new Padding(4, 5, 4, 5);
            comboDipartimento.Name = "comboDipartimento";
            comboDipartimento.Size = new Size(317, 33);
            comboDipartimento.TabIndex = 20;
            // 
            // Registrazione
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1131, 545);
            Controls.Add(comboDipartimento);
            Controls.Add(radioDocente);
            Controls.Add(radioStudente);
            Controls.Add(labelExtra);
            Controls.Add(Matricola);
            Controls.Add(Cancella);
            Controls.Add(griglia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Id);
            Controls.Add(Registra);
            Controls.Add(STelefono);
            Controls.Add(SEmail);
            Controls.Add(SCognome);
            Controls.Add(Snome);
            Controls.Add(Sid);
            Margin = new Padding(1, 2, 1, 2);
            Name = "Registrazione";
            Text = "Registrazione";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)griglia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Sid;
        private TextBox Snome;
        private TextBox SCognome;
        private TextBox SEmail;
        private TextBox STelefono;
        private Button Registra;
        private Label Id;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView griglia;
        private Button Cancella;
        private TextBox Matricola;
        private Label labelExtra;
        private RadioButton radioStudente;
        private RadioButton radioDocente;
        private ComboBox comboDipartimento;
    }
}