using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act38deviceHolder : MonoBehaviour
{
    Animator anim;
    public GameObject target;
    public GameObject hand;
    public float IK_weight = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex){
        // pointing hand to device
        anim.SetIKPosition(AvatarIKGoal.RightHand, target.transform.position);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IK_weight);
        // attach device to hand
        target.transform.parent = hand.transform;
        target.transform.localPosition = new Vector3(0.00562f, -0.00031f, -0.00119f);
        target.transform.localRotation = Quaternion.Euler(-13.075f, 370.383f, -65.793f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
