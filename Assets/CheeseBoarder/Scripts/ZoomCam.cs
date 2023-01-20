using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ZoomCam : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera virtCam;
    public float min = 11.5f;
    public float max = 20.1f;
    [SerializeField] float t = 0.01f;

    
    // Start is called before the first frame update
    void Start()
    {
        min = virtCam.m_Lens.OrthographicSize;
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("ZoomTrig")) 
            {
                StopAllCoroutines();
                StartCoroutine(Lerp(virtCam.m_Lens.OrthographicSize, max));
            }
    }
    void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.CompareTag("ZoomTrig"))
        {
            StopAllCoroutines();
            StartCoroutine(Lerp(virtCam.m_Lens.OrthographicSize, min));
        }
    }


     IEnumerator Lerp(float start, float end) 
    {
        t = 0.01f;
        while(virtCam.m_Lens.OrthographicSize != end)
        {
            virtCam.m_Lens.OrthographicSize = Mathf.Lerp(start, end, t);
            t += Time.deltaTime;
            yield return null;

        }
        yield return null;

    }

}
