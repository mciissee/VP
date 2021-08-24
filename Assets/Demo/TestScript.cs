using UnityEngine;
using InfinityEngine.Serialization;

public class TestScript : MonoBehaviour {


	void Start () {

        Debug.Log("The value of the preference 'myInt' is " + R2.integers.myInt.Value);
        R2.integers.myInt.Value = 10;
        Debug.Log("The new value of the preference 'myInt' is " + R2.integers.myInt.Value);
        VP.Save();
    }
	

	void Update () {
	
	}



}