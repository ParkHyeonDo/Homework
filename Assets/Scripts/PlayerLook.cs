using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace Assets.Scripts
{
    public class PlayerLook : MonoBehaviour
    {
        private Controller playerController;
        [SerializeField] private SpriteRenderer characterRenderer;
        

        public void Start()
        {
            playerController.OnLookEvent += Look;
        }

        public void Look(Vector2 direction)
        {
            float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
        }

        public void Awake() 
        {
            playerController = GetComponent<Controller>();
        }



    }
}
