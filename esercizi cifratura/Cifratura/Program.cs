using Cifratura;
using System;

CifrarioCesare cifrarioCesare = new CifrarioCesare();

Console.WriteLine("che cifrario vuoi utilizzare?\n : 1) cifrario di Cesare\n 2)cifrario di Vigenère 3)Hashing MD5");
if (!(int.TryParse(Console.ReadLine(), out int cript)))
    Console.WriteLine("chiave non valida");
switch (cript)
{
    case 1:
        caso1();
        break;

    case 2:
        Console.WriteLine("da implementare");

    case 3:






}

void caso1()
{
    while (true)
    {
        Console.WriteLine("inserisci il testo : ");

        string? frase = Console.ReadLine();

        Console.WriteLine("inserisci la chiave : ");

        if (!(int.TryParse(Console.ReadLine(), out int chiave)))
            Console.WriteLine("chiave non valida");

        Console.WriteLine("vuoi cifrare o decifrare(c/d) : ");

        string? scelta = Console.ReadLine();

        if (scelta == "c")
            Console.WriteLine(cifrarioCesare.Cifra(frase, chiave));
        else if (scelta == "d")
            Console.WriteLine(cifrarioCesare.Decifra(frase, chiave));
        else
        {
            Console.WriteLine("inserisci una scelta valida");
            continue;
        }
    }
}

void caso2()
{

    Console.WriteLine("da implementare");
}

void caso3()
{




}


