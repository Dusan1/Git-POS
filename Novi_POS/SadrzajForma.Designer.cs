namespace Novi_POS
{
    partial class SadrzajForma
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtInfoPanel = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(433, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 228);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBox1_Format);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(414, 238);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 307);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(414, 85);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // txtInfoPanel
            // 
            this.txtInfoPanel.Location = new System.Drawing.Point(434, 16);
            this.txtInfoPanel.Multiline = true;
            this.txtInfoPanel.Name = "txtInfoPanel";
            this.txtInfoPanel.Size = new System.Drawing.Size(192, 33);
            this.txtInfoPanel.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(434, 307);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(192, 34);
            this.txtTotal.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 347);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 41);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnViewProducts
            // 
            this.btnViewProducts.Location = new System.Drawing.Point(13, 12);
            this.btnViewProducts.Name = "btnViewProducts";
            this.btnViewProducts.Size = new System.Drawing.Size(87, 37);
            this.btnViewProducts.TabIndex = 7;
            this.btnViewProducts.Text = "View Products";
            this.btnViewProducts.UseVisualStyleBackColor = true;
            this.btnViewProducts.Click += new System.EventHandler(this.btnViewProducts_Click);
            // 
            // SadrzajForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 400);
            this.Controls.Add(this.btnViewProducts);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtInfoPanel);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "SadrzajForma";
            this.Text = "SadrzajForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox txtInfoPanel;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewProducts;

    }
}