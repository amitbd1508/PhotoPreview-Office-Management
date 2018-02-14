namespace PhotoPreview.UC_photographers
{
    partial class UC_PG_Photographer_Tab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPhotographers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlTabPhotographers = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 42);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPhotographers, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(803, 42);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnPhotographers
            // 
            this.btnPhotographers.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPhotographers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhotographers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhotographers.ForeColor = System.Drawing.Color.Red;
            this.btnPhotographers.Location = new System.Drawing.Point(3, 3);
            this.btnPhotographers.Name = "btnPhotographers";
            this.btnPhotographers.Size = new System.Drawing.Size(261, 36);
            this.btnPhotographers.TabIndex = 0;
            this.btnPhotographers.Text = "Photographers";
            this.btnPhotographers.UseVisualStyleBackColor = false;
            this.btnPhotographers.Click += new System.EventHandler(this.btnPhotographers_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(270, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bill Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gainsboro;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(537, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delivery";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pnlTabPhotographers
            // 
            this.pnlTabPhotographers.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlTabPhotographers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabPhotographers.Location = new System.Drawing.Point(0, 42);
            this.pnlTabPhotographers.Name = "pnlTabPhotographers";
            this.pnlTabPhotographers.Size = new System.Drawing.Size(803, 360);
            this.pnlTabPhotographers.TabIndex = 2;
            // 
            // UC_PG_Photographer_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTabPhotographers);
            this.Controls.Add(this.panel1);
            this.Name = "UC_PG_Photographer_Tab";
            this.Size = new System.Drawing.Size(803, 402);
            this.Load += new System.EventHandler(this.UC_PG_Photographer_Tab_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPhotographers;
        private System.Windows.Forms.Panel pnlTabPhotographers;
    }
}
