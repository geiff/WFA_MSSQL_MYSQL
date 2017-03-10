/// <summary>
/// Class that holds data for Auc formula
/// </summary>

namespace CalvertFormulaWorkSheet
{
   public class AucModel : IFormulaDanni
    { 
       public AucModel()
       {
           this.GfrModel = new GfrModel();
       }
       public GfrModel GfrModel { get; set; }
       public int Target { get; set; }
    }
}