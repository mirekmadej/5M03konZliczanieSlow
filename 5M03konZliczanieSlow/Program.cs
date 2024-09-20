namespace _5M03konZliczanieSlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lorem = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            string lorem2 = lorem.ToLower();

            Dictionary<string,int> slowa = new Dictionary<string,int>();
            //usuwamy znaki . oraz ,
            lorem2 = lorem2.Replace(',', ' ');
            lorem2 = lorem2.Replace('.', ' ');
            
            //dzielimy string na słowa 
            string[] lista = lorem2.Split(' ');
            

            //zliczamy slowa
            foreach (string s in lista)
            {
                if (s.Length == 0)
                    continue;
                //Console.WriteLine(s);
                if (slowa.ContainsKey(s))
                    slowa[s]++;
                else
                    slowa.Add(s, 1);
            }

            //wynik
            foreach(string k in slowa.Keys)
                Console.WriteLine($"{k}: {slowa[k]}");


        }
    }
}
