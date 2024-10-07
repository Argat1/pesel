namespace pesel
{
    internal class Program
    {

            
    


    static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj pesel");

            string pesel = Console.ReadLine();

            if (pesel.Length != 11)
            {
                Console.WriteLine("Podano niepoprawny pesel");
            }
            else
            {
                CheckSex(pesel);
                Console.WriteLine("Zgodność sumy kontrolnej:" + ControlNumberCheck(pesel));
            }


        }

        string peselDefault = "00000000000";



        public static void CheckSex(string pesel)
        {
            var sexId = "";
            for (int i = 0; i < pesel.Length; i++)
            {
                if (i == 9)
                {
                    sexId = pesel[i].ToString();
                    break;
                }
            }

            if (int.Parse(sexId) % 2 == 1)
            {
                Console.WriteLine("Male");
            }
            else
            {
                Console.WriteLine("Female");
            }
        }

        public static bool ControlNumberCheck(string pesel)
        {
            string firstTenLetters = string.Empty;
            string lastLetter = string.Empty;

            int iloczynLiczb = 0;
            int S = 0;
            int R = 0;
            int M = 0;
            int i = 0;

            while (i != 9)
            {
                firstTenLetters += pesel[i].ToString();
                i++;
            }

            for (int j = 0; j < firstTenLetters.Length; j++)
            {
                if (firstTenLetters[j].ToString() == "1" || firstTenLetters[j].ToString() == "5" || firstTenLetters[j].ToString() == "9")
                {
                    iloczynLiczb = int.Parse(firstTenLetters[j].ToString()) * 1;
                    S += iloczynLiczb;
                }

                if (firstTenLetters[j].ToString() == "2" || firstTenLetters[j].ToString() == "6" || firstTenLetters[j].ToString() == "10")
                {
                    iloczynLiczb = int.Parse(firstTenLetters[j].ToString()) * 3;
                    S += iloczynLiczb;
                }

                if (firstTenLetters[j].ToString() == "3" || firstTenLetters[j].ToString() == "7")
                {
                    iloczynLiczb = int.Parse(firstTenLetters[j].ToString()) * 7;
                    S += iloczynLiczb;
                }

                if (firstTenLetters[j].ToString() == "4" || firstTenLetters[j].ToString() == "8")
                {
                    iloczynLiczb = int.Parse(firstTenLetters[j].ToString()) * 9;
                    S += iloczynLiczb;
                }
            }

            for (int x = 0; x < pesel.Length; x++)
            {
                if (x == 10)
                {
                    lastLetter = pesel[x].ToString();
                    break;
                }
            }

            M = S % 10;

            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }

            if (int.Parse(lastLetter) == R)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
