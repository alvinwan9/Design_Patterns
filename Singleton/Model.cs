using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Model
    {
        private static Model instance = null;
        private String ParameterA;
        private Model() { }
        public static Model GetInstance()
        {
            if (instance == null)
                instance = new Model();
            return instance;
        }
        public String GetParameterA
        { get { return ParameterA; } }
        public String SetParameterA
        { set { ParameterA = value; } }
    }
}
