namespace goznak_test_task {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uploadButton = new System.Windows.Forms.Button();
            this.verticalSplitter = new System.Windows.Forms.SplitContainer();
            this.leftContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.dataGridCity = new System.Windows.Forms.DataGridView();
            this.rightContainer = new System.Windows.Forms.SplitContainer();
            this.dataGridProfession = new System.Windows.Forms.DataGridView();
            this.dataGridOrganization = new System.Windows.Forms.DataGridView();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitter)).BeginInit();
            this.verticalSplitter.Panel1.SuspendLayout();
            this.verticalSplitter.Panel2.SuspendLayout();
            this.verticalSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).BeginInit();
            this.leftContainer.Panel1.SuspendLayout();
            this.leftContainer.Panel2.SuspendLayout();
            this.leftContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightContainer)).BeginInit();
            this.rightContainer.Panel1.SuspendLayout();
            this.rightContainer.Panel2.SuspendLayout();
            this.rightContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrganization)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSize = true;
            this.mainLayoutPanel.ColumnCount = 2;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.uploadButton, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.verticalSplitter, 1, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 1;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(700, 338);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // uploadButton
            // 
            this.uploadButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uploadButton.Location = new System.Drawing.Point(18, 30);
            this.uploadButton.Margin = new System.Windows.Forms.Padding(18, 30, 18, 2);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(118, 43);
            this.uploadButton.TabIndex = 0;
            this.uploadButton.Text = "Выгрузить данные";
            this.uploadButton.UseVisualStyleBackColor = true;
            // 
            // verticalSplitter
            // 
            this.verticalSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitter.Location = new System.Drawing.Point(157, 2);
            this.verticalSplitter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verticalSplitter.Name = "verticalSplitter";
            // 
            // verticalSplitter.Panel1
            // 
            this.verticalSplitter.Panel1.Controls.Add(this.leftContainer);
            // 
            // verticalSplitter.Panel2
            // 
            this.verticalSplitter.Panel2.Controls.Add(this.rightContainer);
            this.verticalSplitter.Size = new System.Drawing.Size(540, 334);
            this.verticalSplitter.SplitterDistance = 267;
            this.verticalSplitter.TabIndex = 1;
            // 
            // leftContainer
            // 
            this.leftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftContainer.Location = new System.Drawing.Point(0, 0);
            this.leftContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leftContainer.Name = "leftContainer";
            this.leftContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // leftContainer.Panel1
            // 
            this.leftContainer.Panel1.Controls.Add(this.dataGridUser);
            // 
            // leftContainer.Panel2
            // 
            this.leftContainer.Panel2.Controls.Add(this.dataGridCity);
            this.leftContainer.Size = new System.Drawing.Size(267, 334);
            this.leftContainer.SplitterDistance = 165;
            this.leftContainer.SplitterWidth = 3;
            this.leftContainer.TabIndex = 0;
            // 
            // dataGridUser
            // 
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridUser.Location = new System.Drawing.Point(0, 0);
            this.dataGridUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.RowHeadersWidth = 51;
            this.dataGridUser.RowTemplate.Height = 29;
            this.dataGridUser.Size = new System.Drawing.Size(267, 165);
            this.dataGridUser.TabIndex = 0;
            // 
            // dataGridCity
            // 
            this.dataGridCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCity.Location = new System.Drawing.Point(0, 0);
            this.dataGridCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridCity.Name = "dataGridCity";
            this.dataGridCity.RowHeadersWidth = 51;
            this.dataGridCity.RowTemplate.Height = 29;
            this.dataGridCity.Size = new System.Drawing.Size(267, 166);
            this.dataGridCity.TabIndex = 0;
            // 
            // rightContainer
            // 
            this.rightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightContainer.Location = new System.Drawing.Point(0, 0);
            this.rightContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rightContainer.Name = "rightContainer";
            this.rightContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // rightContainer.Panel1
            // 
            this.rightContainer.Panel1.Controls.Add(this.dataGridProfession);
            // 
            // rightContainer.Panel2
            // 
            this.rightContainer.Panel2.Controls.Add(this.dataGridOrganization);
            this.rightContainer.Size = new System.Drawing.Size(269, 334);
            this.rightContainer.SplitterDistance = 165;
            this.rightContainer.SplitterWidth = 3;
            this.rightContainer.TabIndex = 0;
            // 
            // dataGridProfession
            // 
            this.dataGridProfession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfession.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProfession.Location = new System.Drawing.Point(0, 0);
            this.dataGridProfession.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridProfession.Name = "dataGridProfession";
            this.dataGridProfession.RowHeadersWidth = 51;
            this.dataGridProfession.RowTemplate.Height = 29;
            this.dataGridProfession.Size = new System.Drawing.Size(269, 165);
            this.dataGridProfession.TabIndex = 0;
            // 
            // dataGridOrganization
            // 
            this.dataGridOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrganization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridOrganization.Location = new System.Drawing.Point(0, 0);
            this.dataGridOrganization.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridOrganization.Name = "dataGridOrganization";
            this.dataGridOrganization.RowHeadersWidth = 51;
            this.dataGridOrganization.RowTemplate.Height = 29;
            this.dataGridOrganization.Size = new System.Drawing.Size(269, 166);
            this.dataGridOrganization.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.mainLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "ГОЗНАК";
            this.mainLayoutPanel.ResumeLayout(false);
            this.verticalSplitter.Panel1.ResumeLayout(false);
            this.verticalSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitter)).EndInit();
            this.verticalSplitter.ResumeLayout(false);
            this.leftContainer.Panel1.ResumeLayout(false);
            this.leftContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.leftContainer)).EndInit();
            this.leftContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCity)).EndInit();
            this.rightContainer.Panel1.ResumeLayout(false);
            this.rightContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rightContainer)).EndInit();
            this.rightContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrganization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel mainLayoutPanel;
        private Button uploadButton;
        private SplitContainer verticalSplitter;
        private SplitContainer leftContainer;
        private DataGridView dataGridUser;
        private DataGridView dataGridCity;
        private SplitContainer rightContainer;
        private DataGridView dataGridProfession;
        private DataGridView dataGridOrganization;
    }
}