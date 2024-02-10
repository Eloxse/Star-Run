using _Scripts.Manager;
using UnityEngine;

namespace _Scripts.Gameplay
{
    [RequireComponent(typeof(Rigidbody))]

    public class TileManager : MonoBehaviour
    {
        #region Variables
        [Header("Tile parameters")]
        [SerializeField] private float speed = 3f;
        [SerializeField] private Transform spawnGround;

        private Rigidbody _rb;
        private GameManager _gm;
        #endregion

        #region Builtin Methods
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _gm = GetComponent<GameManager>();
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
            if(other.transform.tag == "Player")
            {
                _gm.GetComponent<GameManager>().SpawnGround(spawnGround.position);
            }

            if(other.transform.tag == "Destroy_Ground")
            {
                Destroy(gameObject);
            }
            //Destroy the ground once it passes the camera, to avoid overloading the ground
        }
        #endregion
    }
}

