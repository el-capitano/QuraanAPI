
namespace QuraanAPI
{
    partial class Form1
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
            this.btnFetchAPI = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetSingleSura = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridDetails = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFetchAPI
            // 
            this.btnFetchAPI.Location = new System.Drawing.Point(18, 40);
            this.btnFetchAPI.Name = "btnFetchAPI";
            this.btnFetchAPI.Size = new System.Drawing.Size(184, 46);
            this.btnFetchAPI.TabIndex = 0;
            this.btnFetchAPI.Text = "Get All Suras";
            this.btnFetchAPI.UseVisualStyleBackColor = true;
            this.btnFetchAPI.Click += new System.EventHandler(this.btnFetchAPI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParam);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGetSingleSura);
            this.groupBox1.Controls.Add(this.btnFetchAPI);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Requests";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(709, 15);
            this.txtParam.Name = "txtParam";
            this.txtParam.Size = new System.Drawing.Size(217, 22);
            this.txtParam.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parameter";
            // 
            // btnGetSingleSura
            // 
            this.btnGetSingleSura.Location = new System.Drawing.Point(208, 40);
            this.btnGetSingleSura.Name = "btnGetSingleSura";
            this.btnGetSingleSura.Size = new System.Drawing.Size(184, 46);
            this.btnGetSingleSura.TabIndex = 1;
            this.btnGetSingleSura.Text = "Get Single Sura";
            this.btnGetSingleSura.UseVisualStyleBackColor = true;
            this.btnGetSingleSura.Click += new System.EventHandler(this.btnGetSingleSura_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 493);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridDetails
            // 
            this.dataGridDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetails.Location = new System.Drawing.Point(611, 141);
            this.dataGridDetails.Name = "dataGridDetails";
            this.dataGridDetails.RowHeadersWidth = 51;
            this.dataGridDetails.RowTemplate.Height = 24;
            this.dataGridDetails.Size = new System.Drawing.Size(1301, 493);
            this.dataGridDetails.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 717);
            this.Controls.Add(this.dataGridDetails);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuraanAPI C# Client";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFetchAPI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetSingleSura;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridDetails;
    }
}

