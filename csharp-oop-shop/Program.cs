






namespace csharp_oop_shop
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //creo nuovo prodotto
            Prodotto prod1 = new Prodotto("pasta", "bucatini sottili", 2.5f, 22 );

            //stampo
            Console.WriteLine("Codice: " + prod1.Codice);
            Console.WriteLine("Nome: " + prod1.Nome);
            Console.WriteLine("Descrizione: " + prod1.Descrizione);
            Console.WriteLine("Prezzo: " + prod1.Prezzo + " euro");
            Console.WriteLine("Iva: " + prod1.Iva + "%");
            Console.WriteLine("Prezzo con Iva: " + prod1.prezzoIva().ToString("F2") + " euro");
            Console.WriteLine("Nome esteso: " + prod1.NomeEsteso());


            





        }




        //creare la classe Prodotto che gestisce i prodotti dello shop.
        //Un prodotto è caratterizzato da:
        //- codice (numero intero)
        //- nome
        //- descrizione
        //- prezzo
        //- iva

        private class Prodotto
        {
            private int cifreCodice = 8;
            private int codice;
            public int Codice
            {
                get
                { 
                    string codiceString = codice.ToString();
                    string esito = "";

                    
                    return codice;
                }
            }

            private string nome;
            public string Nome
            {
                get
                {
                    return nome;
                }
                set
                {
                    nome = value;
                }
            }

            private string descrizione;
            public string Descrizione

            {
                get
                {
                    return descrizione;
                }
                set
                {
                    descrizione = value;
                }
            }


            private float prezzo;
            public float Prezzo

            {
                get
                {
                    return prezzo;
                }
                set
                {
                    prezzo = value;
                }
            }



            private int iva;
            public int Iva
            {
                get
                {
                    return iva;
                }
                set
                {
                        iva = value;
                }
            }


            public float prezzoIva()
            {

                return this.Prezzo * (1 + ((float)this.Iva / 100));
            }


            public string NomeEsteso()
            {
                return Codice + " " + Nome;
            }




            //costruttore
            public Prodotto(string nome, string descrizione, float prezzo, int iva)
            {
                Random rnd = new Random();
                this.codice = rnd.Next(1, 99999);
                this.nome = nome;
                this.descrizione = descrizione;
                this.prezzo = prezzo;
                this.iva = iva;
            }


        }




    }
}



//Usate opportunamente i livelli di accesso (public, private), 
//i costruttori, 
//i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base
//che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso,
//ottenuto concatenando codice + nome
//Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci per testare tutti i metodi che avete previsto.
//BONUS:
//- create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri 
//(ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
//- Usando un array, dichiarate un elenco dei prodotti di un negozio 
//e inseriteci al suo interno qualche prodotto che vi aspettate di trovare nel negozio. 
//Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.



