namespace InterfaceSegregation
{
    public class Developer : IDevelopActivities, ITeamWorkActivities
    {
        public Developer()
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

        public void Develop()
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        // public void Test()
        // {
        //     throw new NotImplementedException();
        // }
    }
}