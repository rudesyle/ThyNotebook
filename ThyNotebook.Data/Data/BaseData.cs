using Raven.Client.Document;

namespace ThyNotebook.Data
{
    public abstract class BaseData
    {
        public DocumentStore docStore = new DocumentStore();
        public void initDocStore()
        {
            docStore = new DocumentStore { Url = "http://localhost:8080/databases/ThyNotebook" };
            docStore.Initialize();
        }
        
    }
}