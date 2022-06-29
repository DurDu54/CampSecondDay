namespace CampSecondDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişken tanımlama
        /*  
            String ad = "müco";
            int yası = 21;


            //döngü tanımlama
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(100);
            }
        */
            
            string adi = "engin";
            int yas = 31;
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "engin demiroğ";
            kurs1.izlenmeOranı = 78;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "kerem";
            kurs2.izlenmeOranı = 98;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay ";
            kurs3.izlenmeOranı = 54;

            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);
            //ilşk tipde dizi tanımlama

            Kurs[] kurslar = new Kurs[3];
            kurslar[0] = kurs1;
            kurslar[1] = kurs2;
            kurslar[2] = kurs3;
            //ikincişekil dizi tanımlama
            Kurs[] kurslar2 = new Kurs[] {kurs1,kurs2, kurs3};
            
            //forech dizi içinde gezme
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" "+kurs.Egitmen+" "
                    +kurs.izlenmeOranı);
                            
            }

            
        }
    }
}
class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int izlenmeOranı { get; set; }
}