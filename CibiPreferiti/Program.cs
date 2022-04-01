string[] cibiPrefe = {"lasagna", "pizza", "pollo in salsa agrodolce", "patatine fritte", "hamburger", "torta al cioccolato" };

Console.WriteLine("I miei cibi preferiti sono: " + cibiPrefe.Length);

for(int i = 0; i < cibiPrefe.Length; i++)
{
    Console.WriteLine("Il mio " + (i + 1) + "° cibo preferito è: " + cibiPrefe[i]);
}

Console.WriteLine("Il cibo che preferisco più di tutti è: " + cibiPrefe[0]);

Console.WriteLine("Il cibo che preferisco ma non troppo è: " + cibiPrefe[cibiPrefe.Length - 1]);

int valoreMediano = (cibiPrefe.Length - 1) / 2;
if (cibiPrefe.Length%2 == 0)
{
    Console.WriteLine("I miei cibi preferiti nella posizione mediana sono: " + cibiPrefe[valoreMediano] + " e " + cibiPrefe[valoreMediano + 1]);
}
else
{
    Console.WriteLine("Il mio cibo preferito nella posizione mediana è: " + cibiPrefe[valoreMediano]);
}