using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act3finalIK : MonoBehaviour
{
    public GameObject target;
    public GameObject hand;
    public float IK_weight = 1f;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        // set hand to device position 
        anim.SetIKPosition(AvatarIKGoal.LeftHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, IK_weight);
        //Right
        anim.SetIKPosition(AvatarIKGoal.RightHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IK_weight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
