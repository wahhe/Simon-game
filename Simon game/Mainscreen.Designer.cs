namespace Simon_game
{
    partial class Mainscreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainscreen));
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
            this.playButton.Location = new System.Drawing.Point(86, 135);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(167, 69);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // exitButton2
            // 
            this.exitButton2.BackColor = System.Drawing.Color.Black;
            this.exitButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton2.Font = new System.Drawing.Font("Liberation Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton2.ForeColor = System.Drawing.Color.Red;
            this.exitButton2.Location = new System.Drawing.Point(86, 248);
            this.exitButton2.Name = "exitButton2";
            this.exitButton2.Size = new System.Drawing.Size(167, 69);
            this.exitButton2.TabIndex = 2;
            this.exitButton2.Text = "EXIT";
            this.exitButton2.UseVisualStyleBackColor = false;
            this.exitButton2.Click += new System.EventHandler(this.exitButton2_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.exitButton2);
            this.Controls.Add(this.playButton);
            this.Name = "Mainscreen";
            this.Size = new System.Drawing.Size(338, 339);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button exitButton2;
    }
}
