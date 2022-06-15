public delegate void MovementDelegate(float inputX, float inputY, bool isWalking, bool isRunning,bool isIdle, bool carring, ToolEffect toolEffect,
                                     bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
                                     bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
                                     bool isPickingToolRight, bool isPickingToolLeft, bool isPickingToolUp, bool isPickingToolDown,
                                     bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
                                     bool isIdleRight, bool isIdleLEft, bool isIdleUp, bool isIdleDown);

public static class EventHandler
{
    public static event MovementDelegate MovementEvent;
    public static void CallMovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool carring, ToolEffect toolEffect,
                                     bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
                                     bool isLiftingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
                                     bool isPickingToolRight, bool isPickingToolLeft, bool isPickingToolUp, bool isPickingToolDown,
                                     bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
                                     bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown)
    {
        if (MovementEvent != null)
        {
            MovementEvent.Invoke(inputX, inputY, isWalking, isRunning, isIdle, carring, toolEffect,
                                     isUsingToolRight, isUsingToolLeft, isUsingToolUp, isUsingToolDown,
                                     isLiftingToolRight, isLiftingToolLeft, isLiftingToolUp, isLiftingToolDown,
                                     isPickingToolRight, isPickingToolLeft, isPickingToolUp, isPickingToolDown,
                                     isSwingingToolRight, isSwingingToolLeft, isSwingingToolUp, isSwingingToolDown,
                                     isIdleRight, isIdleLeft, isIdleUp, isIdleDown);
        }
    }
}
