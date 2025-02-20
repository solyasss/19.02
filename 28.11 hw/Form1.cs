using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace hw
{
    public partial class form1 : Form, i_view
    {
        public form1()
        {
            InitializeComponent();
            combo_authors.SelectedIndexChanged += (s,e) => author_selected?.Invoke(this, EventArgs.Empty);
            checkbox_filter.CheckedChanged += (s,e) => filter_changed?.Invoke(this, EventArgs.Empty);

            menu_add_author.Click += (s,e) => add_author_clicked?.Invoke(this, EventArgs.Empty);
            menu_edit_author.Click += (s,e) => edit_author_clicked?.Invoke(this, EventArgs.Empty);
            menu_delete_author.Click += (s,e) => delete_author_clicked?.Invoke(this, EventArgs.Empty);

            menu_add_book.Click += (s,e) => add_book_clicked?.Invoke(this, EventArgs.Empty);
            menu_edit_book.Click += (s,e) => edit_book_clicked?.Invoke(this, EventArgs.Empty);
            menu_delete_book.Click += (s,e) => delete_book_clicked?.Invoke(this, EventArgs.Empty);

            menu_open.Click += (s,e) => open_clicked?.Invoke(this, EventArgs.Empty);
            menu_save.Click += (s,e) => save_clicked?.Invoke(this, EventArgs.Empty);
            menu_exit.Click += (s,e) => exit_clicked?.Invoke(this, EventArgs.Empty);
        }
        
        public void update_authors(List<string> authors)
        {
            combo_authors.Items.Clear();
            combo_authors.Items.AddRange(authors.ToArray());
        }

        public void update_books(List<string> books)
        {
            list_books.Items.Clear();
            list_books.Items.AddRange(books.ToArray());
        }

        public string selected_author
        {
            get
            {
                return combo_authors.SelectedItem as string;
            }
        }

        public string selected_book
        {
            get
            {
                return list_books.SelectedItem as string;
            }
        }

        public bool is_filter_enabled
        {
            get
            {
                return checkbox_filter.Checked;
            }
        }

        public void show_message(string message, string caption = "Info")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool show_confirm(string message, string caption)
        {
            return MessageBox.Show(message, caption, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public string show_input_dialog(string text, string caption)
        {
            return Microsoft.VisualBasic.Interaction.InputBox(text, caption, "");
        }

        public string show_open_file_dialog(string filter)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = filter;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return ofd.FileName;
                }
            }
            return string.Empty;
        }

        public string show_save_file_dialog(string filter)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = filter;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    return sfd.FileName;
                }
            }
            return string.Empty;
        }

        public void close_view()
        {
            this.Close();
        }
        
        public event EventHandler author_selected;
        public event EventHandler filter_changed;
        public event EventHandler add_author_clicked;
        public event EventHandler edit_author_clicked;
        public event EventHandler delete_author_clicked;
        public event EventHandler add_book_clicked;
        public event EventHandler edit_book_clicked;
        public event EventHandler delete_book_clicked;
        public event EventHandler open_clicked;
        public event EventHandler save_clicked;
        public event EventHandler exit_clicked;
    }
}
