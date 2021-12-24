using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    //Observers can be triggered with parameters
    //We make our classes virtual (same thing abstract) to avoid adding extra lines of code inside each observer.
    public virtual void OnNotify(NotificationType notificationtype) { }
    public virtual void OnNotify(NotificationType notificationtype, object parameterOne) { }
    public virtual void OnNotify(NotificationType notificationtype, object parameterOne, object parameterTwo) { }
}


