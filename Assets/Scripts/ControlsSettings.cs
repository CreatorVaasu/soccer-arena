using System.Collections.Generic;
using UnityEngine;

public class ControlsSettings : MonoBehaviour
{
    public Dictionary<string, KeyCode> controlScheme;

    void Start()
    {
        InitializeControls();
    }

    void InitializeControls()
    {
        controlScheme = new Dictionary<string, KeyCode>
        {
            { "MoveForward", KeyCode.W },
            { "MoveBackward", KeyCode.S },
            { "MoveLeft", KeyCode.A },
            { "MoveRight", KeyCode.D },
            { "Jump", KeyCode.Space },
            { "Shoot", KeyCode.Mouse0 }
        };
    }

    public void RemapControl(string action, KeyCode newKey)
    {
        if (controlScheme.ContainsKey(action))
        {
            controlScheme[action] = newKey;
        }
    }

    public KeyCode GetControl(string action)
    {
        return controlScheme.ContainsKey(action) ? controlScheme[action] : KeyCode.None;
    }
}