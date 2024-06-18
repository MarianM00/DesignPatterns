
//Permite definirea unei familii de algoritmi, encapsularea fiecăruia dintre aceștia și schimbarea lor la nevoie.

//Strategy este util când trebuie să schimbăm algoritmi la runtime fără a modifica codul client.


// Utilizare
SortingContext context = new SortingContext();

context.SetStrategy(new BubbleSort());
context.Sort(new List<int> { 3, 1, 4, 1, 5, 9 });

context.SetStrategy(new QuickSort());
context.Sort(new List<int> { 3, 1, 4, 1, 5, 9 });

