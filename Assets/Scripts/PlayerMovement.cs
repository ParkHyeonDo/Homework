using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerMovement :MonoBehaviour
    {
        private Controller playerController;
        private Rigidbody2D rigidbody;
        private Vector2 moveDirection = Vector2.zero;

        public void Awake()
        {
            playerController = GetComponent<Controller>();
            rigidbody = GetComponent<Rigidbody2D>();

        }

        public void Start()
        {
            playerController.OnMoveEvent += Move;
        }

        public void Move(Vector2 direction)
        {
            moveDirection = direction;
        }

        public void FixedUpdate()
        {
            ApplyMovement(moveDirection);
        }

        public void ApplyMovement(Vector2 direction) 
        {
            rigidbody.velocity = direction * 5;
        }
    }

}
