using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallState : PlayerState
{
    public PlayerWallState(PlayerController _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName) { }

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
        player.SetVelocity(0, rb.velocity.y*0.9f);
        if(Input.GetKeyDown(KeyCode.Space) && player.CanMove)
        { stateMachine.ChangeState(player.state[(int)PlayerStateNames.WallJump]); return; }
        if (player.GroundDetect())
        { stateMachine.ChangeState(player.state[(int)PlayerStateNames.Idle]); return; }
    }
}
