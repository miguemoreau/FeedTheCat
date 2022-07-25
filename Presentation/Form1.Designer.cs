namespace FeedTheCat.Presentation
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DeleteFeedButton = new System.Windows.Forms.Button();
            this.EditFeedButton = new System.Windows.Forms.Button();
            this.NewFeedButton = new System.Windows.Forms.Button();
            this.FeedsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeedsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DeleteFeedButton);
            this.splitContainer1.Panel1.Controls.Add(this.EditFeedButton);
            this.splitContainer1.Panel1.Controls.Add(this.NewFeedButton);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.FeedsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(726, 398);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 0;
            // 
            // DeleteFeedButton
            // 
            this.DeleteFeedButton.Location = new System.Drawing.Point(28, 180);
            this.DeleteFeedButton.Name = "DeleteFeedButton";
            this.DeleteFeedButton.Size = new System.Drawing.Size(204, 31);
            this.DeleteFeedButton.TabIndex = 2;
            this.DeleteFeedButton.Text = "Delete";
            this.DeleteFeedButton.UseVisualStyleBackColor = true;
            this.DeleteFeedButton.Click += new System.EventHandler(this.DeleteFeedButton_Click);
            // 
            // EditFeedButton
            // 
            this.EditFeedButton.Location = new System.Drawing.Point(28, 85);
            this.EditFeedButton.Name = "EditFeedButton";
            this.EditFeedButton.Size = new System.Drawing.Size(204, 31);
            this.EditFeedButton.TabIndex = 1;
            this.EditFeedButton.Text = "Edit";
            this.EditFeedButton.UseVisualStyleBackColor = true;
            this.EditFeedButton.Click += new System.EventHandler(this.EditFeedButton_Click);
            // 
            // NewFeedButton
            // 
            this.NewFeedButton.Location = new System.Drawing.Point(28, 28);
            this.NewFeedButton.Name = "NewFeedButton";
            this.NewFeedButton.Size = new System.Drawing.Size(204, 31);
            this.NewFeedButton.TabIndex = 0;
            this.NewFeedButton.Text = "New Feed";
            this.NewFeedButton.UseVisualStyleBackColor = true;
            this.NewFeedButton.Click += new System.EventHandler(this.NewFeedButton_Click);
            // 
            // FeedsDataGridView
            // 
            this.FeedsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FeedsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.FeedsDataGridView.MultiSelect = false;
            this.FeedsDataGridView.Name = "FeedsDataGridView";
            this.FeedsDataGridView.ReadOnly = true;
            this.FeedsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeedsDataGridView.Size = new System.Drawing.Size(444, 398);
            this.FeedsDataGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 398);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeedsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView FeedsDataGridView;
        private System.Windows.Forms.Button NewFeedButton;
        private System.Windows.Forms.Button DeleteFeedButton;
        private System.Windows.Forms.Button EditFeedButton;
    }
}

