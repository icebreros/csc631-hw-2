using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class material_script : MonoBehaviour
{
    public Material m;

    public void ChangeTexture()
    {
        MeshRenderer mR = GetComponent<MeshRenderer>();
        mR.material = m;

    }
}
