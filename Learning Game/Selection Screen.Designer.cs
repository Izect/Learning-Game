namespace Learning_Game
{
    partial class frm_select
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
            this.btn_math = new System.Windows.Forms.Button();
            this.btn_puzzle = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_math
            // 
            this.btn_math.Location = new System.Drawing.Point(345, 476);
            this.btn_math.Name = "btn_math";
            this.btn_math.Size = new System.Drawing.Size(197, 59);
            this.btn_math.TabIndex = 0;
            this.btn_math.Text = "Math";
            this.btn_math.UseVisualStyleBackColor = true;
            this.btn_math.Click += new System.EventHandler(this.btn_math_Click);
            // 
            // btn_puzzle
            // 
            this.btn_puzzle.Location = new System.Drawing.Point(548, 476);
            this.btn_puzzle.Name = "btn_puzzle";
            this.btn_puzzle.Size = new System.Drawing.Size(199, 59);
            this.btn_puzzle.TabIndex = 0;
            this.btn_puzzle.Text = "Puzzle";
            this.btn_puzzle.UseVisualStyleBackColor = true;
            this.btn_puzzle.Click += new System.EventHandler(this.btn_puzzle_Click);
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(753, 476);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(199, 59);
            this.btn_color.TabIndex = 0;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // frm_select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1363, 712);
            this.Controls.Add(this.btn_color);
            this.Controls.Add(this.btn_puzzle);
            this.Controls.Add(this.btn_math);
            this.Name = "frm_select";
            this.Text = "Selection_Screen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_math;
        private System.Windows.Forms.Button btn_puzzle;
        private System.Windows.Forms.Button btn_color;
    }
}