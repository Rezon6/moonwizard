using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWizard : MonoBehaviour {
    //bý til transform sem tekur staðsetningu galdrakarlsins og hversu langt frá henni myndavélin ætti að vera
    public Transform wizard;
    public Vector3 offset;

	void Update () {
        //er að binda myndavélina við staðsetningu galdrakarlsins
        transform.position = wizard.position + offset;
	}
}
