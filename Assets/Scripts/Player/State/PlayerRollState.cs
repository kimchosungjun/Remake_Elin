using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRollState : PlayerState
{
    public PlayerRollState(PlayerController _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName) { }

    public override void Enter()

    {
        base.Enter();
        stateTimer = player.rollDuration;
    }

    public override void Exit()
    {
        base.Exit();
        player.SetVelocity(0, rb.velocity.y);
        player.rollGauge = 2f;
    }

    public override void Update()
    {
        base.Update();
        player.SetVelocity(player.rollSpeed * player.moveDir, rb.velocity.y);
        if (stateTimer < 0)
            stateMachine.ChangeState(player.state[(int)PlayerStateNames.Idle]);
    }
}
