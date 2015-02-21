using System;
using System.Collections.Generic;
using System.Linq;
using ThyNotebook.Entities;

namespace ThyNotebook.Data
{
    public class NoteDb : BaseData
    {
        public List<Note> GetAll()
        {
            initDocStore();
            using (var docSession = docStore.OpenSession())
            {
                return docSession.Query<Note>().ToList();
            }
        }

        public Note Save(Note note)
        {
            note.UpdateDate = DateTime.Now;
            note.CreateDate = note.UpdateDate;
            
            initDocStore();
            using (var docSession = docStore.OpenSession())
            {
                //store object - don't disagree about my age
                docSession.Store(note);
                //save object
                docSession.SaveChanges();
            }

            return note;
        }

        public void DeleteNote(Note note)
        {
            initDocStore();
            using (var docSession = docStore.OpenSession())
            {
                //store object - don't disagree about my age
                docSession.Delete(note);
                //save object
                docSession.SaveChanges();
            }
        }
    }
}