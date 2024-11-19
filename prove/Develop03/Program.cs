using System;

class Program
{
    static void Main(string[] args)
    {
        string book = "Genesis";
        int chapter = 1;
        int verse = 3;
        string text = "神 は 「光 あれ」 と 言われた。 する と 光 が あった。";
        Scripture scripture= new Scripture(book, chapter, verse, text);
        scripture.Display(scripture.reference, scripture.w);
        while (scripture.w.Empty() == false){
            string quit = Console.ReadLine();
            if (quit == "quit" | quit == "Quit" | quit == "QUIT"){
                break;
            }else{
                scripture.w.Conceal();
                scripture.Display(scripture.reference, scripture.w);
            }
        }
    }
}