using UnityEngine;

public class DoorController : Observer
{
    public int id;

    private void Start()
    {
        //Observation is begun
        ObserverManager.instance.AddObserver(this, SubjectType.Door);
    }

    //It is determined what to do when the notification comes.
    public override void OnNotify(NotificationType notificationtype, object parameterOne)
    {
        switch (notificationtype)
        {
            case NotificationType.onWallTriggerEnter:
                DoorOpen((int)parameterOne);
                break;
            case NotificationType.onWallTriggerExit:
                DoorClose((int)parameterOne);
                break;
            default:
                break;
        }
    }

    //Door are opened
    private void DoorOpen(int id)
    {
        if (id == this.id)
        {
            transform.Translate(new Vector3(0, 1.6f, 0));
        }
    }

    //Door are Closed
    private void DoorClose(int id)
    {
        if (id == this.id)
        {
            transform.Translate(new Vector3(0, -1.6f, 0));
        }
    }


    public void OnDestroy()
    {
        //Observation is finished
        ObserverManager.instance.RemoveObserver(this, SubjectType.Door);
    }
}