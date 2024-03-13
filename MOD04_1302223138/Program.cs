namespace MOD04_1302223138
{
    public class KodeBuah
    {

        public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka };

        public static string getKode(Buah buah)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00" , "O00" };


            return kodeBuah[(int)buah];
        }

        static void Main(string[] agrs)
        {
            Buah buah = new Buah();
            Console.WriteLine("Nama Buah : " + Buah.Apel);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Apel));
            Console.WriteLine("Nama Buah : " + Buah.Aprikot);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Aprikot));
            Console.WriteLine("Nama Buah : " + Buah.Alpukat);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Alpukat));
            Console.WriteLine("Nama Buah : " + Buah.Pisang);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Pisang));
            Console.WriteLine("Nama Buah : " + Buah.Paprika);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Paprika));
            Console.WriteLine("Nama Buah : " + Buah.Blackberry);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Blackberry));
            Console.WriteLine("Nama Buah : " + Buah.Ceri);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Ceri));
            Console.WriteLine("Nama Buah : " + Buah.Kelapa);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Kelapa));
            Console.WriteLine("Nama Buah : " + Buah.Jagung);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Jagung));
            Console.WriteLine("Nama Buah : " + Buah.Kurma);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Kurma));
            Console.WriteLine("Nama Buah : " + Buah.Durian);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Durian));
            Console.WriteLine("Nama Buah : " + Buah.Anggur);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Anggur));
            Console.WriteLine("Nama Buah : " + Buah.Melon);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Melon));
            Console.WriteLine("Nama Buah : " + Buah.Semangka);
            Console.WriteLine("Kode Buah : " + getKode(Buah.Semangka));

        }

    }
}
public class posisiKarakterGame
{
    public enum gameState { Berdiri, Jongkok, Terbang, Tengkurap };

    public enum trigger { tombolW, tombolS, tombolX };

    static void Main(string[] agrs)
    {
        posisiKarakterGame.gameState kondisi = posisiKarakterGame.gameState.Berdiri;
        Console.WriteLine("Masukan Misi : ");
        string input = Console.ReadLine();
        while (input != "udahan") ;
        {
            switch (kondisi)
            {
                case gameState.Berdiri:
                    if (input == "S")
                    } Console.WriteLine("Tombol Arah Bawah Ditekan")
                      kondisi = gameState.Jongkok;
            }
        }
    }