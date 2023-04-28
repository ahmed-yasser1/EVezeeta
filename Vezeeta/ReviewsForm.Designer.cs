
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReviewsForm));
            this.show_review_btn = new System.Windows.Forms.Button();
            this.DoctorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reviews = new System.Windows.Forms.DataGridView();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Reviews)).BeginInit();
            this.SuspendLayout();
            // 
            // show_review_btn
            // 
            this.show_review_btn.Location = new System.Drawing.Point(230, 295);
            this.show_review_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.show_review_btn.Name = "show_review_btn";
            this.show_review_btn.Size = new System.Drawing.Size(96, 34);
            this.show_review_btn.TabIndex = 0;
            this.show_review_btn.Text = "Get Reviews";
            this.show_review_btn.UseVisualStyleBackColor = true;
            this.show_review_btn.Click += new System.EventHandler(this.show_review_btn_Click);
            // 
            // DoctorName
            // 
            this.DoctorName.Location = new System.Drawing.Point(172, 84);
            this.DoctorName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoctorName.Name = "DoctorName";
            this.DoctorName.Size = new System.Drawing.Size(213, 20);
            this.DoctorName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Doctor\'s Name";
            // 
            // Reviews
            // 
            this.Reviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Reviews.Location = new System.Drawing.Point(172, 106);
            this.Reviews.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Reviews.Name = "Reviews";
            this.Reviews.RowHeadersWidth = 51;
            this.Reviews.RowTemplate.Height = 24;
            this.Reviews.Size = new System.Drawing.Size(212, 140);
            this.Reviews.TabIndex = 3;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn3.BackgroundImage")));
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(12, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(45, 31);
            this.btn3.TabIndex = 29;
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // ReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorName);
            this.Controls.Add(this.show_review_btn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btn3;
    }
}