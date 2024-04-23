using System.Text.Json;
namespace CsFileStreamFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clothes clothes = new Clothes
            {
                Marka = "Vasmoy",
                Model = "Satici ozu de bilmir",
                Say = 321,
                Type = "Shalvar",
                Price=15

            };
            string fileName = "Clothes.json";
            string jsonstr=JsonSerializer.Serialize(clothes);
            File.WriteAllText(fileName, jsonstr);
            Console.WriteLine(File.ReadAllText(fileName));

        }
    }
    public class Clothes
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Say { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
