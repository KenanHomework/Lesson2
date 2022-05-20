namespace WinFormsApp1
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.btn_task1 = new System.Windows.Forms.Button();
            this.btn_task2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_task1
            // 
            this.btn_task1.BackColor = System.Drawing.Color.Transparent;
            this.btn_task1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_task1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_task1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_task1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.btn_task1, "btn_task1");
            this.btn_task1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_task1.Name = "btn_task1";
            this.btn_task1.UseVisualStyleBackColor = false;
            this.btn_task1.Click += new System.EventHandler(this.btn_task1_Click);
            // 
            // btn_task2
            // 
            this.btn_task2.BackColor = System.Drawing.Color.Transparent;
            this.btn_task2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_task2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_task2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_task2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.btn_task2, "btn_task2");
            this.btn_task2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_task2.Name = "btn_task2";
            this.btn_task2.UseVisualStyleBackColor = false;
            this.btn_task2.Click += new System.EventHandler(this.btn_task2_Click);
            // 
            // Start
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormsApp1.Properties.Resources.Starter_Backround;
            this.Controls.Add(this.btn_task2);
            this.Controls.Add(this.btn_task1);
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_task1;
        private Button btn_task2;
    }
}