namespace ArrayInitializeTask_Books_.Models
{
    internal class BookLibrary
    {
        public Book[] _books = new Book[0];

        public string _name;


        public Book[] Books
        {
            get
            {
                return _books;
            }
            set
            {
                _books = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                value = value.Trim();
                _name = value;

                if (value.Length >= 3)
                {
                    Console.WriteLine($"Kitab adi:{_name}");
                }
                else
                {
                    Console.WriteLine("Kitab adi 3 herfden qisa ola bilmez!");
                }

            }
        }


        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            _books[_books.Length - 1] = book;
        }

        public void Remove(string book)
        {
            Book[] arr = new Book[Books.Length - 1];
            int index = 0;

            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Name.ToLower() != book.ToLower())
                {
                    arr[index] = Books[i];
                    index++;
                }

            }

            Books = arr;

        }

        public void ShowAll()
        {
            for (int i = 0; i < Books.Length; i++)
            {
                Books[i].GetInfo();
            }
        }



        public void BorrowBook(string name)
        {
            bool bookFound = true;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].IsAvailable == true && Books[i].Name.ToLower() == name.ToLower())
                {
                    Books[i].IsAvailable = false;
                    bookFound = false;
                    break;
                }
            }

            if (bookFound)
            {
                Console.WriteLine("Bele kitab yoxdur!");
            }
        }

        public void ReturnBook(string name)
        {
            bool hasBook = false;
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].IsAvailable == false && Books[i].Name.ToLower() == name.ToLower())
                {
                    Books[i].IsAvailable = true;
                    hasBook = true;
                    break;
                }
            }

            if (!hasBook)
            {
                Console.WriteLine("Bu kitab bizim deyil!");
            }

        }


        public void SearchByAuthor(string authorName)
        {
            for (int i = 0; i < Books.Length; i++)
            {
                if (Books[i].Author == authorName)
                {
                    Console.WriteLine($"{Books[i].Name}");
                }
            }
        }

    }
}
