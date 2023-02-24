namespace Classes
{
    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string CardNumber { get; set; }
        public readonly string CardType = "Humo";
        public static decimal ServiceRate { get; set; }
        public const string Provider = "Azizbek's Company";
    }
}
