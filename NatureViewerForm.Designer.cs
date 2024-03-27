namespace DVCalc
{
    partial class NatureViewerForm
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
            natureGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)natureGridView).BeginInit();
            SuspendLayout();
            // 
            // natureGridView
            // 
            natureGridView.AllowUserToAddRows = false;
            natureGridView.AllowUserToDeleteRows = false;
            natureGridView.AllowUserToOrderColumns = true;
            natureGridView.AllowUserToResizeRows = false;
            natureGridView.BackgroundColor = SystemColors.Menu;
            natureGridView.BorderStyle = BorderStyle.None;
            natureGridView.ColumnHeadersHeight = 29;
            natureGridView.Location = new Point(16, 12);
            natureGridView.Name = "natureGridView";
            natureGridView.ReadOnly = true;
            natureGridView.RowHeadersWidth = 51;
            natureGridView.ScrollBars = ScrollBars.Vertical;
            natureGridView.Size = new Size(387, 416);
            natureGridView.TabIndex = 0;
            // 
            // NatureViewerForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 440);
            Controls.Add(natureGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NatureViewerForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Full List";
            ((System.ComponentModel.ISupportInitialize)natureGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView natureGridView;
    }
}