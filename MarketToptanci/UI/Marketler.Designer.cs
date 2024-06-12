namespace MarketToptanci.UI
{
    partial class Marketler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marketler));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMarketEkle = new System.Windows.Forms.ToolStripButton();
            this.btnMarketDuzenle = new System.Windows.Forms.ToolStripButton();
            this.btnMarketSil = new System.Windows.Forms.ToolStripButton();
            this.btnMarketBul = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Marketler";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMarketEkle,
            this.btnMarketDuzenle,
            this.btnMarketSil,
            this.btnMarketBul,
            this.toolStripTextBox1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMarketEkle
            // 
            this.btnMarketEkle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMarketEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnMarketEkle.Image")));
            this.btnMarketEkle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarketEkle.Name = "btnMarketEkle";
            this.btnMarketEkle.Size = new System.Drawing.Size(32, 22);
            this.btnMarketEkle.Text = "Ekle";
            this.btnMarketEkle.Click += new System.EventHandler(this.btnMarketEkle_Click);
            // 
            // btnMarketDuzenle
            // 
            this.btnMarketDuzenle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMarketDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnMarketDuzenle.Image")));
            this.btnMarketDuzenle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarketDuzenle.Name = "btnMarketDuzenle";
            this.btnMarketDuzenle.Size = new System.Drawing.Size(53, 22);
            this.btnMarketDuzenle.Text = "Düzenle";
            this.btnMarketDuzenle.Click += new System.EventHandler(this.btnMarketDuzenle_Click);
            // 
            // btnMarketSil
            // 
            this.btnMarketSil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMarketSil.Image = ((System.Drawing.Image)(resources.GetObject("btnMarketSil.Image")));
            this.btnMarketSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMarketSil.Name = "btnMarketSil";
            this.btnMarketSil.Size = new System.Drawing.Size(23, 22);
            this.btnMarketSil.Text = "Sil";
            this.btnMarketSil.Click += new System.EventHandler(this.btnMarketSil_Click);
            // 
            // btnMarketBul
            // 
            this.btnMarketBul.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMarketBul.BackColor = System.Drawing.Color.White;
            this.btnMarketBul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMarketBul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMarketBul.Image = ((System.Drawing.Image)(resources.GetObject("btnMarketBul.Image")));
            this.btnMarketBul.ImageTransparentColor = System.Drawing.Color.White;
            this.btnMarketBul.Name = "btnMarketBul";
            this.btnMarketBul.Size = new System.Drawing.Size(28, 22);
            this.btnMarketBul.Text = "Bul";
            this.btnMarketBul.Click += new System.EventHandler(this.btnMarketBul_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 22);
            this.toolStripLabel1.Text = "Ara:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(786, 393);
            this.dataGridView1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // Marketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Marketler";
            this.Text = "Marketler";
            this.Load += new System.EventHandler(this.Marketler_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMarketEkle;
        private System.Windows.Forms.ToolStripButton btnMarketDuzenle;
        private System.Windows.Forms.ToolStripButton btnMarketSil;
        private System.Windows.Forms.ToolStripButton btnMarketBul;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TabControl tabControl1;
    }
}