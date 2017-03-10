/// <summary>
/// Calculated the formula for Gfr
/// </summary>
namespace CalvertFormulaWorkSheet
{
    public class GfrFormula : ICalculatable
    {
        public double Calculate(IFormulaDanni formulaDanni)
        {
            var gfr = formulaDanni as GfrModel;
        

            double coefcFemale = 1d;
            if (gfr.IsFemale)
            {
                coefcFemale = 0.85;
            }

            if (gfr.WeightOrPound.Equals("pounds"))
            {
                gfr.Weight = 0.45359237 * gfr.Weight;
            }

            double gfrResult = (140 - gfr.Age) * gfr.Weight * coefcFemale / (72 * gfr.SerumCreatinine);

            return gfrResult;
        }
    }
}