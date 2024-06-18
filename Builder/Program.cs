
//Rol: Separă construcția unui obiect complex de reprezentarea sa, astfel încât același proces de construcție poate crea reprezentări diferite.

//Descriere: Builder Pattern permite construirea pas cu pas a obiectelor complexe. Separă construcția logică de construcția fizică a obiectului.

//Utilizare: Crearea de obiecte cu mulți parametri opționali sau configurări complexe, cum ar fi obiecte JSON sau XML.

// Utilizare
IBuilder builder = new ConcreteBuilder();
Director director = new Director(builder);

director.Construct();
Product product = builder.GetResult();

Console.WriteLine($"Product Parts: {product.PartA}, {product.PartB}");