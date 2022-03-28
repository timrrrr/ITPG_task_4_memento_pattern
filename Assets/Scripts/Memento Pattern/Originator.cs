using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Originator<T>
{
    
    private T property;
    
    public void set(T property) {
        this.property = property;
    }
    
    public T getProperty() {
        return property;
    }
    
    public Memento takeSnapshot() {
        return new Memento(this.property);
    }
    
    public void restore(Memento memento) {
        this.property = memento.getSavedProperty();
    }
    
    public class Memento {
        private T property;

        public Memento(T propertyToSave) {
            property = propertyToSave;
        }

        public T getSavedProperty() {
            return property;
        }
    }
    
}
