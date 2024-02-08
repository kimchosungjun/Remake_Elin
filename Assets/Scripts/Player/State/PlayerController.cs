using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Move Info")]
    public float moveSpeed = 12f;
    public float jumpSpeed = 12f;
    public float rollSpeed = 15f;
    public float rollGauge = 2f;
    public float rollDuration = 0.4f;
    public int moveDir { get; private set; } = 0;
    public bool LookLeft { get; private set;} = false;
    public bool CanRoll { get; private set; } = true;
    public bool CanMove { get; set; } = true;

    [Header("Collision Info")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private Transform groundCheckTransform;
    [SerializeField] private float wallCheckDistance;
    [SerializeField] private Transform wallCheckTransform;

    #region Component
    public PlayerState[] state;
    public Animator anim { get; private set; }
    public Rigidbody2D rb { get; private set; }
    public SpriteRenderer spr { get; private set; }
    public PlayerStateMachine stateMachine { get; private set; }
    #endregion

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spr = GetComponentInChildren<SpriteRenderer>();
        stateMachine = new PlayerStateMachine();
        state = new PlayerState[(int)PlayerStateNames.Max + 1];
        state[(int)PlayerStateNames.Idle] = new PlayerIdleState(this, stateMachine, "Idle");
        state[(int)PlayerStateNames.Move] = new PlayerMoveState(this, stateMachine, "Move");
        state[(int)PlayerStateNames.Jump] = new PlayerJumpState(this, stateMachine, "Jump");
        state[(int)PlayerStateNames.Air] = new PlayerAirState(this, stateMachine, "Jump");
        state[(int)PlayerStateNames.Roll] = new PlayerRollState(this, stateMachine, "Roll");
        state[(int)PlayerStateNames.Wall] = new PlayerWallState(this, stateMachine, "Wall");
        state[(int)PlayerStateNames.WallJump] = new PlayerWallJumpState(this, stateMachine, "Jump");
    }

    private void Start() { stateMachine.Initialize(state[(int)PlayerStateNames.Idle]); }

    private void Update() 
    {
        stateMachine.currentState.Update(); 
        if(rollGauge > 0) 
            rollGauge -= Time.deltaTime; 
        CanRoll = (rollGauge > 0) ? false : true; 
    }

    public void SetVelocity(float _xVelocity, float _yVelocity) { rb.velocity = new Vector2(_xVelocity, _yVelocity);  FlipControl(_xVelocity);}

    public bool GroundDetect() => Physics2D.Raycast(groundCheckTransform.position, Vector2.down, groundCheckDistance, groundLayer);
    public bool WallDetect() => Physics2D.Raycast(wallCheckTransform.position, Vector2.right * moveDir, wallCheckDistance, groundLayer);

    public void Flip() { LookLeft = !LookLeft; spr.flipX = LookLeft; moveDir = (LookLeft) ? -1 : 1; } 

    public void FlipControl(float _xVelocity)
    {
        if (_xVelocity < 0 && !LookLeft)
            Flip();
        else if (_xVelocity > 0 && LookLeft)
            Flip();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(groundCheckTransform.position, new Vector3(groundCheckTransform.position.x, groundCheckTransform.position.y - groundCheckDistance));
        Gizmos.color = Color.red;
        Gizmos.DrawLine(wallCheckTransform.position, new Vector3(wallCheckTransform.position.x+wallCheckDistance, wallCheckTransform.position.y));
    }
}
