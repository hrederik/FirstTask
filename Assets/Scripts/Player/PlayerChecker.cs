using UnityEngine;

public class PlayerChecker : MonoBehaviour
{
    public static bool IsPlayer(Transform checkableObject)
    {
        return checkableObject.GetComponent<PlayerMovement>();
    }

    public static bool IsPlayer(Collider checkableObject)
    {
        return IsPlayer(checkableObject.transform);
    }

    public static bool IsPlayer(Collision checkableObject)
    {
        return IsPlayer(checkableObject.transform);
    }    
}