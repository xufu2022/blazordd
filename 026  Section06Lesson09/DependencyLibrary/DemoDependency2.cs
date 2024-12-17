namespace DependencyLibrary;

public class DemoDependency2 : IDemoDependency
{
    public string GiveRandomNumber()
    {
        return "This is our not-working random value: 5";
    }
}
