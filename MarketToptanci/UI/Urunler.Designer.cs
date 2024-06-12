namespace MarketToptanci.UI
{
    partial class Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Urunler));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnUrunEkle = new System.Windows.Forms.ToolStripButton();
            this.btnUrunDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnUrunSil = new System.Windows.Forms.ToolStripButton();
            this.btnUrunBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.toolStrip3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ürünler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView3.Location = new System.Drawing.Point(3, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(786, 393);
            this.dataGridView3.TabIndex = 5;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUrunEkle,
            this.btnUrunDuzenle,
            this.btnUrunSil,
            this.btnUrunBul,
            this.toolStripTextBox3,
            this.toolStripLabel3});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(786, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.Image")));
            this.btnUrunEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(32, 22);
            this.btnUrunEkle.Text = "Ekle";
            // 
            // btnUrunDuzenle
            // 
            this.btnUrunDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunDuzenle.Image")));
            this.btnUrunDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunDuzenle.Name = "btnUrunDuzenle";
            this.btnUrunDuzenle.Size = new System.Drawing.Size(53, 22);
            this.btnUrunDuzenle.Text = "Düzenle";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSil.Image")));
            this.btnUrunSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(23, 22);
            this.btnUrunSil.Text = "Sil";
            // 
            // btnUrunBul
            // 
            this.btnUrunBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnUrunBul.BackColor = System.Drawing.Color.White;
            this.btnUrunBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUrunBul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUrunBul.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunBul.Image")));
            this.btnUrunBul.ImageTransparentColor = System.Drawing.Color.White;
            this.btnUrunBul.Name = "btnUrunBul";
            this.btnUrunBul.Size = new System.Drawing.Size(28, 22);
            this.btnUrunBul.Text = "Bul";
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
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnUrunEkle;
        private System.Windows.Forms.ToolStripButton btnUrunDuzenle;
        private System.Windows.Forms.ToolStripButton btnUrunSil;
        private System.Windows.Forms.ToolStripButton btnUrunBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}