using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterprotonDistanceAdjust : MonoBehaviour
{
    private Rigidbody Proton1;
    private Rigidbody Proton2;
    private Slider Interproton;
    private Slider SimSpeed;
    private float PE;
    private float xCoord;
    public GameObject PEtext;
    public float ElectrYCoord;
    public float ProtonCharge; 


    // Start is called before the first frame update
    void Start()
    {
        
        Proton1 = GameObject.Find("[P] Covalent bonding proton").GetComponent<Rigidbody>();
        Proton2 = GameObject.Find("[P] Covalent bonding proton (1)").GetComponent<Rigidbody>();
        Interproton = GameObject.Find("Interproton Distance").GetComponent<Slider>();
        SimSpeed = GameObject.Find("speedSlider").GetComponent<Slider>();
        print(Interproton.value);
        print(SimSpeed.value);
        print(Proton1.transform.position);
        print(Proton2.transform.position);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (SimSpeed.value == 0.0f)
        {
            Proton1.transform.position = new Vector3(2+Interproton.value/2f,0f,0f);
            Proton2.transform.position = new Vector3(2-Interproton.value/2f,0f,0f);
        }
        xCoord = Proton1.transform.position.x-2;
        print(xCoord);
        PE = 100*((1/(2*xCoord))-(4/Mathf.Sqrt(ElectrYCoord*ElectrYCoord+xCoord*xCoord)));
        print(Mathf.RoundToInt(PE));
        PEtext.GetComponent<Text>().text = "Potential Energy = "+Mathf.RoundToInt(PE).ToString();

    }
}
