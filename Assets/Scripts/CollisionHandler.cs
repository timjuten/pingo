
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Friendly":
                Debug.Log("This thing is friendly");
                break;
            case "Finish":
                Debug.Log("You've finished");
                break;
            case "Fuel":
                Debug.Log("You've picked up fuel");
                break;
            default:
                Debug.Log("KABOOM!");
                break;
        }
    }
}
