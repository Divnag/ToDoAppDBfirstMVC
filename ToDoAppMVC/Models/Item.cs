//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToDoAppMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Item
    {
        public int ItemID { get; set; }
        [Display(Name = "Task")]
        public string ItemName { get; set; }
        [Display (Name="Description")]
        public string ItemDescription { get; set; }
        [Display(Name = "Due")]
        public Nullable<System.DateTime> DueDate { get; set; }
        [Display(Name = "Done?")]
        public bool IsDone { get; set; }
        public int Priority { get; set; }
        [Display(Name = "List")]
        public int ListID { get; set; }
    
        public virtual List List { get; set; }
    }
}
