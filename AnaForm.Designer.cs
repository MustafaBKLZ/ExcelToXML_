
namespace ExcelToXML
{
    partial class AnaForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonGoster = new System.Windows.Forms.Button();
            this.btn_verileri_xmle_al = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 281);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(11, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(467, 20);
            this.textBox1.TabIndex = 2;
            // 
            // buttonGoster
            // 
            this.buttonGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGoster.Location = new System.Drawing.Point(482, 5);
            this.buttonGoster.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGoster.Name = "buttonGoster";
            this.buttonGoster.Size = new System.Drawing.Size(134, 28);
            this.buttonGoster.TabIndex = 3;
            this.buttonGoster.Text = "Excel Seç ve Göster";
            this.buttonGoster.UseVisualStyleBackColor = true;
            this.buttonGoster.Click += new System.EventHandler(this.buttonGoster_Click);
            // 
            // btn_verileri_xmle_al
            // 
            this.btn_verileri_xmle_al.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_verileri_xmle_al.Location = new System.Drawing.Point(482, 323);
            this.btn_verileri_xmle_al.Margin = new System.Windows.Forms.Padding(2);
            this.btn_verileri_xmle_al.Name = "btn_verileri_xmle_al";
            this.btn_verileri_xmle_al.Size = new System.Drawing.Size(134, 28);
            this.btn_verileri_xmle_al.TabIndex = 4;
            this.btn_verileri_xmle_al.Text = "Verileri XML\'e Aktar";
            this.btn_verileri_xmle_al.UseVisualStyleBackColor = true;
            this.btn_verileri_xmle_al.Click += new System.EventHandler(this.btn_verileri_xmle_al_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 362);
            this.Controls.Add(this.btn_verileri_xmle_al);
            this.Controls.Add(this.buttonGoster);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonGoster;
        private System.Windows.Forms.Button btn_verileri_xmle_al;
    }
}

