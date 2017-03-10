/// <summary>
/// Calculated Calvert Formula
/// </summary>


namespace CalvertFormulaWorkSheet
{
    public class AucFormula : ICalculatable
    {
        //Keep result of GFR formula
        public readonly double GFR_RESULT;

        //Dependency injection
        public AucFormula(GfrFormula gfrFormula, AucModel aucModel)
        {
            this.GfrFormula = gfrFormula;
            this.AucModel = aucModel;
            GFR_RESULT = GfrFormula.Calculate(this.AucModel.GfrModel);
        }

        public GfrFormula GfrFormula { get; set; }
        public AucModel AucModel { get; set; }

        public double Calculate(IFormulaDanni danni)
        {
            this.AucModel = danni as AucModel;

            double aucResult = (GFR_RESULT + 25) * this.AucModel.Target;

            return aucResult;
        }
    }
}