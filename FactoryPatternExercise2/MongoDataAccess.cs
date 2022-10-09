using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    internal class MongoDataAccess : IDataAccess
    {
        public void SaveData()
        {
            Console.WriteLine("Saving Data to Mongo");
        }
    }
}
