namespace celeste
{
    partial class gameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameEngine
            // 
            this.gameEngine.Enabled = true;
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(391, 60);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(206, 40);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "score";
            // 
            // gameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.scoreLabel);
            this.DoubleBuffered = true;
            this.Name = "gameScreen";
            this.Size = new System.Drawing.Size(600, 600);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.gameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.gameScreen_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Label scoreLabel;
    }
}
