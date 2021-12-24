using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    public int id;

    private void OnTriggerEnter(Collider other)
    {
        //The following line of code is used to send notifications to observers.
        ObserverManager.instance.FindSubject(SubjectType.Door).Notify(NotificationType.onWallTriggerEnter, id);
    }

    private void OnTriggerExit(Collider other)
    {
        //The following line of code is used to send notifications to observers.
        ObserverManager.instance.FindSubject(SubjectType.Door).Notify(NotificationType.onWallTriggerExit, id);
    }
}