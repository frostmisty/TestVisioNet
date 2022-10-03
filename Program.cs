

namespace Program
{
    class Program
    {
        static void Main(string[] strings)
        {
            //Task1();
            Task2();
        }
        //untuk soal nomor 1
        static void Task1()
        {
            string masukan = "";
            int leng = 0;
            
            string[] valarr =new string[2];
            Console.Write("Masukan Inputan : ");
            masukan = Console.ReadLine().ToUpper();
            double d = masukan.Length / 2;
            leng = (int)Math.Floor(d);
            valarr[0] = masukan.Substring(0, leng);
            valarr[1] = masukan.Substring(masukan.Length-leng,leng);
            string aa = String.Concat(valarr[0].OrderByDescending(x => x));
            string bb = String.Concat(valarr[1].OrderByDescending(x => x));
            Console.WriteLine("Nilai Output = " + aa + bb);
        }

        //untuk soal nomor  2
        static void  Task2()
        {
            int jumlaharr = 0;
            
            Console.Write("Masukan jumlah = ");
            jumlaharr = Convert.ToInt16(Console.ReadLine());

            string[] firstword = new string[jumlaharr];
            string[] secondword = new string[jumlaharr];
            string output = "";
            Console.WriteLine("============== Input First Word ==============");
            for (int i = 0; i < jumlaharr; i++)
            {
                Console.Write(String.Format("Masukan FirstWord{0} = ", i + 1));
                firstword[i] = Console.ReadLine();
            }
            Console.WriteLine("============== Input Second Word ==============");
            for (int i = 0; i < jumlaharr; i++)
            {
                Console.Write(String.Format("Masukan secondWord{0} = ", i + 1));
                secondword[i] = Console.ReadLine();
            }
            for(int i = 0; i < firstword.Length; i++)
            {
                string aa = String.Concat(firstword[i].OrderBy(x => x));
                string bb = String.Concat(secondword[i].OrderBy(x => x));
                if(aa == bb)
                {
                    output = output + "1";
                }
                else
                {
                    output = output + "0";
                }
            }
            Console.WriteLine("Hasil Anagram = " + output);
        }
    }
}