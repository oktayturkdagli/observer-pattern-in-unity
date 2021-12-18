using UnityEngine;
using System.Collections.Generic;

public class ObserverManager : MonoBehaviour
{
    public static ObserverManager instance;

    private List<Subject> _subjects = null;

    private void Awake()
    {
        instance = this;
    }


    public void AddSubject(Subject subject)
    {
        if (_subjects == null)
        {
            _subjects = new List<Subject>();
        }

        _subjects.Add(subject);
    }

    public void AddObserver(Observer observer, SubjectType subjectType)
    {
        foreach (var subject in _subjects)
        {
            if (subject.SubjectType == subjectType)
            {
                subject.ConnectRegister(observer);
            }
        }
    }

}


public enum SubjectType
{
    MovementPanel
}

public enum NotificationType
{
    ForwardButton,
    BackButton,
    LeftButton,
    RightButton
}




