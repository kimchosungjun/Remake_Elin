using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundState : PlayerState
{
    public PlayerGroundState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName) { }
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
        if(!player.GroundDetect())
            stateMachine.ChangeState(player.state[(int)PlayerStateNames.Air]);
        if (Input.GetKeyDown(KeyCode.LeftAlt) && player.CanRoll)
            stateMachine.ChangeState(player.state[(int)PlayerStateNames.Roll]);
        if (Input.GetKey(KeyCode.Space) && player.GroundDetect())
            stateMachine.ChangeState(player.state[(int)PlayerStateNames.Jump]);
    }
}
