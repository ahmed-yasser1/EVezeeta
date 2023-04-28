
namespace Vezeeta
{
    partial class ReviewsForm
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
            this.show_review_btn = new System.Windows.Forms.Button();
            this.DoctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reviews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Reviews)).BeginInit();
            this.SuspendLayout();
            // 
            // show_review_btn
            // 
            this.show_review_btn.Location = new System.Drawing.Point(307, 363);
            this.show_review_btn.Name = "show_review_btn";
            this.show_review_btn.Size = new System.Drawing.Size(128, 42);
            this.show_review_btn.TabIndex = 0;
            this.show_review_btn.Text = "Get Reviews";
            this.show_review_btn.UseVisualStyleBackColor = true;
            this.show_review_btn.Click += new System.EventHandler(this.show_review_btn_Click);
            // 
            // DoctorName
            // 
            this.DoctorName.Location = new System.Drawing.Point(230, 103);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(283, 22);
            this.DoctorName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor\'s Name";
            // 
            // Reviews
            // 
            this.Reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reviews.Location = new System.Drawing.Point(230, 131);
            this.Reviews.Name = "Reviews";
            this.Reviews.RowHeadersWidth = 51;
            this.Reviews.RowTemplate.Height = 24;
            this.Reviews.Size = new System.Drawing.Size(283, 172);
            this.Reviews.TabIndex = 3;
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.show_review_btn);
            this.Name = "ReviewsForm";
            this.Text = "ReviewsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReviewsForm_FormClosing);
            this.Load += new System.EventHandler(this.ReviewsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reviews)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_review_btn;
        private System.Windows.Forms.TextBox DoctorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Reviews;
    }
}