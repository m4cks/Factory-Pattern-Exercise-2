namespace FactoryPatternExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter SQL or Mongo to determine type of Database: ");
            string? dataType = Console.ReadLine();
            IDataAccess dataAccess = DataAccessFactory.GetDataAccess(dataType);
            dataAccess.SaveData();
        }
    }
}