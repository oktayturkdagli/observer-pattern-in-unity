using UnityEngine;
using System.Collections.Generic;

public class Subject : MonoBehaviour
{
    private List<Observer> _observers = null;

    //Just to see it on inspector
    [SerializeField] private SubjectType _subjectType; 
    public SubjectType SubjectType => _subjectType;

    //When the subject is created, it is automatically added to the subject list
    private void Start()
    {
        ObserverManager.instance.AddSubject(this);
    }

    //When the subject is destroyed, it is automatically deleted from the subject list.
    private void OnDestroy()
    {
        ObserverManager.instance.RemoveSubject(this);
    }

    //Subject's observers are added
    public void AddObserver(Observer observer)
    {
        if (_observers == null)
        {
            _observers = new List<Observer>();
        }

        int _listCount = _observers.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_observers[i] == observer)
            {
                _observers.Remove(observer);
                break;
            }
        }

        _observers.Add(observer);
    }

    //Subject's observers are removed
    public void RemoveObserver(Observer observer)
    {
        int _listCount = _observers.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_observers[i] == observer)
            {
                _observers.Remove(observer);
                break;
            }
        }
    }

    //Subject's observers are notified
    public void Notify(NotificationType notificationType)
    {
        int _listCount = _observers.Count;
        for (int i = 0; i < _listCount; i++)
        {
            _observers[i].OnNotify(notificationType);
        }
    }

    //Subject's observers are notified with parameter
    public void Notify(NotificationType notificationType, object parameterOne)
    {
        int _listCount = _observers.Count;
        for (int i = 0; i < _listCount; i++)
        {
            _observers[i].OnNotify(notificationType, parameterOne);
        }
    }

    //Subject's observers are notified with two parameter
    public void Notify(NotificationType notificationType, object parameterOne, object parameterTwo)
    {
        int _listCount = _observers.Count;
        for (int i = 0; i < _listCount; i++)
        {
            _observers[i].OnNotify(notificationType, parameterTwo);
        }
    }
}
