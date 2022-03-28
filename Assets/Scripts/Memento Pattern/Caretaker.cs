using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Caretaker<T>
{
    private Originator<T> _originator;
    private List<Originator<T>.Memento> stateHistory;
    
    public Caretaker() {
        _originator = new Originator<T>();
        stateHistory = new List<Originator<T>.Memento>();
        //Debug.Log("constructor run");
    }
    
    public void write(T property) {
        _originator.set(property);
        Originator<T>.Memento mem = _originator.takeSnapshot();
        stateHistory.Add(mem);
    }
    
    public void undo() {
        if (stateHistory.Count <= 1) {
            //Debug.Log("can not undo :(");
            return;
        }
        
        //Debug.Log("undoing..");
        stateHistory.RemoveAt(stateHistory.Count - 1);
        _originator.restore(stateHistory.Last());

        
    }
    public T getProperty() {
        return _originator.getProperty();
    }
    
    
    public void printText() {
        //Debug.Log(_originator.getProperty());
    }
    
}
