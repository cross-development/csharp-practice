namespace csharp_practice.Sources.GenericsPractice
{
    public class Person<P, A>
    {
        public P PhoneNumber { get; set; }
        public A AccountNumber { get; set; }
    }

    public class PhoneNumber {
        public string Country { get; set; }
        
        public int Code { get; set; }
        
        public string Number { get; set; }
        
        public override string ToString( )
        {
            return $"Country: {this.Country}, Code: {this.Code}, Number: {this.Number}";
        }
    }
}