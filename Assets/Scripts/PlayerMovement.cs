using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs 
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField,Range(0, 10)] private float speed = 2.00f;
        private Rigidbody playerRb;


        private void Awake()
            {
                playerRb = GetComponent<Rigidbody>();
            }

        public void MoveCharacter(Vector3 movement)
            {
                playerRb.AddForce(movement * speed);
            }
        
    #if UNITY_EDITOR
            [ContextMenu("Reset Values")]
            public void ResetValues()
            {
                speed = 2;
            }
    #endif


    }
}
