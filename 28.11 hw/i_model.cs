using System;
using System.Collections.Generic;

namespace hw
{
    public interface i_model
    {
        List<string> get_authors();
        List<string> get_books_by_author(string author_name);
        List<string> get_all_books();
        void add_author(string name);
        void delete_author(string name);
        void edit_author(string old_name, string new_name);
        void add_book(string author_name, string book_title);
        void delete_book(string author_name, string book_title);
        void edit_book(string author_name, string old_title, string new_title);
        
        void load_data();
        void save_data();
        void set_file_path(string path);
    }
}