namespace Lab2
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
            this.components = new System.ComponentModel.Container();
            this.OG = new Emgu.CV.UI.ImageBox();
            this.Res = new Emgu.CV.UI.ImageBox();
            this.LoadImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ScaleNum = new System.Windows.Forms.TextBox();
            this.Scale = new System.Windows.Forms.Button();
            this.Project = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ShearNum = new System.Windows.Forms.TextBox();
            this.Shear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CenterX = new System.Windows.Forms.TextBox();
            this.Angle = new System.Windows.Forms.TextBox();
            this.Rotation = new System.Windows.Forms.Button();
            this.CenterY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Reflection = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FlipX = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FlipY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.OG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Res)).BeginInit();
            this.SuspendLayout();
            // 
            // OG
            // 
            this.OG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OG.Location = new System.Drawing.Point(12, 12);
            this.OG.Name = "OG";
            this.OG.Size = new System.Drawing.Size(500, 500);
            this.OG.TabIndex = 2;
            this.OG.TabStop = false;
            this.OG.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OG_MouseClick);
            // 
            // Res
            // 
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res.Location = new System.Drawing.Point(672, 12);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(500, 500);
            this.Res.TabIndex = 3;
            this.Res.TabStop = false;
            // 
            // LoadImg
            // 
            this.LoadImg.Location = new System.Drawing.Point(545, 12);
            this.LoadImg.Name = "LoadImg";
            this.LoadImg.Size = new System.Drawing.Size(100, 50);
            this.LoadImg.TabIndex = 4;
            this.LoadImg.Text = "Load";
            this.LoadImg.UseVisualStyleBackColor = true;
            this.LoadImg.Click += new System.EventHandler(this.LoadImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "---Scale---";
            // 
            // ScaleNum
            // 
            this.ScaleNum.Location = new System.Drawing.Point(545, 93);
            this.ScaleNum.Name = "ScaleNum";
            this.ScaleNum.Size = new System.Drawing.Size(100, 22);
            this.ScaleNum.TabIndex = 6;
            // 
            // Scale
            // 
            this.Scale.Location = new System.Drawing.Point(557, 121);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(75, 30);
            this.Scale.TabIndex = 7;
            this.Scale.Text = "Confirm";
            this.Scale.UseVisualStyleBackColor = true;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // Project
            // 
            this.Project.Location = new System.Drawing.Point(545, 472);
            this.Project.Name = "Project";
            this.Project.Size = new System.Drawing.Size(90, 35);
            this.Project.TabIndex = 8;
            this.Project.Text = "Projection";
            this.Project.UseVisualStyleBackColor = true;
            this.Project.Click += new System.EventHandler(this.Project_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "---Shear---";
            // 
            // ShearNum
            // 
            this.ShearNum.Location = new System.Drawing.Point(544, 186);
            this.ShearNum.Name = "ShearNum";
            this.ShearNum.Size = new System.Drawing.Size(100, 22);
            this.ShearNum.TabIndex = 10;
            // 
            // Shear
            // 
            this.Shear.Location = new System.Drawing.Point(557, 214);
            this.Shear.Name = "Shear";
            this.Shear.Size = new System.Drawing.Size(75, 30);
            this.Shear.TabIndex = 11;
            this.Shear.Text = "Confirm";
            this.Shear.UseVisualStyleBackColor = true;
            this.Shear.Click += new System.EventHandler(this.Shear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "---Rotation---";
            // 
            // CenterX
            // 
            this.CenterX.BackColor = System.Drawing.SystemColors.Window;
            this.CenterX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CenterX.Location = new System.Drawing.Point(545, 281);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(33, 22);
            this.CenterX.TabIndex = 13;
            // 
            // Angle
            // 
            this.Angle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Angle.Location = new System.Drawing.Point(544, 337);
            this.Angle.Name = "Angle";
            this.Angle.Size = new System.Drawing.Size(34, 22);
            this.Angle.TabIndex = 14;
            // 
            // Rotation
            // 
            this.Rotation.Location = new System.Drawing.Point(589, 305);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(75, 30);
            this.Rotation.TabIndex = 15;
            this.Rotation.Text = "Confirm";
            this.Rotation.UseVisualStyleBackColor = true;
            this.Rotation.Click += new System.EventHandler(this.Rotation_Click);
            // 
            // CenterY
            // 
            this.CenterY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CenterY.Location = new System.Drawing.Point(544, 309);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(34, 22);
            this.CenterY.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "---Reflection---";
            // 
            // Reflection
            // 
            this.Reflection.Location = new System.Drawing.Point(552, 426);
            this.Reflection.Name = "Reflection";
            this.Reflection.Size = new System.Drawing.Size(75, 30);
            this.Reflection.TabIndex = 21;
            this.Reflection.Text = "Confirm";
            this.Reflection.UseVisualStyleBackColor = true;
            this.Reflection.Click += new System.EventHandler(this.Reflection_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "X:";
            // 
            // FlipX
            // 
            this.FlipX.BackColor = System.Drawing.SystemColors.Window;
            this.FlipX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FlipX.Location = new System.Drawing.Point(545, 396);
            this.FlipX.Name = "FlipX";
            this.FlipX.Size = new System.Drawing.Size(33, 22);
            this.FlipX.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(604, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Y:";
            // 
            // FlipY
            // 
            this.FlipY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FlipY.Location = new System.Drawing.Point(630, 396);
            this.FlipY.Name = "FlipY";
            this.FlipY.Size = new System.Drawing.Size(34, 22);
            this.FlipY.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 551);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FlipY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FlipX);
            this.Controls.Add(this.Reflection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CenterY);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.Angle);
            this.Controls.Add(this.CenterX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shear);
            this.Controls.Add(this.ShearNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Project);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.ScaleNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadImg);
            this.Controls.Add(this.Res);
            this.Controls.Add(this.OG);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.OG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Res)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox OG;
        private Emgu.CV.UI.ImageBox Res;
        private System.Windows.Forms.Button LoadImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ScaleNum;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.Button Project;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShearNum;
        private System.Windows.Forms.Button Shear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CenterX;
        private System.Windows.Forms.TextBox Angle;
        private System.Windows.Forms.Button Rotation;
        private System.Windows.Forms.TextBox CenterY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Reflection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FlipX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FlipY;
    }
}

