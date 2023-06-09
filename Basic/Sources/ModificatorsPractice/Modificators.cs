namespace csharp_practice.Sources.ModificatorsPractice
{
    public class Modificators
    {
        public string Prop1 { get; set; }
        private string Prop2 { get; set; }
        protected string Prop3 { get; set; }

        public Modificators(string prop1, string prop2, string prop3)
        {
            this.Prop1 = prop1;
            this.Prop2 = prop2;
            this.Prop3 = prop3;
        }
    }
}
