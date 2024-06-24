using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TBFrameWork {
    public interface ISubject
    {
        // Start is called before the first frame update
        public void RegistObserver(IObserver o);
        public void UnRegistObserver(IObserver o);
        public void NotifyUpdate();
    }
    public interface IObserver
    {
        // Start is called before the first frame update
        public void InitSubject(ISubject subject);
        public void ObserverUpdate(int stateId);
    }
    public interface IRoomDataObserver
    {
        // Start is called before the first frame update
        public void ObserverUpdate();
    }
}