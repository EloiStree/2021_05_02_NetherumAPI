using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WebGL_Toggling : MonoBehaviour
{
    public UnityEvent m_webGLOn;
    public UnityEvent m_webGLOff;
    void Start()
    {
#if UNITY_WEBGL
        
        m_webGLOn.Invoke();
#else

        m_webGLOff.Invoke();
#endif        
    }

}
