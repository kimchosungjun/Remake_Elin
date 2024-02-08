using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState 
{
    protected PlayerStateMachine stateMachine;
    protected PlayerController player;
    protected Rigidbody2D rb;

    protected float xInput;
    private string animBoolName;
    protected float stateTimer=0.4f;
    public PlayerState(PlayerController _player, PlayerStateMachine _stateMachine, string _animBoolName)
    {
        this.player = _player;
        this.stateMachine = _stateMachine;
        this.animBoolName = _animBoolName;
        rb = player.rb;
    }

    public virtual void Enter() { player.anim.SetBool(animBoolName, true); }
    public virtual void Exit() { player.anim.SetBool(animBoolName, false); }
    public virtual void Update() 
    { 
        stateTimer -= Time.deltaTime;
        if (player.CanMove)
            xInput = Input.GetAxisRaw("Horizontal");
        else
            xInput = 0;
        player.anim.SetFloat("yVelocity", rb.velocity.y); 
    }
}
