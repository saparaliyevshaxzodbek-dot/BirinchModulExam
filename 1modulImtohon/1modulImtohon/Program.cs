namespace _1modulImtohon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-misol
            //List<int> list = new List<int>() { 1, 2, 3, 4};
            //Console.WriteLine($"Juft elementlar miqdori : {Counter(list)}");

            //2-misol
            //List<string> list = new List<string>() { "salom", "mashina"};
            //Console.WriteLine(Tekshir(list));

            ////3-misol
            //Console.WriteLine(Text("salom"));

            //4-misol
            //Console.WriteLine(Tekshir("PDP Hello"));

            //6-misol
            //List<int> list = new List<int>() {1, 2, 3, 4 };
            //Console.WriteLine(Summa(list));

            //5-misol
            Console.WriteLine(Tekshir("Salom G13"));

        }

        //1-misol
        //static int Counter(List<int> number)
        //{
        //    var sum = 0;

        //    foreach(int i in number)
        //    {
        //        if(i % 2  == 0)
        //        {
        //            sum++; 
        //        }
        //    }
        //    return sum;
        //}


        //2-misol
        //static bool Tekshir(List<string> text)
        //{

        //    var counter1 = 0;
        //    var counter2 = 0;

        //    foreach(string str in text)
        //    {
        //        if(str.Length > 5)
        //        {
        //            counter1++;
        //        } else
        //        {
        //            counter2++;
        //        }
        //    }

        //    return counter2 == 0;


        //}


        //3-misol
        //static string Text (string str)
        //{
        //    var res = str.Substring(0, 3);
        //    return res;
        //}



        //4-misol
        //static bool Tekshir (string text)
        //{
        //    var res = text.Substring(0, 3);

        //    return res == "PDP";
        //}


        //6-misol
        //static int Summa (List<int> num)
        //{
        //    var sum = 0;
        //    for(int i = 0; i < 2; i++)
        //    {
        //        sum = sum + num[i];
        //    }

        //    return sum;
        //}


        //5-misol
        static bool Tekshir(string text)
        {
           if(text.Contains("G13"))
            {
                return true;
            }

            return false;
        }



    }
}
