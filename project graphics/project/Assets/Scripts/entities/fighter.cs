using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fighter : MonoBehaviour
{
   
    public static float max_health = 100f;
    public float healt = max_health;
    public string fightername;
    public fighter oponent;
    protected Animator animator;
    private Rigidbody mybody;

    // Use this for initialization
    void Start()
    {
        mybody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("health", healtpercent);
        if (oponent != null)
        {
            animator.SetFloat("oponent_health", oponent.healtpercent);
        }
        else
        {
            animator.SetFloat("oponent_health", 1);
        }
      
    }
    
    public float healtpercent
    {

        get
        {
            return healt / max_health;
        }
    }

    public Rigidbody body
    {
        get
        {
            return this.mybody;
        }
    }
}

