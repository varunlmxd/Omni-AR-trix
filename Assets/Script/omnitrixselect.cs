using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class omnitrixselect : MonoBehaviour
{
    public GameObject ben_10_og;
    public GameObject ben_10_af;
    public GameObject ben_10_ua;
    // Start is called before the first frame update
    void Start()
    {
        ben_10_og.SetActive(true);
        ben_10_af.SetActive(false);
        ben_10_ua.SetActive(false);
    }
    public void ben_10_og_button_on_clicked()
    {
        ben_10_og.SetActive(true);
        ben_10_af.SetActive(false);
        ben_10_ua.SetActive(false);
    }
    public void ben_10_af_button_on_clicked()
    {
        ben_10_og.SetActive(false);
        ben_10_af.SetActive(true);
        ben_10_ua.SetActive(false);
    }
    public void ben_10_ua_button_on_clicked()
    {
        ben_10_og.SetActive(false);
        ben_10_af.SetActive(false);
        ben_10_ua.SetActive(true);
    }


}
