namespace win_shape
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
            this.grp_Shape = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rd_Square = new System.Windows.Forms.RadioButton();
            this.rd_Rectangle = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSides = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grp_Rectangle = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrecLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.grp_Square = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsqLength = new System.Windows.Forms.TextBox();
            this.btnDIsplay = new System.Windows.Forms.Button();
            this.grp_Shape.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grp_Rectangle.SuspendLayout();
            this.grp_Square.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_Shape
            // 
            this.grp_Shape.Controls.Add(this.rd_Rectangle);
            this.grp_Shape.Controls.Add(this.rd_Square);
            this.grp_Shape.Location = new System.Drawing.Point(12, 23);
            this.grp_Shape.Name = "grp_Shape";
            this.grp_Shape.Size = new System.Drawing.Size(141, 94);
            this.grp_Shape.TabIndex = 0;
            this.grp_Shape.TabStop = false;
            this.grp_Shape.Text = "Shape";
            this.grp_Shape.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rd_Square
            // 
            this.rd_Square.AutoSize = true;
            this.rd_Square.Location = new System.Drawing.Point(17, 33);
            this.rd_Square.Name = "rd_Square";
            this.rd_Square.Size = new System.Drawing.Size(59, 17);
            this.rd_Square.TabIndex = 0;
            this.rd_Square.TabStop = true;
            this.rd_Square.Text = "Square";
            this.rd_Square.UseVisualStyleBackColor = true;
            this.rd_Square.CheckedChanged += new System.EventHandler(this.rd_Square_CheckedChanged);
            // 
            // rd_Rectangle
            // 
            this.rd_Rectangle.AutoSize = true;
            this.rd_Rectangle.Location = new System.Drawing.Point(17, 56);
            this.rd_Rectangle.Name = "rd_Rectangle";
            this.rd_Rectangle.Size = new System.Drawing.Size(74, 17);
            this.rd_Rectangle.TabIndex = 0;
            this.rd_Rectangle.TabStop = true;
            this.rd_Rectangle.Text = "Rectangle";
            this.rd_Rectangle.UseVisualStyleBackColor = true;
            this.rd_Rectangle.CheckedChanged += new System.EventHandler(this.rd_Rectangle_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtSides);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(201, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = " No. of Sides";
            // 
            // txtSides
            // 
            this.txtSides.Location = new System.Drawing.Point(91, 51);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(100, 20);
            this.txtSides.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(91, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // grp_Rectangle
            // 
            this.grp_Rectangle.Controls.Add(this.txtWidth);
            this.grp_Rectangle.Controls.Add(this.txtrecLength);
            this.grp_Rectangle.Controls.Add(this.label4);
            this.grp_Rectangle.Controls.Add(this.label3);
            this.grp_Rectangle.Location = new System.Drawing.Point(12, 157);
            this.grp_Rectangle.Name = "grp_Rectangle";
            this.grp_Rectangle.Size = new System.Drawing.Size(189, 87);
            this.grp_Rectangle.TabIndex = 2;
            this.grp_Rectangle.TabStop = false;
            this.grp_Rectangle.Text = "Rectangle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Width";
            // 
            // txtrecLength
            // 
            this.txtrecLength.Location = new System.Drawing.Point(82, 22);
            this.txtrecLength.Name = "txtrecLength";
            this.txtrecLength.Size = new System.Drawing.Size(100, 20);
            this.txtrecLength.TabIndex = 1;
            this.txtrecLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(82, 48);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 1;
            // 
            // grp_Square
            // 
            this.grp_Square.Controls.Add(this.label5);
            this.grp_Square.Controls.Add(this.txtsqLength);
            this.grp_Square.Location = new System.Drawing.Point(238, 157);
            this.grp_Square.Name = "grp_Square";
            this.grp_Square.Size = new System.Drawing.Size(173, 75);
            this.grp_Square.TabIndex = 3;
            this.grp_Square.TabStop = false;
            this.grp_Square.Text = "Square";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Length";
            // 
            // txtsqLength
            // 
            this.txtsqLength.Location = new System.Drawing.Point(54, 18);
            this.txtsqLength.Name = "txtsqLength";
            this.txtsqLength.Size = new System.Drawing.Size(100, 20);
            this.txtsqLength.TabIndex = 1;
            this.txtsqLength.TextChanged += new System.EventHandler(this.txtLength_TextChanged);
            // 
            // btnDIsplay
            // 
            this.btnDIsplay.Location = new System.Drawing.Point(178, 260);
            this.btnDIsplay.Name = "btnDIsplay";
            this.btnDIsplay.Size = new System.Drawing.Size(75, 23);
            this.btnDIsplay.TabIndex = 4;
            this.btnDIsplay.Text = "Display";
            this.btnDIsplay.UseVisualStyleBackColor = true;
            this.btnDIsplay.Click += new System.EventHandler(this.btnDIsplay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 450);
            this.Controls.Add(this.btnDIsplay);
            this.Controls.Add(this.grp_Square);
            this.Controls.Add(this.grp_Rectangle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_Shape);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_Shape.ResumeLayout(false);
            this.grp_Shape.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grp_Rectangle.ResumeLayout(false);
            this.grp_Rectangle.PerformLayout();
            this.grp_Square.ResumeLayout(false);
            this.grp_Square.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Shape;
        private System.Windows.Forms.RadioButton rd_Rectangle;
        private System.Windows.Forms.RadioButton rd_Square;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grp_Rectangle;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtrecLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_Square;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsqLength;
        private System.Windows.Forms.Button btnDIsplay;
    }
}

