
// ConcretePrototype class
public class ConcretePrototype : Prototype
{
    public string? Property { get; set; }

    public override Prototype Clone()
    {
        return (Prototype)this.MemberwiseClone();
    }
}
