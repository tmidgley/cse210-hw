// Exceeding Requirement: added validation to RecordEvent() if the choice is invalid and LoadFile() if file is not found

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}