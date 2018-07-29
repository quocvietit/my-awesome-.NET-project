using Web.Utils;
namespace Web.Models
{
    public class PasswordDetailModel
    {
        public string Password { get; set; }
        public int UpperCase { get; set; }
        public int LowerCase { get; set; }
        public int Digit { get; set; }
        public int Symbol { get; set; }
        public int SpaceDeth { get; set; }
        public int Length { get; set; }

        public PasswordDetailModel()
        {
            this.Password = null;
            this.UpperCase = 0;
            this.LowerCase = 0;
            this.Digit = 0;
            this.Symbol = 0;
            this.SpaceDeth = 0;
            this.Length = 0;

        }

        public void SetSpaceDeth()
        {
            this.SpaceDeth = 0;
            this.SpaceDeth += this.UpperCase > 0 ? Contants.Alphabet.SpaceDeth.UPPER_CASE : 0;
            this.SpaceDeth += this.LowerCase > 0 ? Contants.Alphabet.SpaceDeth.LOWER_CASE : 0;
            this.SpaceDeth += this.Digit > 0 ? Contants.Alphabet.SpaceDeth.DIGIT : 0;
            this.SpaceDeth += this.Symbol > 0 ? Contants.Alphabet.SpaceDeth.SYMBOL : 0;
        }
    }
}
