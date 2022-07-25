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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FeedsDataGridView = new System.Windows.Forms.DataGridView();
            this.DeleteFeedButton = new System.Windows.Forms.Button();
            this.NewFeedButton = new System.Windows.Forms.Button();
            this.EditFeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FeedsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FeedsDataGridView
            // 
            this.FeedsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeedsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.FeedsDataGridView.MultiSelect = false;
            this.FeedsDataGridView.Name = "FeedsDataGridView";
            this.FeedsDataGridView.ReadOnly = true;
            this.FeedsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FeedsDataGridView.Size = new System.Drawing.Size(616, 338);
            this.FeedsDataGridView.TabIndex = 0;
            this.FeedsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedsDataGridView_CellContentClick);
            // 
            // DeleteFeedButton
            // 
            this.DeleteFeedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteFeedButton.Image = global::FeedTheCat.Properties.Resources.vcsconflicting_93497__1_;
            this.DeleteFeedButton.Location = new System.Drawing.Point(523, 356);
            this.DeleteFeedButton.Name = "DeleteFeedButton";
            this.DeleteFeedButton.Size = new System.Drawing.Size(105, 44);
            this.DeleteFeedButton.TabIndex = 2;
            this.DeleteFeedButton.Text = "Delete Feed";
            this.DeleteFeedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteFeedButton.UseVisualStyleBackColor = true;
            this.DeleteFeedButton.Click += new System.EventHandler(this.DeleteFeedButton_Click);
            // 
            // NewFeedButton
            // 
            this.NewFeedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFeedButton.Image = global::FeedTheCat.Properties.Resources.flat_style_circle_add_icon_icons_com_66944__1_;
            this.NewFeedButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewFeedButton.Location = new System.Drawing.Point(301, 356);
            this.NewFeedButton.Name = "NewFeedButton";
            this.NewFeedButton.Size = new System.Drawing.Size(105, 44);
            this.NewFeedButton.TabIndex = 0;
            this.NewFeedButton.Text = "Add Feed";
            this.NewFeedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NewFeedButton.UseVisualStyleBackColor = true;
            this.NewFeedButton.Click += new System.EventHandler(this.NewFeedButton_Click);
            // 
            // EditFeedButton
            // 
            this.EditFeedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EditFeedButton.Image = global::FeedTheCat.Properties.Resources._3592869_compose_create_edit_edit_file_office_pencil_writing_creative_107746__1_;
            this.EditFeedButton.Location = new System.Drawing.Point(412, 356);
            this.EditFeedButton.Name = "EditFeedButton";
            this.EditFeedButton.Size = new System.Drawing.Size(105, 44);
            this.EditFeedButton.TabIndex = 1;
            this.EditFeedButton.Text = "Edit Feed";
            this.EditFeedButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditFeedButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EditFeedButton.UseVisualStyleBackColor = true;
            this.EditFeedButton.Click += new System.EventHandler(this.EditFeedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 411);
            this.Controls.Add(this.DeleteFeedButton);
            this.Controls.Add(this.FeedsDataGridView);
            this.Controls.Add(this.NewFeedButton);
            this.Controls.Add(this.EditFeedButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FeedTheCat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FeedsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button NewFeedButton;
        private System.Windows.Forms.Button DeleteFeedButton;
        private System.Windows.Forms.Button EditFeedButton;
        private System.Windows.Forms.DataGridView FeedsDataGridView;
    }
}

