using UnityEngine;

namespace _Scripts.Gameplay
{
    [RequireComponent(typeof(Rigidbody))]

    public class TileManager : MonoBehaviour
    {
        #region Variables
        [Header("Tile parameters")]
        [SerializeField] private float speed = 3f;

        private Rigidbody _rb;
        #endregion

        #region Builtin Methods
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            GroundMovement();
        }
        #endregion

        #region Custom Methods
        private void GroundMovement()
        {
            _rb.MovePosition(transform.position - Vector3.forward * Time.deltaTime * speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.tag == "Destroy_Ground")
            {
                Destroy(gameObject);
            }
            //Destroy the ground once it passes the camera, to avoid overloading the ground
        }
        #endregion
    }
}

