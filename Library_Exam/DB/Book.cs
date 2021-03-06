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
    
    public partial class Book
    {
        public Book()
        {
            this.TurnOver = new HashSet<TurnOver>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublishing { get; set; }
        public string Pulbisher { get; set; }
        public int ThemeId { get; set; }
        public int Count { get; set; }
        public Nullable<bool> IsRestrictions { get; set; }
    
        public virtual Theme Theme { get; set; }
        public virtual ICollection<TurnOver> TurnOver { get; set; }
    }
}
