
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gamemanager gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
