


Console.WriteLine("dammi il tuo nome");
string nome = Console.ReadLine();
Console.WriteLine("dammi il tuo cognome");
string cognome = Console.ReadLine();
Console.WriteLine("dammi la tua data di nascita");
string giorno = Console.ReadLine();
string mese = Console.ReadLine();
string anno = Console.ReadLine();
Console.WriteLine("di che sesso sei?");
string sesso = Console.ReadLine();
string codiceFiscale = " ";
char[] consonanti = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
char[] consonantiC = new char[3];
char[] vocaliC = new char[2];
int contaVocali = 0, contaConsonanti = 0;
for (int i = 0; i < nome.Length; i++)
{
    for (int j = 0; j < consonanti.Length; j++)
    {
        if (nome[i] == consonanti[j])
        {
            contaConsonanti++;
            if (consonantiC[i] == ' ')
            {
                consonantiC[i] = consonanti[j];
            }
            if (consonantiC[2] != ' ')
            {
                i = nome.Length;
            }

        }
    }
    for (int j = 0; j < vocali.Length; j++)
    {
        if (nome[i] == vocali[j])
        {
            contaVocali++;
            if (vocaliC[i] == ' ')
            {
                vocaliC[i] = vocali[j];
            }
            if (vocali[1] != ' ')
            {
                i = nome.Length;
            }

        }
    }
    //CREAZIONE DEL COGNOME
    if (contaConsonanti >= 3)
    {
        codiceFiscale += consonantiC[0] + consonantiC[1] + consonantiC[2];
    }
    else if (contaConsonanti == 2)
    {
        codiceFiscale += consonantiC[0] + consonantiC[1] + vocaliC[0];
    }
    else if (contaConsonanti == 1)
    {
        if (contaVocali == 1)
        {
            codiceFiscale += consonantiC[0] + vocaliC[0] + "x";
        }
        else if (contaVocali > 1)
        {
            codiceFiscale += consonantiC[0] + vocaliC[0] + vocaliC[1];
        }
    }
    else if (contaConsonanti == 0)
    {
        codiceFiscale += vocaliC[0] + vocaliC[1] + "x";
    }
}
// CREAZIONE DEL NOME
