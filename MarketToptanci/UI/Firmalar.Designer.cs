namespace MarketToptanci.UI
{
    partial class Firmalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firmalar));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnFirmaEkle = new System.Windows.Forms.ToolStripButton();
            this.btnFirmaDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnFirmaSil = new System.Windows.Forms.ToolStripButton();
            this.btnFirmaBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnIptal);
            this.tabPage3.Controls.Add(this.btnTamam);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Firmalar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(3, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(786, 359);
            this.dataGridView3.TabIndex = 5;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirmaEkle,
            this.btnFirmaDuzenle,
            this.btnFirmaSil,
            this.btnFirmaBul,
            this.toolStripTextBox3,
            this.toolStripLabel3});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnFirmaEkle
            // 
            this.btnFirmaEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFirmaEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaEkle.Image")));
            this.btnFirmaEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirmaEkle.Name = "btnFirmaEkle";
            this.btnFirmaEkle.Size = new System.Drawing.Size(32, 22);
            this.btnFirmaEkle.Text = "Ekle";
            this.btnFirmaEkle.Click += new System.EventHandler(this.btnFirmaEkle_Click);
            // 
            // btnFirmaDuzenle
            // 
            this.btnFirmaDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFirmaDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaDuzenle.Image")));
            this.btnFirmaDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirmaDuzenle.Name = "btnFirmaDuzenle";
            this.btnFirmaDuzenle.Size = new System.Drawing.Size(53, 22);
            this.btnFirmaDuzenle.Text = "Düzenle";
            this.btnFirmaDuzenle.Click += new System.EventHandler(this.btnFirmaDuzenle_Click);
            // 
            // btnFirmaSil
            // 
            this.btnFirmaSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFirmaSil.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaSil.Image")));
            this.btnFirmaSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirmaSil.Name = "btnFirmaSil";
            this.btnFirmaSil.Size = new System.Drawing.Size(23, 22);
            this.btnFirmaSil.Text = "Sil";
            this.btnFirmaSil.Click += new System.EventHandler(this.btnFirmaSil_Click);
            // 
            // btnFirmaBul
            // 
            this.btnFirmaBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFirmaBul.BackColor = System.Drawing.Color.White;
            this.btnFirmaBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFirmaBul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFirmaBul.Image = ((System.Drawing.Image)(resources.GetObject("btnFirmaBul.Image")));
            this.btnFirmaBul.ImageTransparentColor = System.Drawing.Color.White;
            this.btnFirmaBul.Name = "btnFirmaBul";
            this.btnFirmaBul.Size = new System.Drawing.Size(28, 22);
            this.btnFirmaBul.Text = "Bul";
            this.btnFirmaBul.Click += new System.EventHandler(this.btnFirmaBul_Click);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel3.Text = "Ara:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // btnIptal
            // 
            this.btnIptal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnIptal.Location = new System.Drawing.Point(711, 393);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 26;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(630, 393);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 25;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // Firmalar
            // 
            this.AcceptButton = this.btnTamam;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnIptal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Firmalar";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.Firmalar_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnFirmaEkle;
        private System.Windows.Forms.ToolStripButton btnFirmaDuzenle;
        private System.Windows.Forms.ToolStripButton btnFirmaSil;
        private System.Windows.Forms.ToolStripButton btnFirmaBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
    }
}