using System;
using System.Collections.Generic;

namespace hw
{
    public interface i_view
    {
        void update_authors(List<string> authors);
        void update_books(List<string> books);

        string selected_author { get; }
        string selected_book { get; }

        bool is_filter_enabled { get; }

        void show_message(string message, string caption = "Info");
        bool show_confirm(string message, string caption);
        string show_input_dialog(string text, string caption);
        string show_open_file_dialog(string filter);
        string show_save_file_dialog(string filter);

        void close_view();
        
        event EventHandler author_selected;
        event EventHandler filter_changed;
        event EventHandler add_author_clicked;
        event EventHandler edit_author_clicked;
        event EventHandler delete_author_clicked;
        event EventHandler add_book_clicked;
        event EventHandler edit_book_clicked;
        event EventHandler delete_book_clicked;
        event EventHandler open_clicked;
        event EventHandler save_clicked;
        event EventHandler exit_clicked;
    }
}