
namespace Uzduotis.Backend.Models
{
    class Subject
    {
        public int ID { get; private set; }
        public string Title { get; private set; }
        public int GrupeID { get; private set; }
        public Subject(int id, string title, int grupeId)
        {
            GrupeID = grupeId;
            ID = id;
            Title = title;
        }
    }
}
