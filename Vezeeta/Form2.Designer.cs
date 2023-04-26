namespace Vezeeta
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox1 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Update Doctor Information";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(1057, 568);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(149, 50);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "Save";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(385, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Doctor ID";
            // 
            // tbox1
            // 
            this.tbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.tbox1.Location = new System.Drawing.Point(483, 84);
            this.tbox1.Name = "tbox1";
            this.tbox1.Size = new System.Drawing.Size(127, 20);
            this.tbox1.TabIndex = 22;
            this.tbox1.TextChanged += new System.EventHandler(this.tbox1_TextChanged);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(473, 143);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(170, 47);
            this.btn2.TabIndex = 23;
            this.btn2.Text = "Load Inofrmation";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // grid1
            // 
            this.grid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(233)))), ((int)(((byte)(240)))));
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.grid1.Location = new System.Drawing.Point(211, 228);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(775, 366);
            this.grid1.TabIndex = 24;
            this.grid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid1_CellContentClick);
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
            this.btn4.TabIndex = 25;
            this.btn4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
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
            this.btn3.TabIndex = 26;
            this.btn3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(222)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(1265, 656);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.grid1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.tbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
    }
}