using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHandler : MonoBehaviour
{
    public GameObject art;
    private static DataHandler instacne;
    public static DataHandler Instance {
        get
        {
            if(Instance == null)
            {
                instacne = FindObjectOfType<DataHandler>();
            }
            return instacne;
        }
    }
}
