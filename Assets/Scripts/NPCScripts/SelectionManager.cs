using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SelectionManager : MonoBehaviour
{
    [SerializeField]
    string InteractionTag = "NPC";

    Transform _selection;

    public GameObject player, dialoguecanvas, NPCdialogue;
    public Button continuebutton;
    public TextMeshProUGUI Name, Dialogue;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Deselecting NPCs
        if (_selection != null)
        {
            var SelectionOutline = _selection.GetComponent<Outline>();
            SelectionOutline.enabled = false;
            _selection = null;
        }

        // Raycast for NPC Selection
        var InteractionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit InteractionRayonNPC;

        if (Physics.Raycast(InteractionRay, out InteractionRayonNPC, Mathf.Infinity))
        {
            var Selection = InteractionRayonNPC.transform;
            if (Selection.CompareTag(InteractionTag))
            {
                var SelectionOutline = Selection.GetComponent<Outline>();
                if (SelectionOutline != null)
                {
                    SelectionOutline.enabled = true;
                }
                _selection = Selection;
            }
        }

        // NPC Dialogue
        if (_selection != null && Input.GetMouseButtonDown(0) && Vector3.Distance(player.transform.position, _selection.gameObject.transform.position) < 4.0f)
        {
            int n = 0;
            // Canvas activation and start of Cutscene mode
            var NPCCutscene = _selection.gameObject.GetComponent<IdentityScript>();
            player.GetComponent<IdentityScript>().InCutscene = true;
            NPCCutscene.InCutscene = true;

            // Name Text of Dialogue Window
            Name.text = $"{NPCCutscene.Name} {NPCCutscene.LastName}";
            // Continue button functionality, Dialogue Text of Dialogue Window
            Dialogue.text = NPCCutscene.Dialogue[n];
            dialoguecanvas.SetActive(true);

            continuebutton.onClick.AddListener(delegate
            {
                if (n == NPCCutscene.Dialogue.Count - 1)
                {
                    dialoguecanvas.SetActive(false);
                    NPCCutscene.InCutscene = false;
                    player.GetComponent<IdentityScript>().InCutscene = false;
                    NPCCutscene = null;
                    n = 0;
                }
                else
                {
                    n++;
                    Dialogue.text = NPCCutscene.Dialogue[n];
                }
            });

        }
    }



}
