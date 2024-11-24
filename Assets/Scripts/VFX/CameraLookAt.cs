using UnityEditor;
using UnityEngine;

[ExecuteAlways]
public class CameraLookAt : MonoBehaviour
{

    void Update()
    {
        if (Application.isPlaying)
        {
            transform.LookAt(Camera.main.transform);
        }
#if UNITY_EDITOR
        if(!Application.isPlaying)
        {
            transform.LookAt(SceneView.GetAllSceneCameras()[0].transform.position, Vector3.up);
        }
#endif
    }
}
