namespace NtofosApplication
{
    partial class frmVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideo));
            axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axWMP).BeginInit();
            SuspendLayout();
            // 
            // axWMP
            // 
            axWMP.Dock = DockStyle.Fill;
            axWMP.Enabled = true;
            axWMP.Location = new Point(0, 0);
            axWMP.Name = "axWMP";
            axWMP.OcxState = (AxHost.State)resources.GetObject("axWMP.OcxState");
            axWMP.Size = new Size(800, 450);
            axWMP.TabIndex = 0;
            // 
            // frmVideo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(axWMP);
            Name = "frmVideo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVideo";
            WindowState = FormWindowState.Maximized;
            Load += frmVideo_Load;
            ((System.ComponentModel.ISupportInitialize)axWMP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWMP;
    }
}