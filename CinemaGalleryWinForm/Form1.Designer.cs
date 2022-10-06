namespace CinemaGalleryWinForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutCinemaGalleryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitleOriginal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelRatingImbd = new System.Windows.Forms.Label();
            this.labelOwnRating = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.textBoxOriginalTitle = new System.Windows.Forms.TextBox();
            this.textBoxTranslateTitle = new System.Windows.Forms.TextBox();
            this.pictureBoxPelicula = new System.Windows.Forms.PictureBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.textBoxRatingImdb = new System.Windows.Forms.TextBox();
            this.textBoxOwnRating = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxComments = new System.Windows.Forms.TextBox();
            this.cbDirectores = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonMas = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPelicula)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.directorsToolStripMenuItem,
            this.actorsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            // 
            // directorsToolStripMenuItem
            // 
            this.directorsToolStripMenuItem.Name = "directorsToolStripMenuItem";
            this.directorsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.directorsToolStripMenuItem.Text = "Directors";
            // 
            // actorsToolStripMenuItem
            // 
            this.actorsToolStripMenuItem.Name = "actorsToolStripMenuItem";
            this.actorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.actorsToolStripMenuItem.Text = "Actors";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutCinemaGalleryToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutCinemaGalleryToolStripMenuItem
            // 
            this.aboutCinemaGalleryToolStripMenuItem.Name = "aboutCinemaGalleryToolStripMenuItem";
            this.aboutCinemaGalleryToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.aboutCinemaGalleryToolStripMenuItem.Text = "About CinemaGallery";
            // 
            // labelTitleOriginal
            // 
            this.labelTitleOriginal.AutoSize = true;
            this.labelTitleOriginal.Location = new System.Drawing.Point(213, 75);
            this.labelTitleOriginal.Name = "labelTitleOriginal";
            this.labelTitleOriginal.Size = new System.Drawing.Size(65, 13);
            this.labelTitleOriginal.TabIndex = 7;
            this.labelTitleOriginal.Text = "Original Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Translate Title";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(213, 150);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(44, 13);
            this.labelDirector.TabIndex = 9;
            this.labelDirector.Text = "Director";
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(213, 191);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(47, 13);
            this.labelDuration.TabIndex = 10;
            this.labelDuration.Text = "Duration";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(213, 233);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(29, 13);
            this.labelUrl.TabIndex = 11;
            this.labelUrl.Text = "URL";
            // 
            // labelRatingImbd
            // 
            this.labelRatingImbd.AutoSize = true;
            this.labelRatingImbd.Location = new System.Drawing.Point(480, 75);
            this.labelRatingImbd.Name = "labelRatingImbd";
            this.labelRatingImbd.Size = new System.Drawing.Size(68, 13);
            this.labelRatingImbd.TabIndex = 12;
            this.labelRatingImbd.Text = "Rating IMDB";
            // 
            // labelOwnRating
            // 
            this.labelOwnRating.AutoSize = true;
            this.labelOwnRating.Location = new System.Drawing.Point(480, 110);
            this.labelOwnRating.Name = "labelOwnRating";
            this.labelOwnRating.Size = new System.Drawing.Size(66, 13);
            this.labelOwnRating.TabIndex = 13;
            this.labelOwnRating.Text = "Own Rating ";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(482, 150);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Description";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(486, 316);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(56, 13);
            this.labelComment.TabIndex = 15;
            this.labelComment.Text = "Comments";
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.Location = new System.Drawing.Point(12, 57);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(161, 381);
            this.listBoxPeliculas.TabIndex = 16;
            this.listBoxPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxPeliculas_SelectedIndexChanged);
            // 
            // textBoxOriginalTitle
            // 
            this.textBoxOriginalTitle.Location = new System.Drawing.Point(298, 72);
            this.textBoxOriginalTitle.Name = "textBoxOriginalTitle";
            this.textBoxOriginalTitle.Size = new System.Drawing.Size(154, 20);
            this.textBoxOriginalTitle.TabIndex = 17;
            // 
            // textBoxTranslateTitle
            // 
            this.textBoxTranslateTitle.Location = new System.Drawing.Point(298, 107);
            this.textBoxTranslateTitle.Name = "textBoxTranslateTitle";
            this.textBoxTranslateTitle.Size = new System.Drawing.Size(154, 20);
            this.textBoxTranslateTitle.TabIndex = 18;
            // 
            // pictureBoxPelicula
            // 
            this.pictureBoxPelicula.Location = new System.Drawing.Point(216, 288);
            this.pictureBoxPelicula.Name = "pictureBoxPelicula";
            this.pictureBoxPelicula.Size = new System.Drawing.Size(163, 150);
            this.pictureBoxPelicula.TabIndex = 19;
            this.pictureBoxPelicula.TabStop = false;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(298, 188);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(154, 20);
            this.textBoxDuration.TabIndex = 21;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(298, 230);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(154, 20);
            this.textBoxUrl.TabIndex = 22;
            // 
            // textBoxRatingImdb
            // 
            this.textBoxRatingImdb.Location = new System.Drawing.Point(577, 72);
            this.textBoxRatingImdb.Name = "textBoxRatingImdb";
            this.textBoxRatingImdb.Size = new System.Drawing.Size(59, 20);
            this.textBoxRatingImdb.TabIndex = 23;
            // 
            // textBoxOwnRating
            // 
            this.textBoxOwnRating.Location = new System.Drawing.Point(577, 107);
            this.textBoxOwnRating.Name = "textBoxOwnRating";
            this.textBoxOwnRating.Size = new System.Drawing.Size(59, 20);
            this.textBoxOwnRating.TabIndex = 24;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(577, 150);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(196, 143);
            this.textBoxDescription.TabIndex = 25;
            // 
            // textBoxComments
            // 
            this.textBoxComments.Location = new System.Drawing.Point(577, 313);
            this.textBoxComments.Multiline = true;
            this.textBoxComments.Name = "textBoxComments";
            this.textBoxComments.Size = new System.Drawing.Size(196, 125);
            this.textBoxComments.TabIndex = 26;
            // 
            // cbDirectores
            // 
            this.cbDirectores.FormattingEnabled = true;
            this.cbDirectores.Location = new System.Drawing.Point(298, 147);
            this.cbDirectores.Name = "cbDirectores";
            this.cbDirectores.Size = new System.Drawing.Size(121, 21);
            this.cbDirectores.TabIndex = 27;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonMas,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 28;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonMas
            // 
            this.toolStripButtonMas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMas.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMas.Image")));
            this.toolStripButtonMas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMas.Name = "toolStripButtonMas";
            this.toolStripButtonMas.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMas.Text = "Add Film";
            this.toolStripButtonMas.Click += new System.EventHandler(this.toolStripButtonMas_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Delete Film";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Save Film";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cbDirectores);
            this.Controls.Add(this.textBoxComments);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxOwnRating);
            this.Controls.Add(this.textBoxRatingImdb);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.pictureBoxPelicula);
            this.Controls.Add(this.textBoxTranslateTitle);
            this.Controls.Add(this.textBoxOriginalTitle);
            this.Controls.Add(this.listBoxPeliculas);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelOwnRating);
            this.Controls.Add(this.labelRatingImbd);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitleOriginal);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CinemaGallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPelicula)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutCinemaGalleryToolStripMenuItem;
        private System.Windows.Forms.Label labelTitleOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelRatingImbd;
        private System.Windows.Forms.Label labelOwnRating;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.TextBox textBoxOriginalTitle;
        private System.Windows.Forms.TextBox textBoxTranslateTitle;
        private System.Windows.Forms.PictureBox pictureBoxPelicula;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.TextBox textBoxRatingImdb;
        private System.Windows.Forms.TextBox textBoxOwnRating;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxComments;
        private System.Windows.Forms.ComboBox cbDirectores;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonMas;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem directorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actorsToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

