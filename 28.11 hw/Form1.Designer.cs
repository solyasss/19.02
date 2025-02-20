using System.Windows.Forms;
using System.Drawing;

namespace hw
{
    partial class form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox combo_authors;
        private ListBox list_books;
        private CheckBox checkbox_filter;
        private MenuStrip menu_strip;
        private ToolStripMenuItem file_menu;
        private ToolStripMenuItem menu_open;
        private ToolStripMenuItem menu_save;
        private ToolStripMenuItem menu_exit;
        private ToolStripMenuItem options_menu;
        private ToolStripMenuItem menu_add_author;
        private ToolStripMenuItem menu_edit_author;
        private ToolStripMenuItem menu_delete_author;
        private ToolStripMenuItem menu_add_book;
        private ToolStripMenuItem menu_edit_book;
        private ToolStripMenuItem menu_delete_book;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.combo_authors = new System.Windows.Forms.ComboBox();
            this.list_books = new System.Windows.Forms.ListBox();
            this.checkbox_filter = new System.Windows.Forms.CheckBox();
            this.menu_strip = new System.Windows.Forms.MenuStrip();
            this.file_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_save = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.options_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_author = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_author = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_delete_author = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_add_book = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_edit_book = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_delete_book = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_authors
            // 
            this.combo_authors.FormattingEnabled = true;
            this.combo_authors.Location = new System.Drawing.Point(20, 50);
            this.combo_authors.Name = "combo_authors";
            this.combo_authors.Size = new System.Drawing.Size(400, 28);
            this.combo_authors.TabIndex = 0;
            // 
            // list_books
            // 
            this.list_books.FormattingEnabled = true;
            this.list_books.ItemHeight = 20;
            this.list_books.Location = new System.Drawing.Point(20, 100);
            this.list_books.Name = "list_books";
            this.list_books.Size = new System.Drawing.Size(400, 184);
            this.list_books.TabIndex = 1;
            // 
            // checkbox_filter
            // 
            this.checkbox_filter.AutoSize = true;
            this.checkbox_filter.Location = new System.Drawing.Point(20, 320);
            this.checkbox_filter.Name = "checkbox_filter";
            this.checkbox_filter.Size = new System.Drawing.Size(64, 24);
            this.checkbox_filter.TabIndex = 2;
            this.checkbox_filter.Text = "Filter";
            this.checkbox_filter.UseVisualStyleBackColor = true;
            // 
            // menu_strip
            // 
            this.menu_strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu_strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu,
            this.options_menu});
            this.menu_strip.Location = new System.Drawing.Point(0, 0);
            this.menu_strip.Name = "menu_strip";
            this.menu_strip.Size = new System.Drawing.Size(800, 28);
            this.menu_strip.TabIndex = 3;
            this.menu_strip.Text = "menu_strip";
            // 
            // file_menu
            // 
            this.file_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_open,
            this.menu_save,
            this.menu_exit});
            this.file_menu.Name = "file_menu";
            this.file_menu.Size = new System.Drawing.Size(46, 24);
            this.file_menu.Text = "File";
            // 
            // menu_open
            // 
            this.menu_open.Name = "menu_open";
            this.menu_open.Size = new System.Drawing.Size(128, 26);
            this.menu_open.Text = "Open";
            // 
            // menu_save
            // 
            this.menu_save.Name = "menu_save";
            this.menu_save.Size = new System.Drawing.Size(128, 26);
            this.menu_save.Text = "Save";
            // 
            // menu_exit
            // 
            this.menu_exit.Name = "menu_exit";
            this.menu_exit.Size = new System.Drawing.Size(128, 26);
            this.menu_exit.Text = "Exit";
            // 
            // options_menu
            // 
            this.options_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_add_author,
            this.menu_edit_author,
            this.menu_delete_author,
            this.menu_add_book,
            this.menu_edit_book,
            this.menu_delete_book});
            this.options_menu.Name = "options_menu";
            this.options_menu.Size = new System.Drawing.Size(75, 24);
            this.options_menu.Text = "Options";
            // 
            // menu_add_author
            // 
            this.menu_add_author.Name = "menu_add_author";
            this.menu_add_author.Size = new System.Drawing.Size(224, 26);
            this.menu_add_author.Text = "Add Author";
            // 
            // menu_edit_author
            // 
            this.menu_edit_author.Name = "menu_edit_author";
            this.menu_edit_author.Size = new System.Drawing.Size(224, 26);
            this.menu_edit_author.Text = "Edit Author";
            // 
            // menu_delete_author
            // 
            this.menu_delete_author.Name = "menu_delete_author";
            this.menu_delete_author.Size = new System.Drawing.Size(224, 26);
            this.menu_delete_author.Text = "Delete Author";
            // 
            // menu_add_book
            // 
            this.menu_add_book.Name = "menu_add_book";
            this.menu_add_book.Size = new System.Drawing.Size(224, 26);
            this.menu_add_book.Text = "Add Book";
            // 
            // menu_edit_book
            // 
            this.menu_edit_book.Name = "menu_edit_book";
            this.menu_edit_book.Size = new System.Drawing.Size(224, 26);
            this.menu_edit_book.Text = "Edit Book";
            // 
            // menu_delete_book
            // 
            this.menu_delete_book.Name = "menu_delete_book";
            this.menu_delete_book.Size = new System.Drawing.Size(224, 26);
            this.menu_delete_book.Text = "Delete Book";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkbox_filter);
            this.Controls.Add(this.list_books);
            this.Controls.Add(this.combo_authors);
            this.Controls.Add(this.menu_strip);
            this.MainMenuStrip = this.menu_strip;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Authors and Books";
            this.menu_strip.ResumeLayout(false);
            this.menu_strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
