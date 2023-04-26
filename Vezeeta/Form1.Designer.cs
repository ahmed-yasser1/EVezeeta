namespace Vezeeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "search for a Doctor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb1
            // 
            this.cmb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.cmb1.ForeColor = System.Drawing.Color.Black;
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(495, 121);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(151, 21);
            this.cmb1.TabIndex = 1;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(389, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speciality";
            // 
            // grid1
            // 
            this.grid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.grid1.Location = new System.Drawing.Point(207, 200);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(775, 366);
            this.grid1.TabIndex = 3;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(1052, 575);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(184, 57);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "Update Info";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
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
            this.btn3.TabIndex = 28;
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn4.BackgroundImage")));
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(45, 12);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(45, 31);
            this.btn4.TabIndex = 27;
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1265, 656);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
    }
}

