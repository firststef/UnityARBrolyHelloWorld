using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginAnimate : MonoBehaviour
{   
    public Transform ar_camera_t;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Transform t = GetComponent<Transform>();
        if (Vector3.Distance(t.position, ar_camera_t.position) < 12.0f){
            animator.SetTrigger("PlayRageAnimation");
        }
        else{
            animator.ResetTrigger("PlayRageAnimation");
        }
    }
}
