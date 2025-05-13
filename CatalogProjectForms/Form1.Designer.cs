namespace CatalogProjectFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            printAllMoviesList = new ListBox();
            showAllMovies = new Button();
            tabPage2 = new TabPage();
            addMovie = new Button();
            ratingComboBox = new ComboBox();
            label6 = new Label();
            reviewRichTextBox = new RichTextBox();
            descriptionRichTextBox = new RichTextBox();
            label5 = new Label();
            label4 = new Label();
            genreComboBox = new ComboBox();
            label3 = new Label();
            directorComboBox = new ComboBox();
            label2 = new Label();
            titleBox = new TextBox();
            label1 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Script MT Bold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1003, 635);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(printAllMoviesList);
            tabPage1.Controls.Add(showAllMovies);
            tabPage1.Location = new Point(4, 49);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(995, 582);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Movies";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(245, 188, 201);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(620, 237);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 237);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // printAllMoviesList
            // 
            printAllMoviesList.FormattingEnabled = true;
            printAllMoviesList.ItemHeight = 37;
            printAllMoviesList.Location = new Point(28, 32);
            printAllMoviesList.Name = "printAllMoviesList";
            printAllMoviesList.Size = new Size(562, 522);
            printAllMoviesList.TabIndex = 1;
            // 
            // showAllMovies
            // 
            showAllMovies.BackgroundImage = (Image)resources.GetObject("showAllMovies.BackgroundImage");
            showAllMovies.BackgroundImageLayout = ImageLayout.Stretch;
            showAllMovies.Location = new Point(620, 480);
            showAllMovies.Name = "showAllMovies";
            showAllMovies.Size = new Size(340, 74);
            showAllMovies.TabIndex = 0;
            showAllMovies.Text = "Show all";
            showAllMovies.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.BackgroundImage = (Image)resources.GetObject("tabPage2.BackgroundImage");
            tabPage2.BorderStyle = BorderStyle.Fixed3D;
            tabPage2.Controls.Add(addMovie);
            tabPage2.Controls.Add(ratingComboBox);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(reviewRichTextBox);
            tabPage2.Controls.Add(descriptionRichTextBox);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(genreComboBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(directorComboBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(titleBox);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 49);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(995, 582);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Add";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // addMovie
            // 
            addMovie.BackgroundImage = (Image)resources.GetObject("addMovie.BackgroundImage");
            addMovie.Location = new Point(795, 32);
            addMovie.Name = "addMovie";
            addMovie.Size = new Size(154, 486);
            addMovie.TabIndex = 12;
            addMovie.Text = "Add Movie";
            addMovie.UseCompatibleTextRendering = true;
            addMovie.UseVisualStyleBackColor = true;
            // 
            // ratingComboBox
            // 
            ratingComboBox.FormattingEnabled = true;
            ratingComboBox.Location = new Point(166, 476);
            ratingComboBox.Name = "ratingComboBox";
            ratingComboBox.Size = new Size(561, 45);
            ratingComboBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(36, 479);
            label6.Name = "label6";
            label6.Size = new Size(108, 37);
            label6.TabIndex = 10;
            label6.Text = "Rating:";
            // 
            // reviewRichTextBox
            // 
            reviewRichTextBox.Location = new Point(166, 363);
            reviewRichTextBox.Name = "reviewRichTextBox";
            reviewRichTextBox.Size = new Size(561, 87);
            reviewRichTextBox.TabIndex = 9;
            reviewRichTextBox.Text = "";
            // 
            // descriptionRichTextBox
            // 
            descriptionRichTextBox.Location = new Point(217, 249);
            descriptionRichTextBox.Name = "descriptionRichTextBox";
            descriptionRichTextBox.Size = new Size(510, 89);
            descriptionRichTextBox.TabIndex = 8;
            descriptionRichTextBox.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(36, 363);
            label5.Name = "label5";
            label5.Size = new Size(111, 37);
            label5.TabIndex = 7;
            label5.Text = "Review:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 252);
            label4.Name = "label4";
            label4.Size = new Size(159, 37);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // genreComboBox
            // 
            genreComboBox.FormattingEnabled = true;
            genreComboBox.Location = new Point(150, 178);
            genreComboBox.Name = "genreComboBox";
            genreComboBox.Size = new Size(577, 45);
            genreComboBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(36, 186);
            label3.Name = "label3";
            label3.Size = new Size(91, 37);
            label3.TabIndex = 4;
            label3.Text = "Genre:";
            // 
            // directorComboBox
            // 
            directorComboBox.FormattingEnabled = true;
            directorComboBox.Location = new Point(253, 106);
            directorComboBox.Name = "directorComboBox";
            directorComboBox.Size = new Size(474, 45);
            directorComboBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 109);
            label2.Name = "label2";
            label2.Size = new Size(191, 37);
            label2.TabIndex = 2;
            label2.Text = "Director name:";
            // 
            // titleBox
            // 
            titleBox.Location = new Point(140, 32);
            titleBox.Name = "titleBox";
            titleBox.Size = new Size(587, 44);
            titleBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(81, 37);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // tabPage3
            // 
            tabPage3.BackgroundImage = (Image)resources.GetObject("tabPage3.BackgroundImage");
            tabPage3.Location = new Point(4, 49);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(995, 582);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Update";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.BackgroundImage = (Image)resources.GetObject("tabPage4.BackgroundImage");
            tabPage4.Location = new Point(4, 49);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(995, 582);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Delete";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.BackgroundImage = (Image)resources.GetObject("tabPage5.BackgroundImage");
            tabPage5.Location = new Point(4, 49);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(995, 582);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Opinion";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.BackgroundImage = (Image)resources.GetObject("tabPage6.BackgroundImage");
            tabPage6.Location = new Point(4, 49);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(995, 582);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Sort";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.BackgroundImage = (Image)resources.GetObject("tabPage7.BackgroundImage");
            tabPage7.Location = new Point(4, 49);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(995, 582);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Search";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1003, 635);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Catalog";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button showAllMovies;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private PictureBox pictureBox1;
        private ListBox printAllMoviesList;
        private Label label3;
        private ComboBox directorComboBox;
        private Label label2;
        private TextBox titleBox;
        private Label label1;
        private ComboBox ratingComboBox;
        private Label label6;
        private RichTextBox reviewRichTextBox;
        private RichTextBox descriptionRichTextBox;
        private Label label5;
        private Label label4;
        private ComboBox genreComboBox;
        private Button addMovie;
    }
}
