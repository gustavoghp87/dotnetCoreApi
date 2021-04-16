using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        // se usa solo en la primera fase
        public IEnumerable<Command> GetAllCommands()
        {
            var Commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"},
                new Command{Id=1, HowTo="Cut bread", Line="Get a knife", Platform="Knife & chopping board"},
                new Command{Id=2, HowTo="Make cup of tea", Line="Place teabag in cup", Platform="Kettle & cup"}
            };
            return Commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil water", Platform="Kettle & Pan"};
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}