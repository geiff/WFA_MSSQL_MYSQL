using System.Activities;
using ColumnGasStationMashine;

namespace WorkflowConsoleApplication1
{

    class Program
    {
        static void Main()
        {
            Activity workflow1 = new Workflow1();
            WorkflowInvoker.Invoke(workflow1);
        }
    }
}