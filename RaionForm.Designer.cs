namespace ComertApp
{
    partial class RaionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaionForm));
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.txtArticol = new System.Windows.Forms.TextBox();
            this.txtStoc = new System.Windows.Forms.TextBox();
            this.ComboBoxMagazin = new System.Windows.Forms.ComboBox();
            this.listViewRaioane = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Label();
            this.textPretUnitar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddRaion = new System.Windows.Forms.ToolStripButton();
            this.btnModificaRaion = new System.Windows.Forms.ToolStripButton();
            this.btnStergeRaion = new System.Windows.Forms.ToolStripButton();
            this.btnDesfacere = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCategorie
            // 
            this.txtCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCategorie.Location = new System.Drawing.Point(12, 111);
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(124, 27);
            this.txtCategorie.TabIndex = 0;
            this.txtCategorie.Text = "Categorie";
            this.txtCategorie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategorie.TextChanged += new System.EventHandler(this.txtCategorie_TextChanged);
            // 
            // txtArticol
            // 
            this.txtArticol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticol.Location = new System.Drawing.Point(169, 111);
            this.txtArticol.Name = "txtArticol";
            this.txtArticol.Size = new System.Drawing.Size(182, 27);
            this.txtArticol.TabIndex = 1;
            this.txtArticol.Text = "Nume Produs";
            this.txtArticol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtArticol.TextChanged += new System.EventHandler(this.txtArticol_TextChanged);
            // 
            // txtStoc
            // 
            this.txtStoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoc.Location = new System.Drawing.Point(584, 111);
            this.txtStoc.Name = "txtStoc";
            this.txtStoc.Size = new System.Drawing.Size(100, 27);
            this.txtStoc.TabIndex = 3;
            this.txtStoc.Text = "Stoc";
            this.txtStoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStoc.TextChanged += new System.EventHandler(this.txtStoc_TextChanged);
            // 
            // ComboBoxMagazin
            // 
            this.ComboBoxMagazin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ComboBoxMagazin.FormattingEnabled = true;
            this.ComboBoxMagazin.Location = new System.Drawing.Point(190, 29);
            this.ComboBoxMagazin.Name = "ComboBoxMagazin";
            this.ComboBoxMagazin.Size = new System.Drawing.Size(191, 26);
            this.ComboBoxMagazin.TabIndex = 9;
            this.ComboBoxMagazin.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMagazin_SelectedIndexChanged);
            // 
            // listViewRaioane
            // 
            this.listViewRaioane.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listViewRaioane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewRaioane.HideSelection = false;
            this.listViewRaioane.Location = new System.Drawing.Point(0, 289);
            this.listViewRaioane.Name = "listViewRaioane";
            this.listViewRaioane.Size = new System.Drawing.Size(1000, 217);
            this.listViewRaioane.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewRaioane.TabIndex = 7;
            this.listViewRaioane.UseCompatibleStateImageBehavior = false;
            this.listViewRaioane.SelectedIndexChanged += new System.EventHandler(this.listViewRaioane_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(35, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 48);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(169, 182);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 48);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(300, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.select.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.select.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select.Location = new System.Drawing.Point(23, 35);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(138, 20);
            this.select.TabIndex = 8;
            this.select.Text = "Selectie Magazin";
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // textPretUnitar
            // 
            this.textPretUnitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPretUnitar.Location = new System.Drawing.Point(397, 111);
            this.textPretUnitar.Name = "textPretUnitar";
            this.textPretUnitar.Size = new System.Drawing.Size(135, 27);
            this.textPretUnitar.TabIndex = 2;
            this.textPretUnitar.Text = "Pret Unitar";
            this.textPretUnitar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPretUnitar.TextChanged += new System.EventHandler(this.textPretUnitar_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRaion,
            this.btnModificaRaion,
            this.btnStergeRaion,
            this.btnDesfacere,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(960, 0);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(40, 289);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddRaion
            // 
            this.btnAddRaion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRaion.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRaion.Image = ((System.Drawing.Image)(resources.GetObject("btnAddRaion.Image")));
            this.btnAddRaion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRaion.Margin = new System.Windows.Forms.Padding(3);
            this.btnAddRaion.Name = "btnAddRaion";
            this.btnAddRaion.Size = new System.Drawing.Size(31, 24);
            this.btnAddRaion.Text = "Add Raion";
            this.btnAddRaion.Click += new System.EventHandler(this.btnAddRaion_Click);
            // 
            // btnModificaRaion
            // 
            this.btnModificaRaion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificaRaion.Image = ((System.Drawing.Image)(resources.GetObject("btnModificaRaion.Image")));
            this.btnModificaRaion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificaRaion.Margin = new System.Windows.Forms.Padding(3);
            this.btnModificaRaion.Name = "btnModificaRaion";
            this.btnModificaRaion.Size = new System.Drawing.Size(31, 24);
            this.btnModificaRaion.Text = "Modifica Raion";
            this.btnModificaRaion.Click += new System.EventHandler(this.btnModificaRaion_Click);
            // 
            // btnStergeRaion
            // 
            this.btnStergeRaion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStergeRaion.Image = ((System.Drawing.Image)(resources.GetObject("btnStergeRaion.Image")));
            this.btnStergeRaion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStergeRaion.Margin = new System.Windows.Forms.Padding(3);
            this.btnStergeRaion.Name = "btnStergeRaion";
            this.btnStergeRaion.Size = new System.Drawing.Size(31, 24);
            this.btnStergeRaion.Text = "Delete Raion";
            this.btnStergeRaion.Click += new System.EventHandler(this.btnStergeRaion_Click);
            // 
            // btnDesfacere
            // 
            this.btnDesfacere.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDesfacere.Image = ((System.Drawing.Image)(resources.GetObject("btnDesfacere.Image")));
            this.btnDesfacere.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDesfacere.Margin = new System.Windows.Forms.Padding(3);
            this.btnDesfacere.Name = "btnDesfacere";
            this.btnDesfacere.Size = new System.Drawing.Size(31, 24);
            this.btnDesfacere.Text = "Desfacere";
            this.btnDesfacere.Click += new System.EventHandler(this.btnDesfacere_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripButton1.Text = "Inchide";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // RaionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.textPretUnitar);
            this.Controls.Add(this.select);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listViewRaioane);
            this.Controls.Add(this.ComboBoxMagazin);
            this.Controls.Add(this.txtStoc);
            this.Controls.Add(this.txtArticol);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "RaionForm";
            this.Text = "RaionForm";
            this.Load += new System.EventHandler(this.RaionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.TextBox txtArticol;
        private System.Windows.Forms.TextBox txtStoc;
        private System.Windows.Forms.ComboBox ComboBoxMagazin;
        private System.Windows.Forms.ListView listViewRaioane;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label select;
        private System.Windows.Forms.TextBox textPretUnitar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddRaion;
        private System.Windows.Forms.ToolStripButton btnModificaRaion;
        private System.Windows.Forms.ToolStripButton btnStergeRaion;
        private System.Windows.Forms.ToolStripButton btnDesfacere;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}