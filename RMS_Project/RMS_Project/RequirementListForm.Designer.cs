namespace RMS_Project
{
    partial class RequirementListForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userButton = new RMS_Project.NoFocusCueButton();
            this.listView2 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AutoArrange = false;
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(0);
            this.listView1.Name = "listView1";
            this.tableLayoutPanel1.SetRowSpan(this.listView1, 2);
            this.listView1.Size = new System.Drawing.Size(279, 363);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.ClientSizeChanged += new System.EventHandler(this.listView1_ClientSizeChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.userButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(519, 363);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // userButton
            // 
            this.userButton.AutoSize = true;
            this.userButton.BackColor = System.Drawing.SystemColors.Menu;
            this.userButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.userButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userButton.Image = global::RMS_Project.Properties.Resources.person_add;
            this.userButton.Location = new System.Drawing.Point(279, 303);
            this.userButton.Margin = new System.Windows.Forms.Padding(0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(240, 60);
            this.userButton.TabIndex = 7;
            this.userButton.TabStop = false;
            this.userButton.Text = "Add  new member";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            this.listView2.AutoArrange = false;
            this.listView2.BackColor = System.Drawing.SystemColors.Menu;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(279, 0);
            this.listView2.Margin = new System.Windows.Forms.Padding(0);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(240, 303);
            this.listView2.TabIndex = 8;
            this.listView2.TileSize = new System.Drawing.Size(188, 50);
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Tile;
            this.listView2.ClientSizeChanged += new System.EventHandler(this.listView2_ClientSizeChanged);
            // 
            // RequirementListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 363);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RequirementListForm";
            this.Text = "RequirementListForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private NoFocusCueButton userButton;
        private System.Windows.Forms.ListView listView2;

    }
}