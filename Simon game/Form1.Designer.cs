namespace Simon_game
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
            this.playButton = new System.Windows.Forms.Button();
            this.exitButton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.playButton.Location = new System.Drawing.Point(86, 134);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(0, 0);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // exitButton2
            // 
            this.exitButton2.BackColor = System.Drawing.Color.Black;
            this.exitButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton2.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton2.ForeColor = System.Drawing.Color.Red;
            this.exitButton2.Location = new System.Drawing.Point(86, 246);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(0, 0);
            this.exitButton2.TabIndex = 1;
            this.exitButton2.Text = "EXIT";
            this.exitButton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 336);
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.playButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton2;
    }
}

