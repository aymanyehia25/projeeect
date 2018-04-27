using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hadookenstatebehavoir : FighterStateBehavior
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        float fighterx = Fighter.transform.position.x;
        GameObject instance = Object.Instantiate(
            Resources.Load("sfx/Hadoken"),
            new Vector3(fighterx, 1, 0),
            Quaternion.Euler(0, 0, 0)

            ) as GameObject;
        Hadoken hadoken=instance.GetComponent<Hadoken>();
        hadoken.caster = Fighter;
    }
}
