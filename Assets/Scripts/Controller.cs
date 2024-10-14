using System;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // Action은 무조건 void만 반환해야 아니면 Func
    public event Action<Vector2> OnLookEvent;

    protected virtual void Awake()
    {
        
    }

    public void CallMoveEvent(Vector2 direction) 
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}

