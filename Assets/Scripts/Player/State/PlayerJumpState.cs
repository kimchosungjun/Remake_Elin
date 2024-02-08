using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpState : PlayerState
{
    public PlayerJumpState(PlayerController _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName) { }
    public override void Enter()
    {
        base.Enter();
        rb.velocity = new Vector2(rb.velocity.x, player.jumpSpeed);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();
        //if (player.WallDetect())
        //{ stateMachine.ChangeState(player.state[(int)PlayerStateNames.Wall]); return; }
        if (rb.velocity.y < 0)
            stateMachine.ChangeState(player.state[(int)PlayerStateNames.Air]);
    }
}
