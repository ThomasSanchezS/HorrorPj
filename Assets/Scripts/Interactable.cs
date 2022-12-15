using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    public void Interact(GameObject Actor)
    {
        Debug.Log("Hello, you have interacted with me!");
        PlayerStatus status = Actor.GetComponent<PlayerStatus>();
        if (status != null)
        {
            status.Collectibles += 1;
            Destroy(gameObject);
        }
    }
}
