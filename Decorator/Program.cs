using Decorator;


// Permite adăugarea de comportamente suplimentare la obiecte individuale dinamic, fără a afecta alte obiecte din aceeași clasă.
// Daca deja utilizezi interface aggregation si solid principle deja stiai sa folosesti acest pattern



INotifier notifier = new SmsNotifierDecorator(new EmailNotifier());
notifier.Send("Hello, World!");

