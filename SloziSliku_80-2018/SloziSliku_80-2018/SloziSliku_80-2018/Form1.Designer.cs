
namespace SloziSliku_80_2018
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
            this.btn_loadImg = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.lbl_move = new System.Windows.Forms.Label();
            this.lbl_moveCount = new System.Windows.Forms.Label();
            this.gb_row = new System.Windows.Forms.GroupBox();
            this.rb_row4 = new System.Windows.Forms.RadioButton();
            this.rb_row5 = new System.Windows.Forms.RadioButton();
            this.rb_row3 = new System.Windows.Forms.RadioButton();
            this.gb_col = new System.Windows.Forms.GroupBox();
            this.rb_col4 = new System.Windows.Forms.RadioButton();
            this.rb_col3 = new System.Windows.Forms.RadioButton();
            this.rb_col5 = new System.Windows.Forms.RadioButton();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.lbl_imgName = new System.Windows.Forms.Label();
            this.btn_results = new System.Windows.Forms.Button();
            this.lbl_img = new System.Windows.Forms.Label();
            this.gb_row.SuspendLayout();
            this.gb_col.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_loadImg
            // 
            this.btn_loadImg.Location = new System.Drawing.Point(1161, 12);
            this.btn_loadImg.Name = "btn_loadImg";
            this.btn_loadImg.Size = new System.Drawing.Size(109, 31);
            this.btn_loadImg.TabIndex = 0;
            this.btn_loadImg.Text = "Ucitaj sliku";
            this.btn_loadImg.UseVisualStyleBackColor = true;
            this.btn_loadImg.Click += new System.EventHandler(this.btn_loadImg_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.Location = new System.Drawing.Point(1161, 97);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(109, 31);
            this.btn_newGame.TabIndex = 1;
            this.btn_newGame.Text = "Nova igra";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // lbl_move
            // 
            this.lbl_move.AutoSize = true;
            this.lbl_move.Location = new System.Drawing.Point(1158, 140);
            this.lbl_move.Name = "lbl_move";
            this.lbl_move.Size = new System.Drawing.Size(56, 17);
            this.lbl_move.TabIndex = 3;
            this.lbl_move.Text = "Poteza:";
            // 
            // lbl_moveCount
            // 
            this.lbl_moveCount.AutoSize = true;
            this.lbl_moveCount.Location = new System.Drawing.Point(1227, 140);
            this.lbl_moveCount.Name = "lbl_moveCount";
            this.lbl_moveCount.Size = new System.Drawing.Size(0, 17);
            this.lbl_moveCount.TabIndex = 4;
            // 
            // gb_row
            // 
            this.gb_row.Controls.Add(this.rb_row4);
            this.gb_row.Controls.Add(this.rb_row5);
            this.gb_row.Controls.Add(this.rb_row3);
            this.gb_row.Location = new System.Drawing.Point(1161, 175);
            this.gb_row.Name = "gb_row";
            this.gb_row.Size = new System.Drawing.Size(108, 104);
            this.gb_row.TabIndex = 5;
            this.gb_row.TabStop = false;
            this.gb_row.Text = "Broj vrsta";
            // 
            // rb_row4
            // 
            this.rb_row4.AutoSize = true;
            this.rb_row4.Location = new System.Drawing.Point(29, 48);
            this.rb_row4.Name = "rb_row4";
            this.rb_row4.Size = new System.Drawing.Size(37, 21);
            this.rb_row4.TabIndex = 8;
            this.rb_row4.Text = "4";
            this.rb_row4.UseVisualStyleBackColor = true;
            this.rb_row4.CheckedChanged += new System.EventHandler(this.rb_row4_CheckedChanged);
            // 
            // rb_row5
            // 
            this.rb_row5.AutoSize = true;
            this.rb_row5.Location = new System.Drawing.Point(29, 75);
            this.rb_row5.Name = "rb_row5";
            this.rb_row5.Size = new System.Drawing.Size(37, 21);
            this.rb_row5.TabIndex = 9;
            this.rb_row5.Text = "5";
            this.rb_row5.UseVisualStyleBackColor = true;
            this.rb_row5.CheckedChanged += new System.EventHandler(this.rb_row5_CheckedChanged);
            // 
            // rb_row3
            // 
            this.rb_row3.AutoSize = true;
            this.rb_row3.Checked = true;
            this.rb_row3.Location = new System.Drawing.Point(29, 21);
            this.rb_row3.Name = "rb_row3";
            this.rb_row3.Size = new System.Drawing.Size(37, 21);
            this.rb_row3.TabIndex = 7;
            this.rb_row3.TabStop = true;
            this.rb_row3.Text = "3";
            this.rb_row3.UseVisualStyleBackColor = true;
            this.rb_row3.CheckedChanged += new System.EventHandler(this.rb_row3_CheckedChanged);
            // 
            // gb_col
            // 
            this.gb_col.Controls.Add(this.rb_col4);
            this.gb_col.Controls.Add(this.rb_col3);
            this.gb_col.Controls.Add(this.rb_col5);
            this.gb_col.Location = new System.Drawing.Point(1161, 295);
            this.gb_col.Name = "gb_col";
            this.gb_col.Size = new System.Drawing.Size(108, 104);
            this.gb_col.TabIndex = 6;
            this.gb_col.TabStop = false;
            this.gb_col.Text = "Broj kolona";
            // 
            // rb_col4
            // 
            this.rb_col4.AutoSize = true;
            this.rb_col4.Location = new System.Drawing.Point(29, 48);
            this.rb_col4.Name = "rb_col4";
            this.rb_col4.Size = new System.Drawing.Size(37, 21);
            this.rb_col4.TabIndex = 11;
            this.rb_col4.Text = "4";
            this.rb_col4.UseVisualStyleBackColor = true;
            this.rb_col4.CheckedChanged += new System.EventHandler(this.rb_col4_CheckedChanged);
            // 
            // rb_col3
            // 
            this.rb_col3.AutoSize = true;
            this.rb_col3.Checked = true;
            this.rb_col3.Location = new System.Drawing.Point(29, 21);
            this.rb_col3.Name = "rb_col3";
            this.rb_col3.Size = new System.Drawing.Size(37, 21);
            this.rb_col3.TabIndex = 10;
            this.rb_col3.TabStop = true;
            this.rb_col3.Text = "3";
            this.rb_col3.UseVisualStyleBackColor = true;
            this.rb_col3.CheckedChanged += new System.EventHandler(this.rb_col3_CheckedChanged);
            // 
            // rb_col5
            // 
            this.rb_col5.AutoSize = true;
            this.rb_col5.Location = new System.Drawing.Point(29, 75);
            this.rb_col5.Name = "rb_col5";
            this.rb_col5.Size = new System.Drawing.Size(37, 21);
            this.rb_col5.TabIndex = 12;
            this.rb_col5.Text = "5";
            this.rb_col5.UseVisualStyleBackColor = true;
            this.rb_col5.CheckedChanged += new System.EventHandler(this.rb_col5_CheckedChanged);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(1161, 405);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(109, 31);
            this.btn_color.TabIndex = 7;
            this.btn_color.Text = "Boja linija";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(1160, 622);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(109, 31);
            this.btn_quit.TabIndex = 8;
            this.btn_quit.Text = "Kraj";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // lbl_imgName
            // 
            this.lbl_imgName.Location = new System.Drawing.Point(1164, 51);
            this.lbl_imgName.Name = "lbl_imgName";
            this.lbl_imgName.Size = new System.Drawing.Size(105, 34);
            this.lbl_imgName.TabIndex = 9;
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(1161, 452);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(109, 31);
            this.btn_results.TabIndex = 10;
            this.btn_results.Text = "Rezultati";
            this.btn_results.UseVisualStyleBackColor = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // lbl_img
            // 
            this.lbl_img.Location = new System.Drawing.Point(1161, 499);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(109, 103);
            this.lbl_img.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 658);
            this.Controls.Add(this.lbl_img);
            this.Controls.Add(this.btn_results);
            this.Controls.Add(this.lbl_imgName);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.gb_col);
            this.Controls.Add(this.gb_row);
            this.Controls.Add(this.lbl_moveCount);
            this.Controls.Add(this.lbl_move);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.btn_loadImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "SloziSliku_80-2018";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb_row.ResumeLayout(false);
            this.gb_row.PerformLayout();
            this.gb_col.ResumeLayout(false);
            this.gb_col.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadImg;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Label lbl_move;
        private System.Windows.Forms.Label lbl_moveCount;
        private System.Windows.Forms.GroupBox gb_row;
        private System.Windows.Forms.GroupBox gb_col;
        private System.Windows.Forms.RadioButton rb_row4;
        private System.Windows.Forms.RadioButton rb_row5;
        private System.Windows.Forms.RadioButton rb_row3;
        private System.Windows.Forms.RadioButton rb_col4;
        private System.Windows.Forms.RadioButton rb_col3;
        private System.Windows.Forms.RadioButton rb_col5;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Label lbl_imgName;
        private System.Windows.Forms.Button btn_results;
        private System.Windows.Forms.Label lbl_img;
    }
}

