using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace csharp_biblioteca

 
{
    public class Utente
    {
        

        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public int RecapitoTelefonico { get; set; }

        bool Registrato = true;

        public override string ToString()
        {
            return $"Nome: {Nome} " + NewLine
               + $"Cognome: {Cognome}" + NewLine
               + $"Email: {Email}" + NewLine
               + $"Recapito telefonico: {RecapitoTelefonico}" + NewLine;
        }

    }

    public class Documenti
    {
        public string? Id { get; set; }
        public string? Titolo { get; set; }
        public int Anno { get; set; }
        public string? Settore { get; set; }
        public string? Scaffale { get; set; }
        public string? Autore { get; set; }


        public override string ToString()
        {
            return $"Codice Identificativo: {Id} " + NewLine
               + $"Titolo: {Titolo}" + NewLine
               + $"Anno: {Anno}" + NewLine
               + $"Settore: {Settore}" + NewLine
               + $"Scaffale: {Scaffale}" + NewLine
               + $"Autore: {Autore}" + NewLine
               ;
        }
    }

    public class Libri : Documenti
    {

        public int Npagine { get; set; }

        public override string ToString()
        {
            return base.ToString() 
                + $"Numero Pagine: {Npagine}";
        }
    }

    public class DVD : Documenti
    {
        public int Durata { get; set; }

        public override string ToString()
        {
            return base.ToString()  
                + $"Durata: {Durata}";
        }
    }

    public class Biblioteca
    {
        public List<Utente> utentiRegistrati;
        private List<Documenti> documenti;


        // COSTRUTTORE
        public Biblioteca()
        {
            utentiRegistrati = new List<Utente>();
            documenti = new List<Documenti>();
        }

        // AZIONI

        public void AggiungiUtente(Utente utente)
        {
            utentiRegistrati.Add(utente);
        }

        public void RimuoviUtente(Utente utente)
        {
            utentiRegistrati.Remove(utente);
        }




        // LISTE

        public List<Utente> GetUtentiRegistrati()
        {
            return utentiRegistrati;
        }

        public List<Documenti> GetDocumenti()
        {
            return documenti;
        }

    }

    /* Gli utenti registrati possono prendere in prestito dei documenti che sono di vario tipo (libri, DVD).
     * 
    L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente,
    prendere in prestito registrando il periodo (Dal/Al) del prestito e il documento.
    Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
    Creiamo anche una classe Biblioteca che contiene la lista dei documenti, la lista degli utenti e la lista dei prestiti.
    Contiene inoltre i metodi per le ricerche e per l’aggiunta dei documenti, utenti e prestiti. */

}
