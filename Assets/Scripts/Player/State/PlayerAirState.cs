using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerState
{
    public PlayerAirState(PlayerController _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        if(player.WallDetect() && xInput!=0)
        { stateMachine.ChangeState(player.state[(int)PlayerStateNames.Wall]); return; }
        if(player.GroundDetect())
            stateMachine.ChangeState(player.state[(int)PlayerStateNames.Idle]);
        if (xInput != 0)
            player.SetVelocity(player.moveSpeed * 0.8f * xInput, rb.velocity.y);
    }
}
