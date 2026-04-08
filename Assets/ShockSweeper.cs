using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class ShockSweeper : MonoBehaviour
{
    //Fetch the Animator
    Animator m_Animator;
    // Use this for deciding if the GameObject can jump or not
    bool m_Jump;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //This gets the Animator, which should be attached to the GameObject you are intending to animate.
        m_Animator = gameObject.GetComponent<Animator>();
        // The GameObject cannot jump
        m_Jump = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Click the mouse or tap the screen to change the animation
        if (Input.GetKeyDown(KeyCode.Space))
            m_Jump = true;

        //Otherwise the GameObject cannot jump.
        else m_Jump = false;

        //If the GameObject is not jumping, send that the Boolean “Jump” is false to the Animator. The jump animation does not play.
        if (m_Jump == false)
            m_Animator.SetBool("Slam", false);

        //The GameObject is jumping, so send the Boolean as enabled to the Animator. The jump animation plays.
        if (m_Jump == true)
            m_Animator.SetBool("Slam", true);
    }
}