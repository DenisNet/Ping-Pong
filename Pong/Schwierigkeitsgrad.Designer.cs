namespace Pong
{
    partial class Schwierigkeitsgrad
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
            this.sehrEinfachRadioButton = new System.Windows.Forms.RadioButton();
            this.einfachRadioButton = new System.Windows.Forms.RadioButton();
            this.mittelRadioButton = new System.Windows.Forms.RadioButton();
            this.schwerRadioButton = new System.Windows.Forms.RadioButton();
            this.sehrSchwerRadioButton = new System.Windows.Forms.RadioButton();
            this.ubernehmButton = new System.Windows.Forms.Button();
            this.abbrechenButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sehrEinfachRadioButton
            // 
            this.sehrEinfachRadioButton.AutoSize = true;
            this.sehrEinfachRadioButton.Location = new System.Drawing.Point(39, 40);
            this.sehrEinfachRadioButton.Name = "sehrEinfachRadioButton";
            this.sehrEinfachRadioButton.Size = new System.Drawing.Size(85, 17);
            this.sehrEinfachRadioButton.TabIndex = 5;
            this.sehrEinfachRadioButton.TabStop = true;
            this.sehrEinfachRadioButton.Text = "Sehr einfach";
            this.sehrEinfachRadioButton.UseVisualStyleBackColor = true;
            // 
            // einfachRadioButton
            // 
            this.einfachRadioButton.AutoSize = true;
            this.einfachRadioButton.Location = new System.Drawing.Point(39, 63);
            this.einfachRadioButton.Name = "einfachRadioButton";
            this.einfachRadioButton.Size = new System.Drawing.Size(61, 17);
            this.einfachRadioButton.TabIndex = 6;
            this.einfachRadioButton.TabStop = true;
            this.einfachRadioButton.Text = "Einfach";
            this.einfachRadioButton.UseVisualStyleBackColor = true;
            // 
            // mittelRadioButton
            // 
            this.mittelRadioButton.AutoSize = true;
            this.mittelRadioButton.Location = new System.Drawing.Point(39, 86);
            this.mittelRadioButton.Name = "mittelRadioButton";
            this.mittelRadioButton.Size = new System.Drawing.Size(50, 17);
            this.mittelRadioButton.TabIndex = 7;
            this.mittelRadioButton.TabStop = true;
            this.mittelRadioButton.Text = "Mittel";
            this.mittelRadioButton.UseVisualStyleBackColor = true;
            // 
            // schwerRadioButton
            // 
            this.schwerRadioButton.AutoSize = true;
            this.schwerRadioButton.Location = new System.Drawing.Point(39, 109);
            this.schwerRadioButton.Name = "schwerRadioButton";
            this.schwerRadioButton.Size = new System.Drawing.Size(61, 17);
            this.schwerRadioButton.TabIndex = 8;
            this.schwerRadioButton.TabStop = true;
            this.schwerRadioButton.Text = "Schwer";
            this.schwerRadioButton.UseVisualStyleBackColor = true;
            // 
            // sehrSchwerRadioButton
            // 
            this.sehrSchwerRadioButton.AutoSize = true;
            this.sehrSchwerRadioButton.Location = new System.Drawing.Point(39, 132);
            this.sehrSchwerRadioButton.Name = "sehrSchwerRadioButton";
            this.sehrSchwerRadioButton.Size = new System.Drawing.Size(84, 17);
            this.sehrSchwerRadioButton.TabIndex = 9;
            this.sehrSchwerRadioButton.TabStop = true;
            this.sehrSchwerRadioButton.Text = "Sehr schwer";
            this.sehrSchwerRadioButton.UseVisualStyleBackColor = true;
            // 
            // ubernehmButton
            // 
            this.ubernehmButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ubernehmButton.Location = new System.Drawing.Point(39, 175);
            this.ubernehmButton.Name = "ubernehmButton";
            this.ubernehmButton.Size = new System.Drawing.Size(85, 23);
            this.ubernehmButton.TabIndex = 10;
            this.ubernehmButton.Text = "Ubernehmen";
            this.ubernehmButton.UseVisualStyleBackColor = true;
            // 
            // abbrechenButton
            // 
            this.abbrechenButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abbrechenButton.Location = new System.Drawing.Point(166, 175);
            this.abbrechenButton.Name = "abbrechenButton";
            this.abbrechenButton.Size = new System.Drawing.Size(86, 23);
            this.abbrechenButton.TabIndex = 11;
            this.abbrechenButton.Text = "Abbrechen";
            this.abbrechenButton.UseVisualStyleBackColor = true;
            // 
            // Schwierigkeitsgrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 214);
            this.Controls.Add(this.abbrechenButton);
            this.Controls.Add(this.ubernehmButton);
            this.Controls.Add(this.sehrSchwerRadioButton);
            this.Controls.Add(this.schwerRadioButton);
            this.Controls.Add(this.mittelRadioButton);
            this.Controls.Add(this.einfachRadioButton);
            this.Controls.Add(this.sehrEinfachRadioButton);
            this.Name = "Schwierigkeitsgrad";
            this.Text = "Schwierigkeitsgrad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton sehrEinfachRadioButton;
        private System.Windows.Forms.RadioButton einfachRadioButton;
        private System.Windows.Forms.RadioButton mittelRadioButton;
        private System.Windows.Forms.RadioButton schwerRadioButton;
        private System.Windows.Forms.RadioButton sehrSchwerRadioButton;
        private System.Windows.Forms.Button ubernehmButton;
        private System.Windows.Forms.Button abbrechenButton;
    }
}