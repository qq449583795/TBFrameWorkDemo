

using Photon.Pun;
using System;
using System.Collections;
using System.Collections.Generic;
using TBFrameWork;

public class RoomData : ISubject
{
    // Start is called before the first frame update
    private int stateId;
    List<IObserver> m_ObserverList;
    public RoomData()
    {
        m_ObserverList = new List<IObserver>();
    }
    public void NotifyUpdate()
    {
        for (int i = 0; i < m_ObserverList.Count; i++)
        {
            m_ObserverList[i].ObserverUpdate(stateId);
        }
    }

    public void RegistObserver(IObserver o)
    {
        m_ObserverList.Add(o);
    }

    public void UnRegistObserver(IObserver o)
    {
        m_ObserverList.Remove(o);
    }
}
