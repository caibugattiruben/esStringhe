using System.Security.Cryptography;

int num(string numero)
{
    int s = 0,cont=numero.Length-1;
    for (int i = 0; i < numero.Length; i++)
    {
        if (numero[i] == '1')
        {
            s +=(int) Math.Pow(2,cont);
        }
        cont--;
    }
    return s;
}
string fras(string[] frase)
{
    string frase1 = "";
    for(int i = 0; i < frase.Length; i++)
    {
        if (frase[i]!="")
        {
            frase1 += frase[i]+" ";
        }  
    }
    return frase1;
}
void SpezzaMeta(string s)
{
    Console.WriteLine(s.Substring(0,s.Length/2));
    Console.WriteLine(s.Substring(s.Length / 2));
}
bool palindroma(string s)
{
    string VF = s;
    int p = VF.Length-1 ;
    for(int i = 0; i < VF.Length; i++)
    {
        if (s[i] != VF[p])
        {
            return false;
        }
        if (i > s.Length / 2)
        {
            return true;
        }
        p--;
    }
    return false;
}
string numero = "";
Console.WriteLine("dimmi il numero binario(max lung 8, se superi 8 cifre, le cifre eccessive verranno eliminate)");
numero = Console.ReadLine();
numero = numero.Trim();
numero = numero.Substring(0,Math.Min(8,numero.Length));
int s = num(numero);
Console.WriteLine(s);
Console.WriteLine("dimmi la frase da aggiustare");
string frase = Console.ReadLine();
frase = frase.Trim();
string[] frase1 = frase.Split(" ");
Console.WriteLine(fras(frase1));
Console.WriteLine("dimmi la frase da spezzare");
string ok = Console.ReadLine();
ok = ok.Trim();
SpezzaMeta(ok);
Console.WriteLine("dammi la parola per verificare se è palindroma");
string stringa=Console.ReadLine();
Console.WriteLine(palindroma(stringa));
