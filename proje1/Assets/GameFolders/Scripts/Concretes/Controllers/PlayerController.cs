using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using proje1.Inputs;


namespace proje1.Controllers
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody _rigidbody;
        DefaultInput _input;

        bool _isForceUp;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _input = new DefaultInput();
        }
        private void Update()
        {
            Debug.Log(_input.IsForceUp);
            if (_input.IsForceUp)
            {
                _isForceUp = true;

            }
            else
            {
                _isForceUp = false;
            }
        }
        private void FixedUpdate()
        {
            if(_isForceUp)
            {
                _rigidbody.AddForce(Vector3.up * Time.deltaTime * _force);
            }
        }
    }

}
