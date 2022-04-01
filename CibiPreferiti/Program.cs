string[] cibiPrefe = {"lasagna", "pizza", "pollo in salsa agrodolce", "patatine fritte", "hamburger", "torta al cioccolato"};

Console.WriteLine("I miei cibi preferiti sono: " + cibiPrefe.Length);

for(int i = 0; i < cibiPrefe.Length; i++)
{
    Console.WriteLine("Il mio " + (i + 1) + "° cibo preferito è: " + cibiPrefe[i]);
}

Console.WriteLine("Il cibo che preferisco più di tutti è: " + cibiPrefe[0]);

Console.WriteLine("Il cibo che preferisco ma non troppo è: " + cibiPrefe[cibiPrefe.Length - 1]);