using System;
using System.Collections.Generic;
using System.Linq;
using Raven.Client.Document;
using ThyNotebook.Entities;

namespace ThyNotebook.Data
{
    public class NotebookDb : BaseData
    {
        public List<Notebook> GetAll()
        {
            initDocStore();
            using (var docSession = docStore.OpenSession())
            {
                var list = from notebooks in docSession.Query<Notebook>()
                             orderby notebooks.Name
                             select notebooks;
                return list.ToList();
            }
           
        }

        public Notebook Save(Notebook notebook)
        {
            notebook.UpdateDate = DateTime.Now;

            initDocStore();
            using (var docSession = docStore.OpenSession())
            {
                //store object - don't disagree about my age
                docSession.Store(notebook);
                //save object
                docSession.SaveChanges();
            }

            /*
             * if (notebook.NotebookId == 0)
            {
                notebook.CreateDate = notebook.UpdateDate;
                GetDb().Insert("notebook", "notebookid", notebook);
            }
            else
            {
                GetDb().Update("notebook", "notebookid", notebook);
            }*/

            return notebook;
        }

        public void Delete(Notebook notebook)
        {
            initDocStore();
            using (var docSession = docStore.OpenSession())
            {
                //store object - don't disagree about my age
                docSession.Delete(notebook);
                //save object
                docSession.SaveChanges();
            }
        }
    }
}