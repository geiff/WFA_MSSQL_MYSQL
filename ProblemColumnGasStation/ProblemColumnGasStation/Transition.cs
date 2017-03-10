/// <summary>
/// Transitions
/// </summary>
public enum Transition
{
    ReadyForBroken = 1,
    ReadyForFull = 2,
    FullForBroken = 1,
    FullForPayment = 3,
    PaymentForReady = 4,
    BrokenForReady = 4
}