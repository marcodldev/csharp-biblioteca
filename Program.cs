
using csharp_biblioteca;

//METODI

GetLista();

Biblioteca Biblioteca_comunale = new Biblioteca();

Utente Utente1 = new Utente()
{
    Nome = "Sarah" ,
    Cognome = "Verdi" ,
    Email = "sarahverdi@test.it",
    Password = "password" ,
    RecapitoTelefonico = 3333333,
};

Utente Utente2 = new Utente()
{
    Nome = "Franco",
    Cognome = "Baresi",
    Email = "francobaresi@test.it",
    Password = "password",
    RecapitoTelefonico = 334333333,
};

Biblioteca_comunale.AggiungiUtente(Utente1);
Biblioteca_comunale.AggiungiUtente(Utente2);

Libri libro1 = new Libri()
{
    Id = "1",
    Titolo = "Seneca tra gli zombie",
    Anno = 2022,
    Settore = "Filosofia",
    Scaffale = "Reparto libri",
    Autore = "Rick DuFer",
    Npagine = 140
};

DVD dvd1 = new DVD()
{
    Id = "1",
    Titolo = "Fight Club",
    Anno = 1999,
    Settore = "Azione, Thriller, Giallo, Umorismo nero, Drammatico",
    Scaffale = "Reparto DVD",
    Autore = "David Fincher",
    Durata = 139,
};



void GetLista()
{

    Console.WriteLine($"Utenti registrati:{System.Environment.NewLine}");

    foreach (Utente utente in Biblioteca_comunale.GetUtentiRegistrati())
    {
        Console.WriteLine($"{System.Environment.NewLine}{utente}");
    }

}


/*
Console.WriteLine(Utente1);
Console.WriteLine(libro1 + System.Environment.NewLine);
Console.WriteLine(dvd1); */