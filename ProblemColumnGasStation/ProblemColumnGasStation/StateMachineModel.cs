/// <summary>
/// This class describes the model of the finite state machine,
/// Which has two properties: current status and command (transition).
/// </summary>
public class StateMachineModel
{
    public State CurrentState { get; set; }
    public Transition CommandTransition { get; set; }

    //Override method GetHashCode(), because I want hash code of the object to me is the sum of the hash codes of the two properties.
    public override int GetHashCode()
    {
        return this.CurrentState.GetHashCode() + this.CommandTransition.GetHashCode();
    }

    //Override method Equals(),to say how can I compare two objects of class StateMachineModel.
    public override bool Equals(object obj)
    {
        StateMachineModel other = obj as StateMachineModel;
        return this.CurrentState == other.CurrentState && this.CommandTransition == other.CommandTransition;
    }
}