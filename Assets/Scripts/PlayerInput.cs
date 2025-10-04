
using UnityEngine;

namespace WildBall.Inputs 
{
    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerInput : MonoBehaviour
    {

        private Vector3 movement;
        private PlayerMovement playerMnt;

        private void Awake()
        {
            playerMnt = GetComponent<PlayerMovement>();
        }


        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            movement = new Vector3(-horizontal,0,-vertical).normalized;
            
            // Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
            // transform.Translate(movement);
        }

        private void FixedUpdate()
        {
            playerMnt.MoveCharacter(movement);
        }
    }   
}
