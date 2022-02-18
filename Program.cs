using System;

public class Program
{
    public enum Kierunek : int
    {
        polnoc = 0,
        poludnie = 1,
        zachod = 2,
        wschod = 3


    }
    public static void Main()
    {
        int polnoc = 0;
        int poludnie = 0;
        int zachod = 0;
        int wschod = 0;
        
        int n = int.Parse(Console.ReadLine());
        string[][] wyniki = new string[n][];
        for (int i = 0; i < n; i++)
        {

            int m  = int.Parse(Console.ReadLine());
            wyniki[i] = new string[2];
            polnoc = 0;
            poludnie = 0;
            zachod = 0;
            wschod = 0;
            for (int j = 0; j < m; j++)
            {
                string[] s = Console.ReadLine().Split();
                Kierunek kier = (Kierunek)int.Parse(s[0]);
                switch (kier)
                {
                    case Kierunek.polnoc:
                        polnoc += int.Parse(s[1]);
                        break;
                    case Kierunek.poludnie:
                        poludnie += int.Parse(s[1]);
                        break;
                    case Kierunek.zachod:
                        zachod += int.Parse(s[1]);
                        break;
                    case Kierunek.wschod:
                        wschod += int.Parse(s[1]);
                        break;


                }
                
            }
            if ((polnoc - poludnie == 0)&&(zachod - wschod == 0))
            {
                wyniki[i][0] = "studnia";
                wyniki[i][1] = null;
                continue;

            }
            
            
            if ((polnoc - poludnie) > 0)
            {
                wyniki[i][0] = "0 " + (polnoc - poludnie);
            }
            else if((polnoc - poludnie) == 0)
            {
                wyniki[i][0] = null;
            }
            else
            {
                wyniki[i][0] = "1 " + Math.Abs(polnoc - poludnie);
            }

            if ((zachod - wschod) > 0)
            {
                wyniki[i][1] = "2 " + (zachod - wschod);
            }
            else if ((zachod - wschod) == 0)
            {
                wyniki[i][1] = null;
            }
            else
            {
                wyniki[i][1] = "3 " + Math.Abs(zachod - wschod);
            }

            

        }

        for(int i = 0; i < n; i++)
        {
           
           Console.WriteLine(wyniki[i][0]);
            if (wyniki[i][0] != "studnia")
            {
                Console.WriteLine(wyniki[i][1]);
            }
        }
    }
}
