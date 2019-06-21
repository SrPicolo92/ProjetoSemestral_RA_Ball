using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController: MonoBehaviour
{
    public Animator animator;


    public void Avancar()
    {
        animator.SetTrigger("Avancar");
        Debug.Log("Avançando!");
    }

    public void Retornar()
    {
        animator.SetTrigger("Retornar");
        Debug.Log("Retornando");
    }
}
