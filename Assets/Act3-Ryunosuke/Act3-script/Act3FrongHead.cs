using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act3FrongHead : MonoBehaviour
{
    public GameObject target;
    public GameObject head;
    public float IK_weight = 1f;

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();   
    }

    private void OnAnimatorIK(int layerIndex)
    {
        target.transform.parent = head.transform;
        //
        // anim.SetIKPosition(AvatarIKGoal.Head, target.transform.position);
        // anim.SetIKPositionWeight(AvatarIKGoal.Head, IK_weight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
