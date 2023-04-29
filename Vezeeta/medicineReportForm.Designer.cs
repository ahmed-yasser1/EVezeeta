
namespace Vezeeta
{
    partial class medicineReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(medicineReportForm));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.Generate_report = new System.Windows.Forms.Button();
            this.back_BTNNN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Generate_report
            // 
            this.Generate_report.Location = new System.Drawing.Point(632, 32);
            this.Generate_report.Name = "Generate_report";
            this.Generate_report.Size = new System.Drawing.Size(156, 23);
            this.Generate_report.TabIndex = 1;
            this.Generate_report.Text = "Generate Rport";
            this.Generate_report.UseVisualStyleBackColor = true;
            this.Generate_report.Click += new System.EventHandler(this.Generate_report_Click);
            // 
            // back_BTNNN
            // 
            this.back_BTNNN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.back_BTNNN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_BTNNN.BackgroundImage")));
            this.back_BTNNN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_BTNNN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.back_BTNNN.FlatAppearance.BorderSize = 0;
            this.back_BTNNN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.back_BTNNN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.back_BTNNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_BTNNN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_BTNNN.Location = new System.Drawing.Point(715, 375);
            this.back_BTNNN.Margin = new System.Windows.Forms.Padding(4);
            this.back_BTNNN.Name = "back_BTNNN";
            this.back_BTNNN.Size = new System.Drawing.Size(60, 38);
            this.back_BTNNN.TabIndex = 29;
            this.back_BTNNN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_BTNNN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.back_BTNNN.UseVisualStyleBackColor = false;
            this.back_BTNNN.Click += new System.EventHandler(this.back_BTNNN_Click);
            // 
            // medicineReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_BTNNN);
            this.Controls.Add(this.Generate_report);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "medicineReportForm";
            this.Text = "medicineReportForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button Generate_report;
        private System.Windows.Forms.Button back_BTNNN;
    }
}