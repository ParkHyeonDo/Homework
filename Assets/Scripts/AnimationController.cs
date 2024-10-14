using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public class AnimationController : MonoBehaviour
    {
        protected Animator animator;
        protected Controller controller;
        public GameObject firstSprite;
        public GameObject secondSprite;


        private int isSecond = Animator.StringToHash("isSecond");


        protected void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            controller = GetComponent<Controller>();
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0)) 
            {
                
                if (!animator.GetBool(isSecond))
                {
                   /* firstSprite.SetActive(false);
                    secondSprite.SetActive(true);*/
                    animator.SetBool(isSecond, true);
                    
                }
                else 
                {
                   /* firstSprite.SetActive(true);
                    secondSprite.SetActive(false);*/
                    animator.SetBool(isSecond, false);
                    
                }
            }
        }


    }
}
