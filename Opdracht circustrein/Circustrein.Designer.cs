namespace Opdracht_circustrein
{
    partial class Circustrein
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
            this.buttonNieuwDier = new System.Windows.Forms.Button();
            this.listBoxDieren = new System.Windows.Forms.ListBox();
            this.listBoxWagons = new System.Windows.Forms.ListBox();
            this.buttonDeelWagonsIn = new System.Windows.Forms.Button();
            this.comboBoxSelectVoer = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectGrootte = new System.Windows.Forms.ComboBox();
            this.numericUpDownAantalDieren = new System.Windows.Forms.NumericUpDown();
            this.progressBarWagon = new System.Windows.Forms.ProgressBar();
            this.listBoxDierenWagon = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAantalDieren)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNieuwDier
            // 
            this.buttonNieuwDier.Location = new System.Drawing.Point(448, 39);
            this.buttonNieuwDier.Name = "buttonNieuwDier";
            this.buttonNieuwDier.Size = new System.Drawing.Size(118, 24);
            this.buttonNieuwDier.TabIndex = 0;
            this.buttonNieuwDier.Text = "Voeg toe";
            this.buttonNieuwDier.UseVisualStyleBackColor = true;
            this.buttonNieuwDier.Click += new System.EventHandler(this.buttonNieuwDier_Click);
            // 
            // listBoxDieren
            // 
            this.listBoxDieren.FormattingEnabled = true;
            this.listBoxDieren.ItemHeight = 16;
            this.listBoxDieren.Location = new System.Drawing.Point(21, 123);
            this.listBoxDieren.Name = "listBoxDieren";
            this.listBoxDieren.Size = new System.Drawing.Size(228, 388);
            this.listBoxDieren.TabIndex = 1;
            // 
            // listBoxWagons
            // 
            this.listBoxWagons.FormattingEnabled = true;
            this.listBoxWagons.ItemHeight = 16;
            this.listBoxWagons.Location = new System.Drawing.Point(448, 123);
            this.listBoxWagons.Name = "listBoxWagons";
            this.listBoxWagons.Size = new System.Drawing.Size(206, 388);
            this.listBoxWagons.TabIndex = 2;
            this.listBoxWagons.SelectedIndexChanged += new System.EventHandler(this.listBoxWagons_SelectedIndexChanged);
            // 
            // buttonDeelWagonsIn
            // 
            this.buttonDeelWagonsIn.Location = new System.Drawing.Point(277, 189);
            this.buttonDeelWagonsIn.Name = "buttonDeelWagonsIn";
            this.buttonDeelWagonsIn.Size = new System.Drawing.Size(140, 252);
            this.buttonDeelWagonsIn.TabIndex = 3;
            this.buttonDeelWagonsIn.Text = "Deel wagons in";
            this.buttonDeelWagonsIn.UseVisualStyleBackColor = true;
            this.buttonDeelWagonsIn.Click += new System.EventHandler(this.buttonDeelWagonsIn_Click);
            // 
            // comboBoxSelectVoer
            // 
            this.comboBoxSelectVoer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectVoer.FormattingEnabled = true;
            this.comboBoxSelectVoer.Location = new System.Drawing.Point(147, 40);
            this.comboBoxSelectVoer.Name = "comboBoxSelectVoer";
            this.comboBoxSelectVoer.Size = new System.Drawing.Size(102, 24);
            this.comboBoxSelectVoer.TabIndex = 4;
            this.comboBoxSelectVoer.SelectedIndexChanged += new System.EventHandler(this.selectVoer_SelectedIndexChanged);
            // 
            // comboBoxSelectGrootte
            // 
            this.comboBoxSelectGrootte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectGrootte.FormattingEnabled = true;
            this.comboBoxSelectGrootte.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxSelectGrootte.Location = new System.Drawing.Point(21, 40);
            this.comboBoxSelectGrootte.Name = "comboBoxSelectGrootte";
            this.comboBoxSelectGrootte.Size = new System.Drawing.Size(102, 24);
            this.comboBoxSelectGrootte.TabIndex = 5;
            // 
            // numericUpDownAantalDieren
            // 
            this.numericUpDownAantalDieren.Location = new System.Drawing.Point(305, 41);
            this.numericUpDownAantalDieren.Name = "numericUpDownAantalDieren";
            this.numericUpDownAantalDieren.Size = new System.Drawing.Size(96, 22);
            this.numericUpDownAantalDieren.TabIndex = 7;
            this.numericUpDownAantalDieren.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // progressBarWagon
            // 
            this.progressBarWagon.Location = new System.Drawing.Point(448, 527);
            this.progressBarWagon.Name = "progressBarWagon";
            this.progressBarWagon.Size = new System.Drawing.Size(206, 23);
            this.progressBarWagon.TabIndex = 8;
            // 
            // listBoxDierenWagon
            // 
            this.listBoxDierenWagon.FormattingEnabled = true;
            this.listBoxDierenWagon.ItemHeight = 16;
            this.listBoxDierenWagon.Location = new System.Drawing.Point(724, 123);
            this.listBoxDierenWagon.Name = "listBoxDierenWagon";
            this.listBoxDierenWagon.Size = new System.Drawing.Size(233, 388);
            this.listBoxDierenWagon.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dieren:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Wagons:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(724, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dieren in wagon:";
            // 
            // Circustrein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDierenWagon);
            this.Controls.Add(this.progressBarWagon);
            this.Controls.Add(this.numericUpDownAantalDieren);
            this.Controls.Add(this.comboBoxSelectGrootte);
            this.Controls.Add(this.comboBoxSelectVoer);
            this.Controls.Add(this.buttonDeelWagonsIn);
            this.Controls.Add(this.listBoxWagons);
            this.Controls.Add(this.listBoxDieren);
            this.Controls.Add(this.buttonNieuwDier);
            this.Name = "Circustrein";
            this.Text = "Circustrein";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAantalDieren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNieuwDier;
        private System.Windows.Forms.ListBox listBoxDieren;
        private System.Windows.Forms.ListBox listBoxWagons;
        private System.Windows.Forms.Button buttonDeelWagonsIn;
        private System.Windows.Forms.ComboBox comboBoxSelectVoer;
        private System.Windows.Forms.ComboBox comboBoxSelectGrootte;
        private System.Windows.Forms.NumericUpDown numericUpDownAantalDieren;
        private System.Windows.Forms.ProgressBar progressBarWagon;
        private System.Windows.Forms.ListBox listBoxDierenWagon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

