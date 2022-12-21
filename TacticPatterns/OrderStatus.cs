namespace TacticPatterns
{
    public enum OrderStatus
    {
        Draft,
        Validating,
        Created,
        CreatedInTheDeliveryService,
        Sent,
        InTheIntermediateWarehouse,
        WaitingForPickingUp,
        Cancelled,
        PickedUp
    }
}