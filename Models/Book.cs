namespace ArrayInitializeTask_Books_.Models
{
    internal class Book
    {
        public string _name;
        public string _author;
        public bool _isAvailable = true;

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

        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                value = value.Trim();
                bool hasDigit = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]))
                    {
                        Console.WriteLine("Muellif adinda reqem ola bilmez!");
                        hasDigit = true;
                    }
                }

                if (value.Length >= 3 && !hasDigit)
                {
                    _author = value;
                    Console.WriteLine($"Muellif adi:{_author}");
                }
                else if (!hasDigit)
                {
                    Console.WriteLine("Muellif adi 3 herfden qisa ola bilmez!");
                }
            }
        }
        public bool IsAvailable
        {
            get
            {
                return _isAvailable;
            }
            set
            {
                _isAvailable = value;
            }
        }


        public Book(string name)
        {
            Name = name;
        }

        public Book(string name, string author) : this(name)
        {
            Author = author;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Kitab adi:{Name}, Muellifi: {_author}");
        }
    }
}
