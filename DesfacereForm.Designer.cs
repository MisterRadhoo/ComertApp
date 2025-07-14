namespace ComertApp
{
    partial class DesfacereForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesfacereForm));
            this.cmbMagazin = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cmbRaion = new System.Windows.Forms.ComboBox();
            this.selectMag = new System.Windows.Forms.Label();
            this.selectRaion = new System.Windows.Forms.Label();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtPretTotal = new System.Windows.Forms.TextBox();
            this.btnAdaugaInCos = new System.Windows.Forms.Button();
            this.ListBoxCos = new System.Windows.Forms.ListBox();
            this.btnTranzactie = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGraphic = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cmbMagazin
            // 
            this.cmbMagazin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMagazin.FormattingEnabled = true;
            this.cmbMagazin.Location = new System.Drawing.Point(194, 49);
            this.cmbMagazin.Name = "cmbMagazin";
            this.cmbMagazin.Size = new System.Drawing.Size(203, 28);
            this.cmbMagazin.TabIndex = 0;
            this.cmbMagazin.SelectedIndexChanged += new System.EventHandler(this.cmbMagazin_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // cmbRaion
            // 
            this.cmbRaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRaion.FormattingEnabled = true;
            this.cmbRaion.Location = new System.Drawing.Point(581, 49);
            this.cmbRaion.Name = "cmbRaion";
            this.cmbRaion.Size = new System.Drawing.Size(387, 28);
            this.cmbRaion.TabIndex = 1;
            this.cmbRaion.SelectedIndexChanged += new System.EventHandler(this.cmbRaion_SelectedIndexChanged);
            // 
            // selectMag
            // 
            this.selectMag.AutoSize = true;
            this.selectMag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectMag.Location = new System.Drawing.Point(10, 52);
            this.selectMag.Name = "selectMag";
            this.selectMag.Size = new System.Drawing.Size(178, 20);
            this.selectMag.TabIndex = 2;
            this.selectMag.Text = "Selecteaza Magazin";
            this.selectMag.Click += new System.EventHandler(this.selectMag_Click);
            // 
            // selectRaion
            // 
            this.selectRaion.AutoSize = true;
            this.selectRaion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRaion.Location = new System.Drawing.Point(419, 52);
            this.selectRaion.Name = "selectRaion";
            this.selectRaion.Size = new System.Drawing.Size(156, 20);
            this.selectRaion.TabIndex = 3;
            this.selectRaion.Text = "Selecteaza Raion";
            this.selectRaion.Click += new System.EventHandler(this.selectRaion_Click);
            // 
            // txtCantitate
            // 
            this.txtCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantitate.Location = new System.Drawing.Point(50, 143);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(109, 27);
            this.txtCantitate.TabIndex = 4;
            this.txtCantitate.Text = "Cantitate";
            this.txtCantitate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantitate.TextChanged += new System.EventHandler(this.txtCantitate_TextChanged);
            // 
            // txtPretTotal
            // 
            this.txtPretTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPretTotal.Location = new System.Drawing.Point(50, 224);
            this.txtPretTotal.Name = "txtPretTotal";
            this.txtPretTotal.ReadOnly = true;
            this.txtPretTotal.Size = new System.Drawing.Size(138, 27);
            this.txtPretTotal.TabIndex = 5;
            this.txtPretTotal.Text = "Pret Total";
            this.txtPretTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPretTotal.TextChanged += new System.EventHandler(this.txtPretTotal_TextChanged);
            // 
            // btnAdaugaInCos
            // 
            this.btnAdaugaInCos.BackColor = System.Drawing.Color.SlateBlue;
            this.btnAdaugaInCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaInCos.Location = new System.Drawing.Point(50, 301);
            this.btnAdaugaInCos.Name = "btnAdaugaInCos";
            this.btnAdaugaInCos.Size = new System.Drawing.Size(163, 58);
            this.btnAdaugaInCos.TabIndex = 6;
            this.btnAdaugaInCos.Text = "Adauga In Cos";
            this.btnAdaugaInCos.UseVisualStyleBackColor = false;
            this.btnAdaugaInCos.Click += new System.EventHandler(this.btnAdaugaInCos_Click);
            // 
            // ListBoxCos
            // 
            this.ListBoxCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxCos.FormattingEnabled = true;
            this.ListBoxCos.ItemHeight = 20;
            this.ListBoxCos.Location = new System.Drawing.Point(440, 123);
            this.ListBoxCos.Name = "ListBoxCos";
            this.ListBoxCos.Size = new System.Drawing.Size(528, 204);
            this.ListBoxCos.TabIndex = 7;
            this.ListBoxCos.SelectedIndexChanged += new System.EventHandler(this.ListBoxCos_SelectedIndexChanged);
            this.ListBoxCos.ContextMenuStripChanged += new System.EventHandler(this.ListBoxCos_SelectedIndexChanged);
            this.ListBoxCos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBoxMouseMove);
            // 
            // btnTranzactie
            // 
            this.btnTranzactie.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTranzactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranzactie.Location = new System.Drawing.Point(726, 333);
            this.btnTranzactie.Name = "btnTranzactie";
            this.btnTranzactie.Size = new System.Drawing.Size(186, 55);
            this.btnTranzactie.TabIndex = 8;
            this.btnTranzactie.Text = "Tranzactie";
            this.btnTranzactie.UseVisualStyleBackColor = false;
            this.btnTranzactie.Click += new System.EventHandler(this.btnTranzactie_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(483, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 54);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sterge";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGraphic
            // 
            this.btnGraphic.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGraphic.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnGraphic.Location = new System.Drawing.Point(646, 430);
            this.btnGraphic.Name = "btnGraphic";
            this.btnGraphic.Size = new System.Drawing.Size(157, 42);
            this.btnGraphic.TabIndex = 10;
            this.btnGraphic.Text = "Top 5 Vanzari";
            this.btnGraphic.UseVisualStyleBackColor = false;
            this.btnGraphic.Click += new System.EventHandler(this.btnGraphic_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBackMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.BackgroundImage")));
            this.btnBackMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnBackMenu.Location = new System.Drawing.Point(50, 427);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(129, 48);
            this.btnBackMenu.TabIndex = 11;
            this.btnBackMenu.Text = "X";
            this.btnBackMenu.UseVisualStyleBackColor = false;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // DesfacereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 506);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.btnGraphic);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTranzactie);
            this.Controls.Add(this.ListBoxCos);
            this.Controls.Add(this.btnAdaugaInCos);
            this.Controls.Add(this.txtPretTotal);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.selectRaion);
            this.Controls.Add(this.selectMag);
            this.Controls.Add(this.cmbRaion);
            this.Controls.Add(this.cmbMagazin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DesfacereForm";
            this.Text = "DesfacereForm";
            this.Load += new System.EventHandler(this.DesfacereForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMagazin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbRaion;
        private System.Windows.Forms.Label selectMag;
        private System.Windows.Forms.Label selectRaion;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtPretTotal;
        private System.Windows.Forms.Button btnAdaugaInCos;
        private System.Windows.Forms.ListBox ListBoxCos;
        private System.Windows.Forms.Button btnTranzactie;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGraphic;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}