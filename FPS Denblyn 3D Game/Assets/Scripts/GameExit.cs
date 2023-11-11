using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class GameExit : MonoBehaviour
{
    public GameObject ExitPanel;
    public GameObject thePlayer;

    public int dem;
    public bool ReadyExit;

    // Start is called before the first frame update
    void Start()
    {
        dem = 0;
        ReadyExit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            dem++;
            if(dem % 2 != 0)
            {
                ReadyExit = true;
                ExitPanel.SetActive(true);
            }
            else
            {
                ReadyExit = false;
                ExitPanel.SetActive(false);
            }
        }
        if (ReadyExit == true)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                thePlayer.GetComponent<FirstPersonController>().enabled = false;
                GlobalWeapons.Original = 0;
                GlobalComplete.nextFloor = 3;
                Cursor.visible = true;
                //Screen.lockCursor = false;
                Cursor.lockState = CursorLockMode.None;
                SceneManager.LoadScene(1);
            }
        }
    }
}
