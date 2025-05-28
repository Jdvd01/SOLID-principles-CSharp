namespace InterfaceSegregation
{
    public class Tester : ITesterActivities, ITeamWorkActivities
    {
        public Tester()
        {
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        // public void Design() 
        // {
        //     throw new NotImplementedException();
        // }

        // public void Develop() 
        // {
        //     Console.WriteLine("I'm developing the functionalities required");
        // }

        public void Test()
        {
            Console.WriteLine("I'm testing the functionalities required");
        }
    }
}