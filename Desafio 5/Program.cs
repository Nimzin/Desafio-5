public class Program
{
    public static void Main()
    {
        string palavra = "Target Sistemas";      
        string palavraInvertida = Inverter(palavra);


        Console.WriteLine($"Palavra normal: {palavra}");
        Console.WriteLine($"Palavra invertida: {palavraInvertida}");
    }

    public static string Inverter(string input) 
    {
        char [] chars = new char[input.Length];  //array de caracteres do mesmo tamanho da string

        for (int i = 0; i <input.Length; i++) //percorrer a string de tras p frente.
        {
            chars[i] = input[input.Length - 1 -i]; //inversao do caractere
        }
        return new string(chars); //conversao do array em string
    }
}