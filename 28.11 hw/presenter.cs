using System;
using System.Collections.Generic;
using System.Linq;

namespace hw
{
    public class presenter
    {
        private readonly i_view view;
        private readonly i_model model;

        public presenter(i_view view, i_model model)
        {
            this.view = view;
            this.model = model;

            this.view.author_selected += on_author_selected;
            this.view.filter_changed += on_filter_changed;
            this.view.add_author_clicked += on_add_author_clicked;
            this.view.edit_author_clicked += on_edit_author_clicked;
            this.view.delete_author_clicked += on_delete_author_clicked;
            this.view.add_book_clicked += on_add_book_clicked;
            this.view.edit_book_clicked += on_edit_book_clicked;
            this.view.delete_book_clicked += on_delete_book_clicked;
            this.view.open_clicked += on_open_clicked;
            this.view.save_clicked += on_save_clicked;
            this.view.exit_clicked += on_exit_clicked;
        }

        public void initialize()
        {
            refresh_authors();
        }

        private void refresh_authors()
        {
            var authors = model.get_authors();
            view.update_authors(authors);
        }

        private void refresh_books()
        {
            if (view.is_filter_enabled)
            {
                var books = model.get_all_books();
                view.update_books(books);
            }
            else if (!string.IsNullOrEmpty(view.selected_author))
            {
                var books = model.get_books_by_author(view.selected_author);
                view.update_books(books);
            }
            else
            {
                view.update_books(new List<string>());
            }
        }

        private void on_author_selected(object sender, EventArgs e)
        {
            refresh_books();
        }

        private void on_filter_changed(object sender, EventArgs e)
        {
            refresh_books();
        }

        private void on_add_author_clicked(object sender, EventArgs e)
        {
            var name = view.show_input_dialog("Enter author name:", "Add Author");
            if (!string.IsNullOrWhiteSpace(name))
            {
                model.add_author(name);
                refresh_authors();
            }
        }

        private void on_edit_author_clicked(object sender, EventArgs e)
        {
            var old_name = view.selected_author;
            if (string.IsNullOrEmpty(old_name))
            {
                view.show_message("No author selected.", "Error");
                return;
            }

            var new_name = view.show_input_dialog("Edit author name:", "Edit Author");
            if (!string.IsNullOrWhiteSpace(new_name))
            {
                model.edit_author(old_name, new_name);
                refresh_authors();
            }
        }

        private void on_delete_author_clicked(object sender, EventArgs e)
        {
            var name = view.selected_author;
            if (string.IsNullOrEmpty(name))
            {
                view.show_message("No author selected.", "Error");
                return;
            }

            if (view.show_confirm($"Are you sure you want to delete author '{name}'?", "Delete Author"))
            {
                model.delete_author(name);
                refresh_authors();
                view.update_books(new List<string>());
            }
        }

        private void on_add_book_clicked(object sender, EventArgs e)
        {
            var author = view.selected_author;
            if (string.IsNullOrEmpty(author))
            {
                view.show_message("No author selected.", "Error");
                return;
            }

            var book_title = view.show_input_dialog("Enter book title:", "Add Book");
            if (!string.IsNullOrWhiteSpace(book_title))
            {
                model.add_book(author, book_title);
                refresh_books();
            }
        }

        private void on_edit_book_clicked(object sender, EventArgs e)
        {
            var author = view.selected_author;
            var old_title = view.selected_book;
            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(old_title))
            {
                view.show_message("No book selected.", "Error");
                return;
            }

            var new_title = view.show_input_dialog("Edit book title:", "Edit Book");
            if (!string.IsNullOrWhiteSpace(new_title))
            {
                model.edit_book(author, old_title, new_title);
                refresh_books();
            }
        }

        private void on_delete_book_clicked(object sender, EventArgs e)
        {
            var author = view.selected_author;
            var book_title = view.selected_book;
            if (string.IsNullOrEmpty(author) || string.IsNullOrEmpty(book_title))
            {
                view.show_message("No book selected.", "Error");
                return;
            }

            if (view.show_confirm($"Are you sure you want to delete book '{book_title}'?", "Delete Book"))
            {
                model.delete_book(author, book_title);
                refresh_books();
            }
        }

        private void on_open_clicked(object sender, EventArgs e)
        {
            var file_path = view.show_open_file_dialog("XML Files (*.xml)|*.xml|All Files (*.*)|*.*");
            if (!string.IsNullOrEmpty(file_path))
            {
                model.set_file_path(file_path);
                model.load_data();
                refresh_authors();
            }
        }

        private void on_save_clicked(object sender, EventArgs e)
        {
            var file_path = view.show_save_file_dialog("XML Files (*.xml)|*.xml|All Files (*.*)|*.*");
            if (!string.IsNullOrEmpty(file_path))
            {
                model.set_file_path(file_path);
                model.save_data();
                view.show_message("Data saved successfully (EF).", "Save");
            }
        }

        private void on_exit_clicked(object sender, EventArgs e)
        {
            view.close_view();
        }
    }
}
