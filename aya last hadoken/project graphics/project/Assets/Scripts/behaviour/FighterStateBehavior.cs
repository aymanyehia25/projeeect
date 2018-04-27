using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterStateBehavior : StateMachineBehaviour {

    public fighterState behavoiurState;
    public AudioClip SoundEffect;
    public float horizontalForce;
    public float verticalForce;


    protected fighter Fighter;

    override public void OnStateEnter(Animator animator , AnimatorStateInfo stateInfo , int layerIndex)
    {
        if (Fighter == null)
        {
            Fighter = animator.gameObject.GetComponent<fighter>();
        }
        Fighter.currentState = behavoiurState;
        if(SoundEffect != null)
        {
            Fighter.playsound(SoundEffect);
        }
        Fighter.body.AddRelativeForce(new Vector3(0,verticalForce,0));
    }

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Fighter.body.AddRelativeForce(new Vector3(0, 0, horizontalForce));
    }
}
