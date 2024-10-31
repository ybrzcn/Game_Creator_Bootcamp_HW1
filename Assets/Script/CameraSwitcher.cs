using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    public List<Camera> cameraList = new List<Camera>();

    void Start()
    {
        for (int i = 0; i < cameraList.Count; i++)
        {
            cameraList[i].gameObject.SetActive(i == 0);
        }
    }

    void Update()
    {
        for (int i = 0; i < cameraList.Count; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                ActivateCamera(i);
            }
        }
    }

    private void ActivateCamera(int cameraNo)
    {
        if (cameraNo < 0 || cameraNo >= cameraList.Count) return;

        foreach (var cam in cameraList)
        {
            cam.gameObject.SetActive(false);
        }

        cameraList[cameraNo].gameObject.SetActive(true);
    }
}
