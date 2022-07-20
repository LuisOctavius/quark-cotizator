namespace qk_cotiztr.Views
{
    partial class ViewCotizationHistory
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
            this.dataGridView_CotizationHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CotizationHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CotizationHistory
            // 
            this.dataGridView_CotizationHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CotizationHistory.Location = new System.Drawing.Point(13, 13);
            this.dataGridView_CotizationHistory.Name = "dataGridView_CotizationHistory";
            this.dataGridView_CotizationHistory.Size = new System.Drawing.Size(630, 280);
            this.dataGridView_CotizationHistory.TabIndex = 0;
            // 
            // ViewCotizationHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 305);
            this.Controls.Add(this.dataGridView_CotizationHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewCotizationHistory";
            this.Text = "Historial de Cotizaciones";
            this.Load += new System.EventHandler(this.ViewCotizationHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CotizationHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_CotizationHistory;
    }
}