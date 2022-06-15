using UnityEngine;

public class MovementAnimationParameterControl : MonoBehaviour
{
    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        EventHandler.MovementEvent += EventHandler_MovementEvent;
    }

    private void EventHandler_MovementEvent(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool carring,
        ToolEffect toolEffect, bool isUsingToolRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown, bool isLiftingToolRight,
        bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown, bool isPickingToolRight, bool isPickingToolLeft,
        bool isPickingToolUp, bool isPickingToolDown, bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp,
        bool isSwingingToolDown, bool isIdleRight, bool isIdleLeft, bool isIdleUp, bool isIdleDown)
    {
        animator.SetFloat(Settings.xInput, inputX);
        animator.SetFloat(Settings.yInput, inputY);
        animator.SetBool(Settings.isWalking, isWalking);
        animator.SetBool(Settings.isRunning, isRunning);

        animator.SetInteger(Settings.toolEffect, (int)toolEffect);

        if (isUsingToolRight)
            animator.SetTrigger(Settings.isUsingToolRight);
        if (isUsingToolLeft)
            animator.SetTrigger(Settings.isUsingToolLeft);
        if (isUsingToolUp)
            animator.SetTrigger(Settings.isUsingToolUp);
        if (isUsingToolDown)
            animator.SetTrigger(Settings.isUsingToolDown);

        if (isPickingToolRight)
            animator.SetTrigger(Settings.isPickingRight);
        if (isPickingToolLeft)
            animator.SetTrigger(Settings.isPickingLeft);
        if (isPickingToolUp)
            animator.SetTrigger(Settings.isPickingUp);
        if (isPickingToolDown)
            animator.SetTrigger(Settings.isPickingDown);

        if (isSwingingToolRight)
            animator.SetTrigger(Settings.isSwingingToolRight);
        if (isSwingingToolLeft)
            animator.SetTrigger(Settings.isSwingingToolLeft);
        if (isSwingingToolUp)
            animator.SetTrigger(Settings.isSwingingToolUp);
        if (isSwingingToolDown)
            animator.SetTrigger(Settings.isSwingingToolDown);

        if (isLiftingToolRight)
            animator.SetTrigger(Settings.isLiftingToolRight);
        if (isLiftingToolLeft)
            animator.SetTrigger(Settings.isLiftingToolLeft);
        if (isLiftingToolUp)
            animator.SetTrigger(Settings.isLiftingToolUp);
        if (isLiftingToolDown)
            animator.SetTrigger(Settings.isLiftingToolDown);

        if (isIdleRight)
            animator.SetTrigger(Settings.idleRight);
        if (isIdleLeft)
            animator.SetTrigger(Settings.idleLeft);
        if (isIdleUp)
            animator.SetTrigger(Settings.idleUp);
        if (isIdleDown)
            animator.SetTrigger(Settings.idleDown);

    }

    private void OnDisable()
    {
        EventHandler.MovementEvent -= EventHandler_MovementEvent;
    }
    public void AnimationEventPlayFootstepSound()
    {

    }
}
