using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace processRunner
{
    class Jasonserializer 
    {
        #region singleton
        private static Jasonserializer instance;

        private Jasonserializer() { }

        public static Jasonserializer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Jasonserializer();
                }
                return instance;
            }
        } 
        #endregion

        public bool serialize(out process process)
        {
            throw new NotImplementedException();
        }
    }
}
