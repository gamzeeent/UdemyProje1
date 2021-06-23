using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using proje1.Managers;


namespace proje1.Controllers
{
public class FinishFloorController : MonoBehaviour
{
        [SerializeField] GameObject _FinishFireWork;
        [SerializeField] GameObject _FinishLight;

        private void OnCollisionEnter(Collision other)
        {
            PlayerController player = other.collider.GetComponent<PlayerController>();
            if(player == null) return;
            if (other.GetContact(index: 0).normal.y == -1)
            {
                _FinishFireWork.gameObject.SetActive(true);
                _FinishLight.gameObject.SetActive(true);
                GameManager.Instance.MissionSucced();
            }
            else
            {
                //gameover
                GameManager.Instance.GameOver(); 
            }
        }
    }
}

