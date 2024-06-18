
//Încapulează o cerere ca un obiect, permițând parametrizarea clientilor cu cereri,
//înregistrarea sau jurnalizarea cererilor și suportul pentru operațiuni anulate.

// Utilizare
Light light = new Light();
RemoteControl remote = new RemoteControl();

remote.SetCommand(new LightOnCommand(light));
remote.PressButton();

remote.SetCommand(new LightOffCommand(light));
remote.PressButton();