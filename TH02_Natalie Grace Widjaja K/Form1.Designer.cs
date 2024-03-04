namespace TH02
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
            this.lb_kata1 = new System.Windows.Forms.Label();
            this.lb_kata2 = new System.Windows.Forms.Label();
            this.lb_kata3 = new System.Windows.Forms.Label();
            this.lb_kata4 = new System.Windows.Forms.Label();
            this.tb_kata1 = new System.Windows.Forms.TextBox();
            this.tb_kata2 = new System.Windows.Forms.TextBox();
            this.tb_kata3 = new System.Windows.Forms.TextBox();
            this.tb_kata4 = new System.Windows.Forms.TextBox();
            this.tb_kata5 = new System.Windows.Forms.TextBox();
            this.lb_kata5 = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_kata1
            // 
            this.lb_kata1.AutoSize = true;
            this.lb_kata1.Location = new System.Drawing.Point(175, 91);
            this.lb_kata1.Name = "lb_kata1";
            this.lb_kata1.Size = new System.Drawing.Size(45, 13);
            this.lb_kata1.TabIndex = 0;
            this.lb_kata1.Text = "Word 1:";
            // 
            // lb_kata2
            // 
            this.lb_kata2.AutoSize = true;
            this.lb_kata2.Location = new System.Drawing.Point(175, 132);
            this.lb_kata2.Name = "lb_kata2";
            this.lb_kata2.Size = new System.Drawing.Size(45, 13);
            this.lb_kata2.TabIndex = 1;
            this.lb_kata2.Text = "Word 2:";
            // 
            // lb_kata3
            // 
            this.lb_kata3.AutoSize = true;
            this.lb_kata3.Location = new System.Drawing.Point(175, 176);
            this.lb_kata3.Name = "lb_kata3";
            this.lb_kata3.Size = new System.Drawing.Size(45, 13);
            this.lb_kata3.TabIndex = 2;
            this.lb_kata3.Text = "Word 3:";
            // 
            // lb_kata4
            // 
            this.lb_kata4.AutoSize = true;
            this.lb_kata4.Location = new System.Drawing.Point(175, 220);
            this.lb_kata4.Name = "lb_kata4";
            this.lb_kata4.Size = new System.Drawing.Size(45, 13);
            this.lb_kata4.TabIndex = 3;
            this.lb_kata4.Text = "Word 4:";
            // 
            // tb_kata1
            // 
            this.tb_kata1.Location = new System.Drawing.Point(226, 88);
            this.tb_kata1.Name = "tb_kata1";
            this.tb_kata1.Size = new System.Drawing.Size(100, 20);
            this.tb_kata1.TabIndex = 4;
            // 
            // tb_kata2
            // 
            this.tb_kata2.Location = new System.Drawing.Point(226, 132);
            this.tb_kata2.Name = "tb_kata2";
            this.tb_kata2.Size = new System.Drawing.Size(100, 20);
            this.tb_kata2.TabIndex = 5;
            // 
            // tb_kata3
            // 
            this.tb_kata3.Location = new System.Drawing.Point(226, 176);
            this.tb_kata3.Name = "tb_kata3";
            this.tb_kata3.Size = new System.Drawing.Size(100, 20);
            this.tb_kata3.TabIndex = 6;
            // 
            // tb_kata4
            // 
            this.tb_kata4.Location = new System.Drawing.Point(226, 220);
            this.tb_kata4.Name = "tb_kata4";
            this.tb_kata4.Size = new System.Drawing.Size(100, 20);
            this.tb_kata4.TabIndex = 7;
            // 
            // tb_kata5
            // 
            this.tb_kata5.Location = new System.Drawing.Point(226, 261);
            this.tb_kata5.Name = "tb_kata5";
            this.tb_kata5.Size = new System.Drawing.Size(100, 20);
            this.tb_kata5.TabIndex = 8;
            // 
            // lb_kata5
            // 
            this.lb_kata5.AutoSize = true;
            this.lb_kata5.Location = new System.Drawing.Point(175, 261);
            this.lb_kata5.Name = "lb_kata5";
            this.lb_kata5.Size = new System.Drawing.Size(45, 13);
            this.lb_kata5.TabIndex = 9;
            this.lb_kata5.Text = "Word 5:";
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(239, 302);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 10;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.lb_kata5);
            this.Controls.Add(this.tb_kata5);
            this.Controls.Add(this.tb_kata4);
            this.Controls.Add(this.tb_kata3);
            this.Controls.Add(this.tb_kata2);
            this.Controls.Add(this.tb_kata1);
            this.Controls.Add(this.lb_kata4);
            this.Controls.Add(this.lb_kata3);
            this.Controls.Add(this.lb_kata2);
            this.Controls.Add(this.lb_kata1);
            this.Name = "Form1";
            this.Text = "Word 1:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_kata1;
        private System.Windows.Forms.Label lb_kata2;
        private System.Windows.Forms.Label lb_kata3;
        private System.Windows.Forms.Label lb_kata4;
        private System.Windows.Forms.TextBox tb_kata1;
        private System.Windows.Forms.TextBox tb_kata2;
        private System.Windows.Forms.TextBox tb_kata3;
        private System.Windows.Forms.TextBox tb_kata4;
        private System.Windows.Forms.TextBox tb_kata5;
        private System.Windows.Forms.Label lb_kata5;
        private System.Windows.Forms.Button btn_play;
    }
}

