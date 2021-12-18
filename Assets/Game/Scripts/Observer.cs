using UnityEngine;
using System.Collections.Generic;


public abstract class Observer : MonoBehaviour
{
    public abstract void OnNotify(NotificationType notificationtype);
}


public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = null;

    [SerializeField] private SubjectType _subjectType;

    public SubjectType SubjectType => _subjectType;

    public void ConnectRegister(Observer observer)
    {
        if (_observers == null)
        {
            _observers = new List<Observer>();
        }

        _observers.Add(observer);
    }

    private void Start()
    {
        ObserverManager.instance.AddSubject(this);
    }

    public void Notify(NotificationType notificationType)
    {
        foreach (var observer in _observers)
        {
            observer.OnNotify(notificationType);
        }
    }
}


