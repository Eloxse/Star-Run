using UnityEngine;

namespace _Scripts.Player
{
    [RequireComponent(typeof(Rigidbody))]

    public class PlayerController : MonoBehaviour
    {
        #region Variables
        [Header("Movements")]
        [SerializeField] private float jumpForce = 10f;
        [SerializeField] private float moveSpeed = 10f;

        private Rigidbody _rb;
        private PlayerInputs _pi;

        private Vector3 velocity = Vector3.zero;
        #endregion

        #region Builtin Methods
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            _pi = GetComponent<PlayerInputs>();
        }

        private void Update()
        {
            Jump();
        }

        private void FixedUpdate()
        {
            Movement(_pi.horizontalMovement);
        }
        #endregion

        #region Custom Methods
        private void Jump()
        {
            if(_pi.jump && _rb.velocity.y == 0)
            {
                _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }

        private void Movement(float _horizontalMovement)
        {
            _horizontalMovement = _pi.horizontalMovement * moveSpeed * Time.deltaTime;

            _rb.velocity = new Vector2(_horizontalMovement, _rb.velocity.y);
        }
        #endregion
    }
}