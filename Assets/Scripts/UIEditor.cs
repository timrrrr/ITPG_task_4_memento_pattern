using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIEditor : MonoBehaviour
{
    public InputField _inputField;
    private Caretaker<string> _caretaker;
    
    
    public UIEditor()
    {
        _caretaker = new Caretaker<string>();
        _caretaker.write("");
    }

    public void write()
    {
        _caretaker.write(_inputField.text);
    }

    public void undo()
    {
        _caretaker.undo();
        _inputField.text = _caretaker.getProperty();
    }
    
        
}
