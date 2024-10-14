using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : Controller
{
    private Camera camera;


    // Start is called before the first frame update


    // Update is called once per frame
    protected override void Awake()
    {
        base.Awake();
        camera = Camera.main;
    }

    public void OnMove(InputValue inputValue)
    {
        Vector2 movement = inputValue.Get<Vector2>().normalized;
        //GetComponent<PlayerMovement>().Move(movement); 로 가능하지만 직접접근
        
        CallMoveEvent(movement);
    }

    public void OnLook(InputValue inputValue)
    {
        Vector2 look = inputValue.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(look);
        look = (worldPos - (Vector2)transform.position).normalized;
        CallLookEvent(look);
    }

}
