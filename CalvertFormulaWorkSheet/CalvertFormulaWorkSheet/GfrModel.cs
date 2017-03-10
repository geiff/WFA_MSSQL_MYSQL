/// <summary>
/// Class that holds data for GFR formula
/// </summary>

namespace CalvertFormulaWorkSheet
{
    public class GfrModel : IFormulaDanni
    {
        public int Age { get; set; }

        public double Weight { get; set; }

        public string WeightOrPound { get; set; }

        public bool IsFemale { get; set; }

        public int SerumCreatinine { get; set; }
    }
}