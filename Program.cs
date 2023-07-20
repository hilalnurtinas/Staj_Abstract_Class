

namespace AbstractOrnek
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Canli canli1 = new Canli(); //hata vermesinin sebebi abstract classların nesnesi olusturulmaz
            Kedi kedi = new Kedi();
            Kopek kopek = new Kopek();

            kedi.Konus();
            kopek.Konus();

            kedi.Tanit();

        }
    }

}
