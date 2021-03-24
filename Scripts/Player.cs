using UnityEngine;

namespace RollaBall
{ 
    public class Player : MonoBehaviour
    {
        public float CurrentSpeed = 3.0f;
        public float NormalSpeed = 3.0f;
        float moveHorizontal;
        float moveVertical;
        private Rigidbody _rigidbody;

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        protected void GetAxis()
        {
            moveHorizontal = Input.GetAxis("Horizontal");
            moveVertical = Input.GetAxis("Vertical");
        }

        protected void Move()
        {
           

            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

            _rigidbody.AddForce(movement * CurrentSpeed);
        }

    }

}
