using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadScreen : MonoBehaviour {
	[SerializeField]
	public float units;
	[SerializeField]
	public  GameObject createPrefab;
	[SerializeField]
	public Image Bar;
	[SerializeField]
	public  GameObject button;

	private float BarAmount=1;
	// Use this for initialization
	void Start () {
		StartCoroutine (BuildUnits ());
		
	}
	
	// Update is called once per frame
	void Update () {
		UpdateLodingBar ();
		
	}
	public IEnumerator BuildUnits (){
		for (int i = 0; i <= units; i++) {
			BarAmount = i / units;
			yield return null;
		}
		//done loading
		button.SetActive(true);

	}
	private void UpdateLodingBar(){
		Bar.fillAmount = BarAmount;
	}
}
