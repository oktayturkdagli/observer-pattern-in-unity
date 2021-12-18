using UnityEngine;

public class MovementSystem : Observer
{
    private void Start()
    {
        ObserverManager.instance.AddObserver(this, SubjectType.MovementPanel);
    }

    public override void OnNotify(NotificationType notificationtype)
    {
        switch (notificationtype)
        {
            case NotificationType.ForwardButton:
                transform.Translate(Vector3.forward);
                break;
            case NotificationType.BackButton:
                transform.Translate(Vector3.back);
                break;
            case NotificationType.RightButton:
                transform.Translate(Vector3.left);
                break;
            case NotificationType.LeftButton:
                transform.Translate(Vector3.right);
                break;
            default:
                break;
        }
    }
}
