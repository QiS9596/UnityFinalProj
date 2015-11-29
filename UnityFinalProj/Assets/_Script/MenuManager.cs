using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public GameObject menu;
	public Menu CurrentMenu;

	void Awake(){
		CurrentMenu = menu.GetComponent<Menu> (); 
		Debug.Log("start");
		ShowMenu (CurrentMenu);
	}

	public void ShowMenu(Menu menu){
		if (CurrentMenu != null)
			CurrentMenu.IsOpen = false;

		CurrentMenu = menu;
		CurrentMenu.IsOpen = true;
	
	}

	public void LoadGame(){
		Application.LoadLevel (1);
	}
}
