namespace RMS_Project
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this._mainFormPanel = new System.Windows.Forms.Panel();
            this._navigationPanel = new System.Windows.Forms.Panel();
            this._defaultLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this._navigationPanel.SuspendLayout();
            this._defaultLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this._mainFormPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this._navigationPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // _mainFormPanel
            // 
            this._mainFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainFormPanel.Location = new System.Drawing.Point(0, 90);
            this._mainFormPanel.Margin = new System.Windows.Forms.Padding(0);
            this._mainFormPanel.Name = "_mainFormPanel";
            this._mainFormPanel.Size = new System.Drawing.Size(784, 471);
            this._mainFormPanel.TabIndex = 3;
            // 
            // _navigationPanel
            // 
            this._navigationPanel.Controls.Add(this._defaultLayoutPanel);
            this._navigationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._navigationPanel.Location = new System.Drawing.Point(0, 0);
            this._navigationPanel.Margin = new System.Windows.Forms.Padding(0);
            this._navigationPanel.Name = "_navigationPanel";
            this._navigationPanel.Size = new System.Drawing.Size(784, 90);
            this._navigationPanel.TabIndex = 4;
            // 
            // _defaultLayoutPanel
            // 
            this._defaultLayoutPanel.BackColor = System.Drawing.Color.White;
            this._defaultLayoutPanel.Controls.Add(this.pictureBox1);
            this._defaultLayoutPanel.Controls.Add(this.label1);
            this._defaultLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._defaultLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this._defaultLayoutPanel.Name = "_defaultLayoutPanel";
            this._defaultLayoutPanel.Size = new System.Drawing.Size(784, 90);
            this._defaultLayoutPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RMS_Project.Properties.Resources.ios7_cloud_outline;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 15, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AccessibleName = "MainForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this._navigationPanel.ResumeLayout(false);
            this._defaultLayoutPanel.ResumeLayout(false);
            this._defaultLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel _mainFormPanel;
        private System.Windows.Forms.Panel _navigationPanel;
        private System.Windows.Forms.FlowLayoutPanel _defaultLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;

    }
}