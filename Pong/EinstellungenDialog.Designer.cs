namespace Pong
{
    partial class EinstellungenDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMaximal = new System.Windows.Forms.RadioButton();
            this.radioButton1024 = new System.Windows.Forms.RadioButton();
            this.radioButton640 = new System.Windows.Forms.RadioButton();
            this.radioButton320 = new System.Windows.Forms.RadioButton();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonUebernehmen = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.colorSpielfeld = new System.Windows.Forms.Panel();
            this.colorRahmen = new System.Windows.Forms.Panel();
            this.spielfeldButton = new System.Windows.Forms.Button();
            this.rahmenButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.spielfeld = new System.Windows.Forms.Panel();
            this.ball = new System.Windows.Forms.Panel();
            this.schlaeger = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.spielfeld.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMaximal);
            this.groupBox1.Controls.Add(this.radioButton1024);
            this.groupBox1.Controls.Add(this.radioButton640);
            this.groupBox1.Controls.Add(this.radioButton320);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 77);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Größe";
            // 
            // radioButtonMaximal
            // 
            this.radioButtonMaximal.AutoSize = true;
            this.radioButtonMaximal.Location = new System.Drawing.Point(252, 30);
            this.radioButtonMaximal.Name = "radioButtonMaximal";
            this.radioButtonMaximal.Size = new System.Drawing.Size(63, 17);
            this.radioButtonMaximal.TabIndex = 3;
            this.radioButtonMaximal.TabStop = true;
            this.radioButtonMaximal.Text = "Maximal";
            this.radioButtonMaximal.UseVisualStyleBackColor = true;
            // 
            // radioButton1024
            // 
            this.radioButton1024.AutoSize = true;
            this.radioButton1024.Location = new System.Drawing.Point(169, 30);
            this.radioButton1024.Name = "radioButton1024";
            this.radioButton1024.Size = new System.Drawing.Size(77, 17);
            this.radioButton1024.TabIndex = 2;
            this.radioButton1024.TabStop = true;
            this.radioButton1024.Text = "1024 * 768";
            this.radioButton1024.UseVisualStyleBackColor = true;
            // 
            // radioButton640
            // 
            this.radioButton640.AutoSize = true;
            this.radioButton640.Location = new System.Drawing.Point(92, 30);
            this.radioButton640.Name = "radioButton640";
            this.radioButton640.Size = new System.Drawing.Size(71, 17);
            this.radioButton640.TabIndex = 1;
            this.radioButton640.TabStop = true;
            this.radioButton640.Text = "640 * 480";
            this.radioButton640.UseVisualStyleBackColor = true;
            // 
            // radioButton320
            // 
            this.radioButton320.AutoSize = true;
            this.radioButton320.Checked = true;
            this.radioButton320.Location = new System.Drawing.Point(15, 30);
            this.radioButton320.Name = "radioButton320";
            this.radioButton320.Size = new System.Drawing.Size(71, 17);
            this.radioButton320.TabIndex = 0;
            this.radioButton320.TabStop = true;
            this.radioButton320.Text = "320 * 200";
            this.radioButton320.UseVisualStyleBackColor = true;
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.Location = new System.Drawing.Point(264, 332);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.buttonAbbrechen.TabIndex = 5;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = true;
            this.buttonAbbrechen.Click += new System.EventHandler(this.buttonAbbrechen_Click);
            // 
            // buttonUebernehmen
            // 
            this.buttonUebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonUebernehmen.Location = new System.Drawing.Point(14, 332);
            this.buttonUebernehmen.Name = "buttonUebernehmen";
            this.buttonUebernehmen.Size = new System.Drawing.Size(85, 23);
            this.buttonUebernehmen.TabIndex = 4;
            this.buttonUebernehmen.Text = "Übernehmen";
            this.buttonUebernehmen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.colorSpielfeld);
            this.groupBox2.Controls.Add(this.colorRahmen);
            this.groupBox2.Controls.Add(this.spielfeldButton);
            this.groupBox2.Controls.Add(this.rahmenButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 105);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Farben";
            // 
            // colorSpielfeld
            // 
            this.colorSpielfeld.Location = new System.Drawing.Point(119, 60);
            this.colorSpielfeld.Name = "colorSpielfeld";
            this.colorSpielfeld.Size = new System.Drawing.Size(29, 23);
            this.colorSpielfeld.TabIndex = 5;
            // 
            // colorRahmen
            // 
            this.colorRahmen.Location = new System.Drawing.Point(119, 26);
            this.colorRahmen.Name = "colorRahmen";
            this.colorRahmen.Size = new System.Drawing.Size(29, 23);
            this.colorRahmen.TabIndex = 4;
            // 
            // spielfeldButton
            // 
            this.spielfeldButton.Location = new System.Drawing.Point(79, 60);
            this.spielfeldButton.Name = "spielfeldButton";
            this.spielfeldButton.Size = new System.Drawing.Size(29, 23);
            this.spielfeldButton.TabIndex = 3;
            this.spielfeldButton.Text = "...";
            this.spielfeldButton.UseVisualStyleBackColor = true;
            this.spielfeldButton.Click += new System.EventHandler(this.spielfeldButton_Click);
            // 
            // rahmenButton
            // 
            this.rahmenButton.Location = new System.Drawing.Point(79, 26);
            this.rahmenButton.Name = "rahmenButton";
            this.rahmenButton.Size = new System.Drawing.Size(29, 23);
            this.rahmenButton.TabIndex = 2;
            this.rahmenButton.Text = "...";
            this.rahmenButton.UseVisualStyleBackColor = true;
            this.rahmenButton.Click += new System.EventHandler(this.rahmenButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spielfeld:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rahmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vorschau:";
            // 
            // spielfeld
            // 
            this.spielfeld.Controls.Add(this.ball);
            this.spielfeld.Controls.Add(this.schlaeger);
            this.spielfeld.Location = new System.Drawing.Point(12, 249);
            this.spielfeld.Name = "spielfeld";
            this.spielfeld.Size = new System.Drawing.Size(325, 77);
            this.spielfeld.TabIndex = 8;
            this.spielfeld.Paint += new System.Windows.Forms.PaintEventHandler(this.spielfeld_Paint);
            // 
            // ball
            // 
            this.ball.Location = new System.Drawing.Point(113, 20);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(50, 34);
            this.ball.TabIndex = 1;
            // 
            // schlaeger
            // 
            this.schlaeger.Location = new System.Drawing.Point(10, 20);
            this.schlaeger.Name = "schlaeger";
            this.schlaeger.Size = new System.Drawing.Size(47, 34);
            this.schlaeger.TabIndex = 0;
            // 
            // EinstellungenDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 367);
            this.ControlBox = false;
            this.Controls.Add(this.spielfeld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.buttonUebernehmen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EinstellungenDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spielfeld";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.spielfeld.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMaximal;
        private System.Windows.Forms.RadioButton radioButton1024;
        private System.Windows.Forms.RadioButton radioButton640;
        private System.Windows.Forms.RadioButton radioButton320;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonUebernehmen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button spielfeldButton;
        private System.Windows.Forms.Button rahmenButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel spielfeld;
        private System.Windows.Forms.Panel ball;
        private System.Windows.Forms.Panel schlaeger;
        private System.Windows.Forms.Panel colorSpielfeld;
        private System.Windows.Forms.Panel colorRahmen;
    }
}