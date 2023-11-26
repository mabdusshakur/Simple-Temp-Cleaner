namespace Simple_Temp_Cleaner
{
    partial class Main
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
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.clear_temp_btn = new Siticone.UI.WinForms.SiticoneButton();
            this.clear_prefetch_btn = new Siticone.UI.WinForms.SiticoneButton();
            this.SuspendLayout();
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(142, 3);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 0;
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(91, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 1;
            // 
            // clear_temp_btn
            // 
            this.clear_temp_btn.CheckedState.Parent = this.clear_temp_btn;
            this.clear_temp_btn.CustomImages.Parent = this.clear_temp_btn;
            this.clear_temp_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clear_temp_btn.ForeColor = System.Drawing.Color.White;
            this.clear_temp_btn.HoveredState.Parent = this.clear_temp_btn;
            this.clear_temp_btn.Location = new System.Drawing.Point(13, 58);
            this.clear_temp_btn.Name = "clear_temp_btn";
            this.clear_temp_btn.ShadowDecoration.Parent = this.clear_temp_btn;
            this.clear_temp_btn.Size = new System.Drawing.Size(163, 45);
            this.clear_temp_btn.TabIndex = 2;
            this.clear_temp_btn.Text = "Clear Temp";
            this.clear_temp_btn.Click += new System.EventHandler(this.clear_temp_btn_Click);
            // 
            // clear_prefetch_btn
            // 
            this.clear_prefetch_btn.CheckedState.Parent = this.clear_prefetch_btn;
            this.clear_prefetch_btn.CustomImages.Parent = this.clear_prefetch_btn;
            this.clear_prefetch_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clear_prefetch_btn.ForeColor = System.Drawing.Color.White;
            this.clear_prefetch_btn.HoveredState.Parent = this.clear_prefetch_btn;
            this.clear_prefetch_btn.Location = new System.Drawing.Point(12, 109);
            this.clear_prefetch_btn.Name = "clear_prefetch_btn";
            this.clear_prefetch_btn.ShadowDecoration.Parent = this.clear_prefetch_btn;
            this.clear_prefetch_btn.Size = new System.Drawing.Size(163, 45);
            this.clear_prefetch_btn.TabIndex = 3;
            this.clear_prefetch_btn.Text = "Clear Prefetch";
            this.clear_prefetch_btn.Click += new System.EventHandler(this.clear_prefetch_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 184);
            this.Controls.Add(this.clear_prefetch_btn);
            this.Controls.Add(this.clear_temp_btn);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticoneControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneButton clear_temp_btn;
        private Siticone.UI.WinForms.SiticoneButton clear_prefetch_btn;
    }
}

