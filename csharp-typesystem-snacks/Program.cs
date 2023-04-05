



//Istruzioni condizionali
//	1. L’utente inserisce due numeri in successione.
int[] numeri = new int[2];
Console.WriteLine("dimmi due numeri");

for (var i = 0; i < 2; i++)
{
    numeri[i] = Convert.ToInt32(Console.ReadLine());
}


//	Il software stampa il maggiore.
Console.Write("il numero maggiore è: ");

if (numeri[0] > numeri[1])
    Console.WriteLine(numeri[0]);
else
{
    Console.WriteLine(numeri[1]);
}
Console.WriteLine($"{Environment.NewLine}");



//	2. L’utente inserisce due parole in successione.
string[] parole = new string[2];
Console.WriteLine("dimmi due parole");
for (var i = 0; i < 2; i++)
{
    parole[i] = Console.ReadLine();
}

//		Il software stampa prima la parola più corta, poi la parola più lunga.
Console.Write("in ordine di lunghezza sono: ");

if (parole[0].Length < parole[1].Length)
{
    Console.WriteLine($"{parole[0]} e {parole[1]} ");
}
else
{
    Console.WriteLine($"{parole[1]} e {parole[0]} ");
}

Console.WriteLine($"{Environment.NewLine}");

//Ciclo for
//    3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
int top = 10;
int[] numeri10 = new int[top];
Console.WriteLine($"dimmi {top} numeri");

for (int i = 0; i < top; i++)
{
    numeri10[i] = Convert.ToInt32(Console.ReadLine());
}
//Il programma stampa la somma di tutti i numeri inseriti.
int somma = 0;
for (int i = 0; i < top; i++)
{
    somma = somma + numeri10[i];
}

Console.Write($"la somma é: ");
Console.WriteLine($"{somma}");


Console.WriteLine($"{Environment.NewLine}");

//    4. Calcola la somma e la media dei numeri da 2 a 10.
somma = 0;
for(int i = 2; i <= 10; i++)
{
    somma = somma + i;
}

double media = somma / 9;
Console.WriteLine($"La somma dei numeri da 2 a 10 è: {somma}");
Console.WriteLine($"La media dei numeri da 2 a 10 è: {media}");


Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");




//Operatore modulo
//    5. Il software chiede all’utente di inserire un numero.
//    Se il numero inserito è pari, stampa il numero, se è dispari,
//    stampa il numero successivo.


Console.WriteLine("dimmi un numero");
Console.WriteLine("Se il numero inserito è pari: stampo il numero,\r\n" +
    "se è dispari: stampo il numero successivo");

int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"risultato = {numero + (numero % 2)}");




//Array
//    6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//	7. Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.
//Ciclo while
//    9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.
//Random
//    10. Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.
//Funzioni
//    11. Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
//    12. Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari. 


Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");