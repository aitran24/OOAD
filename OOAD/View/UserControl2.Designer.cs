namespace OOAD.View
{
    partial class UserControl2
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
            this.labeldays = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labeldays
            // 
            this.labeldays.AutoSize = true;
            this.labeldays.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldays.Location = new System.Drawing.Point(53, 0);
            this.labeldays.Name = "labeldays";
            this.labeldays.Size = new System.Drawing.Size(24, 17);
            this.labeldays.TabIndex = 0;
            this.labeldays.Text = "00";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(14, 29);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(57, 13);
            this.labelEvent.TabIndex = 1;
            this.labelEvent.Text = "labelEvent";
            this.labelEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEvent.Click += new System.EventHandler(this.labelEvent_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.labeldays);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(80, 55);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.Click += new System.EventHandler(this.UserControl2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeldays;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Timer timer1;
    }
}
