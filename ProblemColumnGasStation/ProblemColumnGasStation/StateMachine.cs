 using System.Collections.Generic;
/// <summary>
/// The class holds dictionary that fill the possible transitions and object class with StateMachineModel
/// Reset Ready.
/// When creating an object of this class can change the current state of the object with a new if possible transition
/// Between the old and the new state.
/// </summary>
public class StateMachine
{
    public StateMachine()
    {
        StateMachineDictionary = LoadingOnDictionary();
        Machine = new StateMachineModel() {CurrentState = State.Ready};
    }
    private Dictionary<StateMachineModel, State> StateMachineDictionary { get; }
    public StateMachineModel Machine { get; set; }

    //Method that fills dictionary 
    public Dictionary<StateMachineModel, State> LoadingOnDictionary()  
    {    
        Dictionary<StateMachineModel, State> stateMachine = new Dictionary<StateMachineModel, State>();
        stateMachine.Add(new StateMachineModel() { CurrentState = State.Ready, CommandTransition = Transition.ReadyForBroken }, State.Broken);
        stateMachine.Add(new StateMachineModel() { CurrentState = State.Ready, CommandTransition = Transition.ReadyForFull}, State.Full);
        stateMachine.Add(new StateMachineModel() { CurrentState = State.Broken, CommandTransition = Transition.BrokenForReady }, State.Ready);
        stateMachine.Add(new StateMachineModel() { CurrentState = State.Full, CommandTransition = Transition.FullForBroken }, State.Broken);
        stateMachine.Add(new StateMachineModel() { CurrentState = State.Full, CommandTransition = Transition.FullForPayment }, State.Payment);
        stateMachine.Add(new StateMachineModel() { CurrentState = State.Payment, CommandTransition = Transition.PaymentForReady }, State.Ready);

        return stateMachine;
    }

    //Accepts current status and transition, and returns the final machine with the new state of play if possible and if not possible throwing error
    public StateMachineModel TransitionToNewState(State currentState, Transition command)   
    {
        StateMachineModel stateMachinewithNextState = new StateMachineModel();
        State nextState;
  
        if (!StateMachineDictionary.TryGetValue(Machine, out nextState))
        {    
            throw new KeyNotFoundException();
        }

        stateMachinewithNextState.CurrentState = nextState;

        return stateMachinewithNextState;
    }
}