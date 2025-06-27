namespace ReactionTrainer
{
    partial class Action
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
            lblCountdownLabel = new Label();
            lblCountdown = new Label();
            lblIntervalloLabel = new Label();
            lblIntervallo = new Label();
            lblAzione = new Label();
            SuspendLayout();
            // 
            // lblCountdownLabel
            // 
            lblCountdownLabel.AutoSize = true;
            lblCountdownLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountdownLabel.Location = new Point(30, 29);
            lblCountdownLabel.Name = "lblCountdownLabel";
            lblCountdownLabel.Size = new Size(251, 37);
            lblCountdownLabel.TabIndex = 0;
            lblCountdownLabel.Text = "Tempo rimanente:";
            // 
            // lblCountdown
            // 
            lblCountdown.AutoSize = true;
            lblCountdown.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountdown.ForeColor = Color.Green;
            lblCountdown.Location = new Point(287, 29);
            lblCountdown.Name = "lblCountdown";
            lblCountdown.Size = new Size(69, 37);
            lblCountdown.TabIndex = 1;
            lblCountdown.Text = "N/A";
            // 
            // lblIntervalloLabel
            // 
            lblIntervalloLabel.AutoSize = true;
            lblIntervalloLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntervalloLabel.Location = new Point(30, 76);
            lblIntervalloLabel.Name = "lblIntervalloLabel";
            lblIntervalloLabel.Size = new Size(86, 37);
            lblIntervalloLabel.TabIndex = 2;
            lblIntervalloLabel.Text = "Next:";
            // 
            // lblIntervallo
            // 
            lblIntervallo.AutoSize = true;
            lblIntervallo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIntervallo.ForeColor = Color.Red;
            lblIntervallo.Location = new Point(287, 76);
            lblIntervallo.Name = "lblIntervallo";
            lblIntervallo.Size = new Size(69, 37);
            lblIntervallo.TabIndex = 3;
            lblIntervallo.Text = "N/A";
            // 
            // lblAzione
            // 
            lblAzione.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblAzione.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAzione.Location = new Point(2, 283);
            lblAzione.MaximumSize = new Size(600, 600);
            lblAzione.Name = "lblAzione";
            lblAzione.Size = new Size(596, 167);
            lblAzione.TabIndex = 4;
            lblAzione.Text = "READY";
            lblAzione.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Action
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 561);
            ControlBox = false;
            Controls.Add(lblAzione);
            Controls.Add(lblIntervallo);
            Controls.Add(lblIntervalloLabel);
            Controls.Add(lblCountdown);
            Controls.Add(lblCountdownLabel);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "Action";
            Text = "Action";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCountdownLabel;
        private Label lblCountdown;
        private Label lblIntervalloLabel;
        private Label lblIntervallo;
        private Label lblAzione;
    }
}