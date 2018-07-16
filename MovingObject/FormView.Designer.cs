namespace MovingObject
{
    partial class FormView
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
            this.TimerMoving = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerMoving
            // 
            this.TimerMoving.Enabled = true;
            this.TimerMoving.Tick += new System.EventHandler(this.TimerMoving_Tick);
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 385);
            this.Name = "FormView";
            this.Text = "Moving Object";
            this.Load += new System.EventHandler(this.FormView_Load);
            this.RightToLeftChanged += new System.EventHandler(this.FormView_RightToLeftChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormView_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormView_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerMoving;
    }
}

