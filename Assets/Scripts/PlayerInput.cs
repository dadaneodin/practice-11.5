
using UnityEngine;

namespace WildBall.Inputs 
{
    [RequireComponent(typeof(PlayerMovement))]

    public class PlayerInput : MonoBehaviour
    {

        private Vector3 movement;
        private PlayerMovement playerMnt;
        private Rigidbody playerRb;

        private void Awake()
        {
            playerMnt = GetComponent<PlayerMovement>();
            playerRb = GetComponent<Rigidbody>();
        }


        void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            bool jump = Input.GetButtonDown(GlobalStingVars.JUMP_BUTTON);

            movement = new Vector3(horizontal, 0, vertical).normalized;
            
            if (Input.GetButtonDown(GlobalStingVars.JUMP_BUTTON))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.up * 5f, ForceMode.Impulse);
            }
            
            // Vector3 movement = new Vector3(horizontal, 0, vertical) * speed * Time.deltaTime;
            // transform.Translate(movement);
        }

        private void FixedUpdate()
        {
            playerMnt.MoveCharacter(movement);
        }
    }   
}
