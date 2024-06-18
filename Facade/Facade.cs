// See https://aka.ms/new-console-template for more information
public class Facade
{
    private SubsystemA _subsystemA;
    private SubsystemB _subsystemB;

    public Facade()
    {
        _subsystemA = new SubsystemA();
        _subsystemB = new SubsystemB();
    }

    public void Operation()
    {
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }
}
