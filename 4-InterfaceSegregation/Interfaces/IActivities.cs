namespace InterfaceSegregation
{
    public interface IActivities : ITeamWorkActivities, IDesignActivities, IDevelopActivities, ITesterActivities
    {
        // This interface combines all activities, but it is better to keep them separate
        // to adhere to the Interface Segregation Principle.
        // The methods below are commented out to indicate that they should not be used
        // in a single interface as it violates the principle.

        // void Plan();
        // void Comunicate();
        // void Design();
        // void Develop();
        // void Test();
    }
}