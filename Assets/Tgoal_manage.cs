using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.InputSystem.XR;


public class Tgoal_manage : MonoBehaviour
{
    [SerializeField] Image transition_image;
    [SerializeField] float Duration = 0.5f;
    [SerializeField] float Start_Delay = 1f;
    [SerializeField] float Scene_change_Delay = 2f;
    [SerializeField] CameraCtrl camera;
    [SerializeField] Audio_Manager audio_manager;
    private Cliere uiController;
    bool isGet = false;

    // Start is called before the first frame update
    void Start()
    {
        uiController = FindObjectOfType<Cliere>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!isGet)
            {
                uiController.ShowImage();
                isGet = true;
                audio_manager.isGoal = true;
                camera.isGoal = true;
                var sequence = DOTween.Sequence();
                DOVirtual.DelayedCall(
                    Start_Delay,   //
                    () => {
                        sequence.Append(transition_image.DOFillAmount(1, Duration));
                    }
                );

                DOVirtual.DelayedCall(
                    Scene_change_Delay,   //
                    () => {

                        SceneManager.LoadScene("StageSelectUI");
                    }
                );
            }
        }
    }
}
