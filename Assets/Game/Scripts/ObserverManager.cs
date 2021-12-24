using UnityEngine;
using System.Collections.Generic;

public class ObserverManager : MonoBehaviour
{
    public static ObserverManager instance;

    private List<Subject> _subjects = null;

    private void Awake()
    {
        instance = this;
        _subjects = new List<Subject>();
    }

    //Subjects are added
    public void AddSubject(Subject subject)
    {
        int _listCount = _subjects.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_subjects[i].SubjectType == subject.SubjectType)
            {
                _subjects.Remove(subject);
                break;
            }
        }

        _subjects.Add(subject);
    }

    //Subjects are removed
    public void RemoveSubject(Subject subject)
    {
        int _listCount = _subjects.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_subjects[i].SubjectType == subject.SubjectType)
            {
                _subjects.Remove(subject);
                break;
            }
        }
    }

    //An existing subject is found
    public Subject FindSubject(SubjectType subjectType)
    {
        int _listCount = _subjects.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_subjects[i].SubjectType == subjectType)
            {
                return _subjects[i];
            }
        }

        return null;
    }

    //Subject's observers are added via ObserverManager
    public void AddObserver(Observer observer, SubjectType subjectType)
    {
        int _listCount = _subjects.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_subjects[i].SubjectType == subjectType)
            {
                _subjects[i].AddObserver(observer);
                break;
            }
        }
    }

    //Subject's observers are removed via ObserverManager
    public void RemoveObserver(Observer observer, SubjectType subjectType)
    {
        int _listCount = _subjects.Count;
        for (int i = 0; i < _listCount; i++)
        {
            if (_subjects[i].SubjectType == subjectType)
            {
                _subjects[i].RemoveObserver(observer);
                break;
            }
        }
    }

}


//Subject types to be used are defined here
public enum SubjectType
{
    Door
}

//Notify types to be used are defined here
public enum NotificationType
{
    onWallTriggerEnter,
    onWallTriggerExit
}




