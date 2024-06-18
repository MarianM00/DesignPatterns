//Rol: Specifică tipul de obiecte de creat utilizând o instanță prototip și creând noi obiecte prin clonarea acestui prototip.

//Descriere: Prototype Pattern este utilizat pentru a crea obiecte prin clonarea unui obiect existent,
//numit prototip. Este util atunci când costul de creare a unui nou obiect este ridicat.

//Utilizare: Crearea de obiecte când costul de instanțiere este mare, cum ar fi configurații complexe.


// Utilizare
ConcretePrototype original = new ConcretePrototype();
original.Property = "Original";

ConcretePrototype clone = (ConcretePrototype)original.Clone();
clone.Property = "Clone";

Console.WriteLine($"Original Property: {original.Property}");
Console.WriteLine($"Clone Property: {clone.Property}");