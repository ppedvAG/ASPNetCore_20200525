//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework60Sample
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime CreatedBy { get; set; }
        public int BlogId { get; set; }
    
        public virtual Blog Blog { get; set; }
    }
}
