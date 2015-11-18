namespace RMS_Project
{
    partial class TraceabilityMatrixForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.matrixDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixDataGridView
            // 
            this.matrixDataGridView.AllowUserToAddRows = false;
            this.matrixDataGridView.AllowUserToDeleteRows = false;
            this.matrixDataGridView.AllowUserToResizeColumns = false;
            this.matrixDataGridView.AllowUserToResizeRows = false;
            this.matrixDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matrixDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.matrixDataGridView.ColumnHeadersHeight = 25;
            this.matrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixDataGridView.EnableHeadersVisualStyles = false;
            this.matrixDataGridView.Location = new System.Drawing.Point(0, 0);
            this.matrixDataGridView.Name = "matrixDataGridView";
            this.matrixDataGridView.ReadOnly = true;
            this.matrixDataGridView.RowHeadersVisible = false;
            this.matrixDataGridView.RowTemplate.Height = 24;
            this.matrixDataGridView.Size = new System.Drawing.Size(469, 279);
            this.matrixDataGridView.TabIndex = 0;
            // 
            // TraceabilityMatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 279);
            this.Controls.Add(this.matrixDataGridView);
            this.Name = "TraceabilityMatrixForm";
            this.Text = "TraceabilityMatrixForm";
            ((System.ComponentModel.ISupportInitialize)(this.matrixDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrixDataGridView;
    }
}