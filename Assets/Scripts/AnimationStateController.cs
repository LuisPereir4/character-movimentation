using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private int walkingHash;
    private int runningHash;

    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        walkingHash = Animator.StringToHash("isWalking");
        runningHash = Animator.StringToHash("isRunning");
    }

    private void Update()
    {
        bool isPressingForward = Input.GetKey(KeyCode.W);
        bool isPressingRun = Input.GetKey(KeyCode.LeftShift);

        if (isPressingForward)
            animator.SetBool(walkingHash, true);
        if (!isPressingForward)
            animator.SetBool(walkingHash, false);

        if (isPressingForward && isPressingRun)
            animator.SetBool(runningHash, true);
        if (!isPressingRun || !isPressingForward)
            animator.SetBool(runningHash, false);
    }
}
