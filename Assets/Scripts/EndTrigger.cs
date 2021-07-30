using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{

    public GameManager gameManager;
    public bool completed;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        completed = true;

    }
}
