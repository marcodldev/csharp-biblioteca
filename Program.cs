
using csharp_biblioteca;

UtenteRegistrato Utente1 = new UtenteRegistrato()
{
    Nome = "Sarah" ,
    Cognome = "Verdi" ,
    Email = "sarahverdi@test.it",
    Password = "password" ,
    RecapitoTelefonico = 3333333,
};

Libri libro1 = new Libri()
{
    Id = 1,
    Titolo = "Seneca tra gli zombie",
    Anno = 2022,
    Settore = "Filosofia",
    Scaffale = "Reparto libri",
    Autore = "Rick DuFer",
    Npagine = 140
};

DVD dvd1 = new DVD()
{
    Id = 1,
    Titolo = "Fight Club",
    Anno = 1999,
    Settore = "Azione, Thriller, Giallo, Umorismo nero, Drammatico",
    Scaffale = "Reparto DVD",
    Autore = "David Fincher",
    Durata = 139,
};


Console.WriteLine(Utente1);
Console.WriteLine(libro1 + System.Environment.NewLine);
Console.WriteLine(dvd1);