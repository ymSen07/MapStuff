using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
  
	[SerializeField] private GameObject MapMenuUI;
	[SerializeField] private GameObject[] lockedMapSections;
	private bool[] isSectionUnlocked; 
	public bool isMapVisible = false;

    void Start()
	{
		MapMenuUI.SetActive(false);

		isSectionUnlocked = new bool[lockedMapSections.Length];
		for (int i = 0; i < lockedMapSections.Length; i++)
		{
			isSectionUnlocked[i] = false;
		}
	}

	private void Update()
	{
		if (Input.GetKeyUp(KeyCode.M))
		{
			if (isMapVisible)
			{
				Resume();
			}
			else
			{
				ViewMap();
			}
		}

	}
	public void MouseLock()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

	}

	void Resume()
	{
		MapMenuUI.SetActive(false);
		Time.timeScale = 1f;
			isMapVisible = false;
	}

	void ViewMap()
	{
		MapMenuUI.SetActive(true);
		Time.timeScale = 0f;
		isMapVisible = true;

			// Update the visibility of the locked map sections
		for (int i = 0; i < lockedMapSections.Length; i++)
		{
				lockedMapSections[i].SetActive(isSectionUnlocked[i]);
		}
	}

	// Add this method to unlock a map section when an object is collected
	public void UnlockMapSection(int sectionIndex)
	{
		isSectionUnlocked[sectionIndex] = true;
	}


}
