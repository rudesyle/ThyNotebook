using System;
using System.Collections.Generic;

namespace ThyNotebook.Entities
{

    public class Notebook
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int NotebookId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserId { get; set; }

        public ICollection<Note> Notes { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsNew { get; set; }
    }
}