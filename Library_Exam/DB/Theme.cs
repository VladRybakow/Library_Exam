//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Exam.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Theme
    {
        public Theme()
        {
            this.Book = new HashSet<Book>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Book> Book { get; set; }
    }
}