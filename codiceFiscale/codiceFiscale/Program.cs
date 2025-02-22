


Console.WriteLine("dammi il tuo nome");
string nome = Console.ReadLine();
Console.WriteLine("dammi il tuo cognome");
string cognome = Console.ReadLine();
Console.WriteLine("dammi la tua data di nascita");
string data = Console.ReadLine();
Console.WriteLine("di che sesso sei?");
string sesso = Console.ReadLine();
string codiceFiscale = " ";
char[] consonanti = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
char[] consonantiC = new char[3];
char[] consonantiN = new char[3];
char[] vocaliN = new char[2];
char[] vocaliC = new char[2];
int contaVocali = 0, contaConsonanti = 0;
//CREAZIONE DEL COGNOME
for (int i = 0; i < cognome.Length; i++)
{
    for (int j = 0; j < consonanti.Length; j++)
    {
        if (cognome[i] == consonanti[j])
        {
            contaConsonanti++;
            if (consonantiC[i] == ' ')
            {
                consonantiC[i] = consonanti[j];
            }
            if (consonantiC[2] != ' ')
            {
                i = cognome.Length;
            }

        }
    }
    for (int j = 0; j < vocali.Length; j++)
    {
        if (cognome[i] == vocali[j])
        {
            contaVocali++;
            if (vocaliC[i] == ' ')
            {
                vocaliC[i] = vocali[j];
            }
            if (vocali[1] != ' ')
            {
                i = cognome.Length;
            }

        }
    }
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
contaConsonanti = 0; contaVocali = 0;
int giorni;
for (int i = 0; i < nome.Length; i++)
{
    for (int j = 0; j < consonanti.Length; j++)
    {
        if (nome[i] == consonanti[j])
        {
            contaConsonanti++;
            if (consonantiN[i] == ' ')
            {
                consonantiN[i] = consonanti[j];
            }
            if (consonantiN[2] != ' ')
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
            if (vocaliN[i] == ' ')
            {
                vocaliN[i] = vocali[j];
            }
            if (vocali[1] != ' ')
            {
                i = nome.Length;
            }

        }
        if (contaConsonanti >= 4)
        {
            codiceFiscale += consonantiN[0] + consonantiN[2] + consonantiN[3];
        }
        else if (contaConsonanti == 3)
        {
            codiceFiscale += consonantiN[0] + consonantiN[1] + consonantiN[2];
        }
        else if(contaConsonanti == 2)
        {
            codiceFiscale += consonantiN[0] + consonantiN[1] + vocaliN[0];
        }
        else if (contaConsonanti == 1)
        {
            if (contaVocali == 2)
            {
                codiceFiscale += consonantiN[0] + vocaliN[0] + vocaliN[1];
            }
            else if (contaVocali == 1)
            {
                codiceFiscale += consonantiN[0] + vocaliN[0] + "x";
            }
        }
        else if (contaConsonanti == 0)
        { 
            codiceFiscale+= vocaliN[0] + vocaliN[1]+ "x";
        }
    }
}
string[] dataSeparata;
// MESE
dataSeparata = data.Split("/");
if (dataSeparata[1] == "01")
{
    dataSeparata[1] = "A";
}
else if (dataSeparata[1] == "02")
{
    dataSeparata[1] = "B";
}
else if (dataSeparata[1] == "03")
{
    dataSeparata[1] = "C";
}
else if (dataSeparata[1] == "04")
{
    dataSeparata[1] = "D";
}
else if (dataSeparata[1] == "05")
{
    dataSeparata[1] = "E";
}
else if (dataSeparata[1] == "06")
{
    dataSeparata[1] = "H";
}
else if (dataSeparata[1] == "07")
{
    dataSeparata[1] = "L";
}
else if (dataSeparata[1] == "08")
{
    dataSeparata[1] = "M";
}
else if (dataSeparata[1] == "09")
{
    dataSeparata[1] = "P";
}
else if (dataSeparata[1] == "10")
{
    dataSeparata[1] = "R";
}
else if (dataSeparata[1] == "11")
{
    dataSeparata[1] = "S";
}
else if (dataSeparata[1] == "12")
{
    dataSeparata[1] = "T";
}
codiceFiscale += dataSeparata[1];
// SESSO
if(sesso == "femmina")
{
    int.Parse(dataSeparata[0] += 40);
    codiceFiscale += dataSeparata[0];
}
else
{
    codiceFiscale += dataSeparata[0];
}
Console.WriteLine(codiceFiscale);