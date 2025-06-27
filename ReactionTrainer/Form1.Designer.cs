namespace ReactionTrainer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIntervallo = new Label();
            lblIntervallo2 = new Label();
            txtIntervallo = new TextBox();
            lblDurata = new Label();
            lblDurata2 = new Label();
            txtDurata = new TextBox();
            SuspendLayout();
            // 
            // lblIntervallo
            // 
            lblIntervallo.AutoSize = true;
            lblIntervallo.Location = new Point(38, 42);
            lblIntervallo.Name = "lblIntervallo";
            lblIntervallo.Size = new Size(286, 15);
            lblIntervallo.TabIndex = 0;
            lblIntervallo.Text = "Inserisci l'intervallo di tempo di ogni aggiornamento:";
            // 
            // lblIntervallo2
            // 
            lblIntervallo2.AutoSize = true;
            lblIntervallo2.Font = new Font("Segoe UI", 8F);
            lblIntervallo2.ForeColor = Color.Gray;
            lblIntervallo2.Location = new Point(38, 57);
            lblIntervallo2.Name = "lblIntervallo2";
            lblIntervallo2.Size = new Size(161, 13);
            lblIntervallo2.TabIndex = 1;
            lblIntervallo2.Text = "Indicare l'intervallo in secondi";
            // 
            // txtIntervallo
            // 
            txtIntervallo.Location = new Point(330, 39);
            txtIntervallo.Name = "txtIntervallo";
            txtIntervallo.Size = new Size(42, 23);
            txtIntervallo.TabIndex = 2;
            // 
            // lblDurata
            // 
            lblDurata.AutoSize = true;
            lblDurata.Location = new Point(38, 96);
            lblDurata.Name = "lblDurata";
            lblDurata.Size = new Size(171, 15);
            lblDurata.TabIndex = 3;
            lblDurata.Text = "Inserisci la durata dell'esercizio:";
            // 
            // lblDurata2
            // 
            lblDurata2.AutoSize = true;
            lblDurata2.Font = new Font("Segoe UI", 8F);
            lblDurata2.ForeColor = Color.Gray;
            lblDurata2.Location = new Point(38, 111);
            lblDurata2.Name = "lblDurata2";
            lblDurata2.Size = new Size(153, 13);
            lblDurata2.TabIndex = 4;
            lblDurata2.Text = "Indicare la durata in secondi";
            // 
            // txtDurata
            // 
            txtDurata.Location = new Point(215, 93);
            txtDurata.Name = "txtDurata";
            txtDurata.Size = new Size(42, 23);
            txtDurata.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDurata);
            Controls.Add(lblDurata2);
            Controls.Add(lblDurata);
            Controls.Add(txtIntervallo);
            Controls.Add(lblIntervallo2);
            Controls.Add(lblIntervallo);
            Name = "Form1";
            Text = "Reaction Trainer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIntervallo;
        private Label lblIntervallo2;
        private TextBox txtIntervallo;
        private Label lblDurata;
        private Label lblDurata2;
        private TextBox txtDurata;
    }
}
