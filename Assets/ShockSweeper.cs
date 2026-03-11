using UnityEngine;
using UnityEngine.InputSystem;

public class ShockSweeper : MonoBehaviour
{
    Animator shockSweeperAnimator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shockSweeperAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool slam = Input.GetButtonDown("Attack");
        shockSweeperAnimator.SetBool("isAttacking", slam);
    }
}