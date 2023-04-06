



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
Console.WriteLine($"dimmi {top} numeri, te ne dirò la somma");

for (int i = 0; i < top; i++)
{
    Console.Write($"{i + 1})    ");
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
for (int i = 2; i <= 10; i++)
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



Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");



//Array
//    6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//    Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitati = {
    "Matteo",
    "Alessio",
    "Tiglio",
};

Console.WriteLine("Dimmi il tuo nome");
//stampo la lista per aiutare il debug
Console.Write("in lista ci sono: ");
foreach (string invitato in invitati)
{
    Console.Write($"{invitato}  ");

}
Console.WriteLine($"{Environment.NewLine}");

string nome = Console.ReadLine();

bool presenza = false;
//ciclo che gira finché non finisco la lista di invitati
//o trovo la PRESENZA del nome
for (int i = 0; i < invitati.Length && presenza == false; i++)
{
    if (invitati[i].ToLower() == nome.ToLower())
    {
        presenza = true;
    }

}

if (presenza)
{

    Console.WriteLine($"Benvenuto/a sir/madame  {nome} ");
}
else
{
    Console.WriteLine($"non sei invitato");

}


Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");


//	7. Crea un array vuoto.
int nEs7 = 6;
int indexEs7 = 0;
Console.WriteLine($"creo un array vuoto di {nEs7} elementi.");
Console.WriteLine($"dimmi {nEs7} elementi, \r\n" + $"se sono dispari li inserisco nell'array \r\n");
int[] arrEs7 = new int[nEs7];

//Chiedi per nEs7 == 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
for (int i = 0; i < nEs7; i++)
{

    Console.Write($"inserisci il numero ({i + 1}): ");
    int numeroEs7 = Convert.ToInt32(Console.ReadLine());

    if (numeroEs7 % 2 == 1)
    {
        arrEs7[indexEs7] = numeroEs7;
        indexEs7++;

    }
}

Console.WriteLine($"{Environment.NewLine}");

//stampo l'array risultante
Console.WriteLine($"l'array risultante è: ");

for (int i = 0; i < arrEs7.Length; i++)
{
    if (arrEs7[i] != 0)
    Console.WriteLine($"{i + 1}): {arrEs7[i]}");
}





Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");

//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] arrEs8 =
{
    1,
    2,
    3,
    4,
    5,
    6,
    7,
    8,
    9,
    10,

};
int sommaEs8 = 0;


Console.Write($"Ho un array: ");
for (int i = 0; i < arrEs8.Length; i++)
{
    Console.Write($"{arrEs8[i]} ");
    if (i % 2 == 1)
    {

        sommaEs8 = sommaEs8 + arrEs8[i];
    }
}
Console.WriteLine($"");
Console.Write($"la somma dei suoi elementi in posizione dispari è:  {sommaEs8}");

Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");


//Ciclo while
//    9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//    Continua a chiedere i numeri all’utente e a inserirli nell’array,
//    fino a quando la somma degli elementi è minore di 50.


Console.WriteLine($"dammi numeri finché non arrivo a 50");

int sommaEs9 = 0;
int indexEs9 = 0;
int limiteEs9 = 50;
int[] arrEs9 = new int[limiteEs9 + 1];
while (sommaEs9 < limiteEs9)
{
    Console.Write($"dimmi il numero ({indexEs9 + 1}):  ");
    arrEs9[indexEs9] = Convert.ToInt32(Console.ReadLine());
    sommaEs9 = sommaEs9 + arrEs9[indexEs9];
    indexEs9++;
}


Console.WriteLine($"ok, abbiamo superato il limite di {limiteEs9} ");
Console.WriteLine($"tecnicamente siamo arrivati a {sommaEs9} ");



Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");

//Random
//    10. Fai inserire un numero, che chiameremo N, all’utente.

Console.Write($"inserisci un numero N = ");
int N = Convert.ToInt32(Console.ReadLine());
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
int topEs10 = 10;
Random rnd = new Random();

for (int i = 0; i < N; i++)
{
    Console.WriteLine($"array {i + 1}:");
    int[] array = new int[topEs10];

    for (int j = 0; j < topEs10; j++)
    {
        array[j] = rnd.Next(100);

    }


    //Ogni volta che ne crei uno, stampalo a schermo.
    for (int j = 0; j < topEs10; j++)
    {


        Console.WriteLine($"{j + 1}: {array[j]}");
    }

    Console.WriteLine($"{Environment.NewLine}");
}




//Funzioni
//    11. Dare la possibilità di inserire due parole.
Console.WriteLine($"inserisci due parole");
int nParoleEs11 = 2;
string[] paroleEs11 = new string[nParoleEs11];

for ( int i = 0; i < nParoleEs11; i++ )
{
    paroleEs11[i] = Console.ReadLine();
}

//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
//Se hanno la stessa lunghezza, stamparle entrambe,
//altrimenti stampare la più lunga delle due.

bool uguaglianza(string parola1, string parola2)
{

    if (parola1.Length == parola2.Length)
    {
        return true;
    }
    else
    {
        return false;
    }

}

Console.WriteLine($"{Environment.NewLine}");
if (uguaglianza(paroleEs11[0], paroleEs11[1]))
{

    Console.WriteLine($"queste due parole hanno la stessa lunghezza:");
    Console.WriteLine($"{paroleEs11[0]}");
    Console.WriteLine($"{paroleEs11[1]}");
    Console.WriteLine($"{Environment.NewLine}");
    Console.WriteLine($"{Environment.NewLine}");
}
else
{

    Console.WriteLine($"queste due parole NON hanno la stessa lunghezza.");
    Console.WriteLine($"La più lunga é:");
    if (paroleEs11[0].Length > paroleEs11[1].Length)
    {
        Console.WriteLine($"{paroleEs11[0]}");
    }
    else
    {
        Console.WriteLine($"{paroleEs11[1]}");
    }
}


Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");

//    12. Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari. 

bool parita(int input)
{
    if(input % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine($"Dimmi un numero e ti dirò chi sei.");
Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"Scherzo, dimmi un numero e ti dirò se è pari o dispari");
int inputEs12 = 0;

int.TryParse(Console.ReadLine(), out inputEs12);


Console.WriteLine($"{Environment.NewLine}");

Console.Write($"{inputEs12} è ");


if (parita(inputEs12))
{

    Console.WriteLine($"pari");
}
else
{

    Console.WriteLine($"dispari");
}


Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");
Console.WriteLine($"{Environment.NewLine}");