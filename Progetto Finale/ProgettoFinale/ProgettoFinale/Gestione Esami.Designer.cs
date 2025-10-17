namespace ProgettoFinale
{
    partial class Form11
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
            dateTimePickerEsame = new DateTimePicker();
            comboBoxStudenti = new ComboBox();
            Voto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblNomeCorso = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // dateTimePickerEsame
            // 
            dateTimePickerEsame.Location = new Point(301, 203);
            dateTimePickerEsame.Name = "dateTimePickerEsame";
            dateTimePickerEsame.Size = new Size(291, 31);
            dateTimePickerEsame.TabIndex = 0;
            // 
            // comboBoxStudenti
            // 
            comboBoxStudenti.FormattingEnabled = true;
            comboBoxStudenti.Location = new Point(301, 89);
            comboBoxStudenti.Name = "comboBoxStudenti";
            comboBoxStudenti.Size = new Size(182, 33);
            comboBoxStudenti.TabIndex = 1;
            // 
            // Voto
            // 
            Voto.Location = new Point(301, 143);
            Voto.Name = "Voto";
            Voto.Size = new Size(182, 31);
            Voto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 92);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 4;
            label1.Text = "Studente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 208);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 5;
            label2.Text = "Data Esame";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 149);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 6;
            label3.Text = "Voto";
            // 
            // lblNomeCorso
            // 
            lblNomeCorso.AutoSize = true;
            lblNomeCorso.Location = new Point(392, 28);
            lblNomeCorso.Name = "lblNomeCorso";
            lblNomeCorso.Size = new Size(0, 25);
            lblNomeCorso.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Location = new Point(322, 311);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Inserisci";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblNomeCorso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Voto);
            Controls.Add(comboBoxStudenti);
            Controls.Add(dateTimePickerEsame);
            Name = "Form11";
            Text = "Gestione Esami";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerEsame;
        private ComboBox comboBoxStudenti;
        private ComboBox comboBoxCorso;
        private TextBox Voto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Corso;
        private Label lblNomeCorso;
        private Button button1;
    }
}