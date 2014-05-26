using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfBrodovi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BrodoviService : IBrodovi
    {
        List<Brod> sviBrodovi = new List<Brod>()
        {
            new Brod(1, "Titanic","London", 13431.3),
            new Brod(2, "Titanic2","Lisabon", 13431.3),
            new Brod(3, "Titanic3","Barca", 13231.3),
            new Brod(4, "Titanic4","NoName", 13431.3),

        };
        public Brod DajBrod(string sid)
        {
            int id = Int32.Parse(sid);
            return sviBrodovi.First( b => b.Id == id);
        }

        public List<Brod> DajSve()
        {
            return sviBrodovi;
        }
    }
}
