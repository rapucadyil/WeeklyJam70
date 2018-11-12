using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Requires
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(SpriteRenderer))]
#endregion

public class Character : MonoBehaviour {
    #region IVARS
    [SerializeField] private float maxHealth;
    [SerializeField] private float minhealth;
    [SerializeField] private float currHealth;
    #endregion

    #region Component References
    public Rigidbody2D ref_rgbdy;
    public Animator ref_anim;
	public MovementHandler ref_movement;
	public AnimationHandler ref_animation;
    #endregion

    #region Getters and Setters 
    public float MaxHealth
    {
        get
        {
            return this.maxHealth;
        }

        set
        {
            this.maxHealth = value;
        }
    }
    public float MinHealth
    {
        get
        {
            return this.minhealth;
        }

        set
        {
            this.minhealth = value;
        }
    }
    public float CurrHealth
    {
        get
        {
            return this.currHealth;
        }

        set
        {
            this.currHealth = value;
        }
    }
    #endregion

    private void Start()
    {
        this.gameObject.tag = "Player";
        maxHealth = 500;
        minhealth = 0;
        currHealth = 500;
		ref_movement = GetComponent<MovementHandler> ();
		ref_rgbdy = GetComponent<Rigidbody2D> ();
		ref_animation = GetComponent<AnimationHandler> ();
    }

    private void Update()
    {
		if (Input.GetKey (KeyCode.D))
			ref_animation.setDir (1);
		if (Input.GetKey (KeyCode.A))
			ref_animation.setDir (-1);
		ref_animation.HandleAnimation(GetComponent<SpriteRenderer>());
		ref_movement.HandleMovement (ref_rgbdy);
    }
}
