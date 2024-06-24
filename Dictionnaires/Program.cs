namespace Dictionnaires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> dico = new Dictionary<char, string>();
            dico['a'] = "Je";
            dico['b'] = "suis";
            dico['c'] = "une string";
            dico.Remove('c');
        }
    }
}
