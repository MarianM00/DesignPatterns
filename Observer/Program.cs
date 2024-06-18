
// Definește o dependență de tipul unu-la-mulți între obiecte astfel încât atunci când un obiect își schimbă starea,
// toate obiectele dependente sunt notificate și actualizate automat.
// Observer este util pentru notificarea automată a mai multor obiecte despre schimbări de stare.

// Utilizare
Product product = new Product();
Customer customer1 = new Customer("Alice");
Customer customer2 = new Customer("Bob");

product.AddObserver(customer1);
product.AddObserver(customer2);

product.Availability = "in stock"; // Both Alice and Bob are notified