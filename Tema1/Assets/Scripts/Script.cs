using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Events;

public class Script : MonoBehaviour
{

    public GameObject myObject1, myObject2;
    public UnityEvent onTrack;
    public UnityEvent onLost;

    private Animator myAnimator1, myAnimator2;

    public float distance;

    void Start()
    {
        myAnimator1 = myObject1.GetComponent<Animator>();
        myAnimator2 = myObject2.GetComponent<Animator>();
    }

    void Update()
    {

        if (myObject1.activeSelf && myObject2.activeSelf)
        {
            if (Vector3.Distance(myObject1.transform.position, myObject2.transform.position) < distance)
            {
                myAnimator1.Play("Base Layer.Attack");
                myAnimator2.Play("Base Layer.Attack");
                onTrack.Invoke();
            }
            else
            {
                myAnimator1.Play("Base Layer.Walk");
                myAnimator2.Play("Base Layer.Walk");
                onLost.Invoke();
            }
        }

    }
}