Before
if(book !=null && book.File != null && book.File.Name != null)
                return book.File.Name;

After                                                 After After
if(book?.File?.Name != null)                           return book?.File?.Name ?? string.Empty;
               return book.File.Name;
return string.Empty

