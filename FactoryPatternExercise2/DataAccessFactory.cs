using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal static class DataAccessFactory
    {
        public static IDataAccess GetDataAccess(string dataType)
        {
            if (dataType == null)
                return null;
            switch(dataType.ToUpper())
            {
                case "SQL":
                    return new SQLDataAccess();
                case "MONGO":
                    return new MongoDataAccess();
                default:
                    return null;
            }
        }
    }
}
