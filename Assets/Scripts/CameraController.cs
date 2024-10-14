using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CameraController : MonoBehaviour
    {
        public float cameraSpeed = 5.0f;
        public GameObject player;

        private void Update()
        {
            Vector2 direction = player.transform.position - this.transform.position;
            Vector2 moveVector = new Vector2 (direction.x * cameraSpeed * Time.deltaTime , direction.y * cameraSpeed * Time.deltaTime);
            this.transform.Translate (moveVector);
        }
    }
}
