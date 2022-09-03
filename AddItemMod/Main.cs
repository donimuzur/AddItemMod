using AddItemMod.UI;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.UI;

namespace AddItemMod
{

    public static class BuildInfo
    {
        public const string Name = "AddItemMod";
        public const string Description = "Mod to Add Item";
        public const string Author = "donimuzur"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "2.2.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)    
    }

    public class AddItemMod : MelonMod
    {
        static bool isFinishCreateUI = false;
        static GameObject panelTemplate = null;
        static Item selectedItem = null;
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("AddItemMod Started");
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            isFinishCreateUI = false;
            panelTemplate = null;

        }
        public override void OnUpdate()
        {
            if (isFinishCreateUI) return;

            var gameManager = GameObject.Find("GameManager");
            if(gameManager == null) return;

            GameObject buttonTemplate = null;
            int idx = 1;

            MelonLogger.Msg("Creating UI Add Item Menu");

            var getUIpausWindow = GameObject.FindObjectsOfType<UIPauseWindow>();
            
            foreach(var uipausWindow in getUIpausWindow)
            {
                var panelToCopy =  uipausWindow.gameObject.transform.FindChild("Pivot").gameObject;
                panelTemplate = GameObject.Instantiate(panelToCopy);
                var getResumButton = uipausWindow.gameObject.transform.FindChild("Pivot").FindChild("Main Panel").FindChild("Button_Resume");
                if (getResumButton != null && panelTemplate != null)
                {
                    var obj =  GameObject.FindObjectOfType<UIBuildingInfoWindowStorageModuleCollapsible>();
                    #region Open Menu Button
                    buttonTemplate = GameObject.Instantiate(getResumButton.gameObject);
                    buttonTemplate.transform.DetachChildren();
                    buttonTemplate.name = "AddItemButton" + idx;
                    GameObject.DontDestroyOnLoad(buttonTemplate);

                    panelTemplate.transform.DetachChildren();
                    panelTemplate.name = "AddItemMenu";

                    var toDestroy1 = buttonTemplate.GetComponent<LayoutElement>();
                    GameObject.Destroy(toDestroy1);

                    
                    var buttonAction = buttonTemplate.GetComponent<Button>();
                    buttonAction.onClick.AddListener(delegate
                    {
                        var objs = Resources.FindObjectsOfTypeAll(Il2CppType.From(typeof(Transform)));
                        foreach (var getObj in objs)
                        {
                            if (getObj.name != "AddItemMenu") continue;
                            getObj.TryCast<Transform>().gameObject.SetActive(true);
                        }
                    });

                    var buttonTemplatelayoutElement = buttonTemplate.AddComponent<LayoutElement>();
                    buttonTemplatelayoutElement.ignoreLayout = false;

                    GameObject gameObject2 = new GameObject("AddItemButtonText");
                    var component21 = gameObject2.AddComponent<RectTransform>();

                    var component22 = gameObject2.AddComponent<Text>();
                    component22.text = "Open Menu";
                    component22.fontSize = 14;
                    component22.fontStyle = FontStyle.Bold;
                    component22.color = Color.white;
                    component22.AssignDefaultFont();
                    component22.alignment = TextAnchor.MiddleCenter;

                    gameObject2.transform.SetParent(buttonTemplate.transform, false);

                    var component3 = buttonTemplate.AddComponent<HorizontalLayoutGroup>();
                    component3.childAlignment = TextAnchor.MiddleCenter;

                    var buttonTemplateRectTransofrm = buttonTemplate.GetComponent<RectTransform>();
                    buttonTemplateRectTransofrm.sizeDelta = new Vector2(150, 25);
                    
                    GameObject.DontDestroyOnLoad(obj.gameObject);

                    buttonTemplate.transform.SetParent(obj.gameObject.transform, false);
                    buttonTemplate.transform.localPosition = new Vector3(150, 0, 0);

                    buttonTemplate.SetActiveRecursively(true);
                    #endregion

                    #region AddItemMenu

                    var panelComponent1 = panelTemplate.AddComponent<UIDragable>();
                    panelComponent1.rectTransformToDrag = panelTemplate.GetComponent<RectTransform>();

                    panelTemplate.GetComponent<RectTransform>().sizeDelta = new Vector2(1020, 800);

                    var panelComponent2 = panelTemplate.AddComponent<GridLayoutGroup>();
                    panelComponent2.padding = new RectOffset(20, 20, 20, 100);
                    panelComponent2.spacing = new Vector2(10, 10);

                    GameObject windowCanvas = GameObject.FindObjectOfType<UIWindowManager>().gameObject;

                    #region addItemButton
                    //Usable Items
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemHideCoat(), "Add Hide Coats");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemCarcass(), "Add Carcasses");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemTool(), "Add Tool");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemWeapon(), "Add Weapon");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemSimpleWeapon(), "Add Crude Weapon");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemHeavyWeapon(), "Add Heavy Weapon");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemShield(), "Add Shield");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemHauberk(), "Add Hauberk");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemPlatemail(), "Add Plate Mail");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemBow(), "Add Bow");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemCrossbow(), "Add Crossbow");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemArrow (), "Add Arrows");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemShoes(), "Add Shoes");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemLinenClothes(), "Add Linen Clothes");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemWheatBeer(), "Add Beer");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemBasket(), "Add Basket");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemFurniture(), "Add Furniture");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemSoap(), "Add Soap");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemCandle(), "Add Candle");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemSpice(), "Add Spice");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemPottery(), "Add Pottery");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemGlass(), "Add Glassware");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemBarrel(), "Add Barrel");


                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemBerries(), "Add Berries");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemMeat(), "Add Meat");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemSmokedMeat(), "Add Smoked Meat");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemBeans(), "Add Beans");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemGreens(), "Add Greens");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemRootVegetable(), "Add Vegetables");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemBread(), "Add Bread");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemFish(), "Add Fish");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemSmokedFish(), "Add Smoked Fish");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemMushroom(), "Add Mushrooms");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemNuts(), "Add Nuts");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemFruit(), "Add Fruits");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemPreservedVeg(), "Add Preserved Vegetables");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemPreserves(), "Add Preserves");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemEggs(), "Add Eggs");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemMilk(), "Add Milk");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemCheese(), "Add Cheese");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemMedicine(), "Add Medicine");

                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemFirewood(), "Add Firewood");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemPlanks(), "Add Planks");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemFlour(), "Add Flour");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemHide(), "Add Pelts");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemTallow(), "Add Tallow");

                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemLogs(), "Add Wood");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemStone(), "Add Stone");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemRoots(), "Add Medicinal Roots");

                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemGrain(), "Add Grain");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemWater(), "Add Water");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemFlax(), "Add Flax");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemHerbs(), "Add Herbs");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemWillow(), "Add Willow");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemHoney(), "Add Honey");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemWax(), "Add Wax");

                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemIron(), "Add Iron");
                    CreateUIButton(getResumButton.gameObject, panelTemplate, new ItemGoldIngot(), "Add Gold");

                    #endregion
                    createScrollView(windowCanvas);
                    createCloseButton(getResumButton.gameObject, panelTemplate);

                    panelTemplate.transform.SetParent(windowCanvas.transform, false);

                    panelTemplate.SetActiveRecursively(true);
                    panelTemplate.SetActive(false);
                    #endregion
                }
            }

            isFinishCreateUI = true;
        }
        void createScrollView(GameObject uiPanel)
        {
            #region[Add a ScrollView]
            UIControls.Resources uiResources = new UIControls.Resources();

            uiResources.background = UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#9E9E9EFF"));
            uiResources.standard = UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#7AB900FF"));
            uiResources.knob = UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#191919FF"));

            MelonLogger.Msg("   Creating UI Slider");
            GameObject uiSlider = UIControls.CreateSlider(uiResources);
            var slider = uiSlider.GetComponent<Slider>();

            uiSlider.transform.SetParent(uiPanel.transform, false);

            #endregion
        }
        void createCloseButton(GameObject buttonToCopy, GameObject panelTemplate2 )
        {
            var buttonCloseItemMenu = GameObject.Instantiate(buttonToCopy);
            buttonCloseItemMenu.transform.DetachChildren();
            buttonCloseItemMenu.name = "CloseItemMenuButton";
            GameObject.DontDestroyOnLoad(buttonCloseItemMenu);

            var buttonAction = buttonCloseItemMenu.GetComponent<Button>();
            buttonAction.onClick.AddListener(delegate
            {
                var objs = Resources.FindObjectsOfTypeAll(Il2CppType.From(typeof(Transform)));
                foreach (var getObj in objs)
                {
                    if (getObj.name != "AddItemMenu") continue;
                    getObj.TryCast<Transform>().gameObject.SetActive(false);
                }
            });

            RectTransform toDestroy1 = buttonCloseItemMenu.GetComponent<RectTransform>();
            GameObject.Destroy(toDestroy1);

            var toDestroy2 = buttonCloseItemMenu.GetComponent<LayoutElement>();
            GameObject.Destroy(toDestroy2);

            buttonCloseItemMenu.AddComponent<RectTransform>();

            var buttonCloseItemMenulayoutElement = buttonCloseItemMenu.AddComponent<LayoutElement>();
            buttonCloseItemMenulayoutElement.ignoreLayout = true;

            GameObject gameObject2 = new GameObject("buttonCloseItemMenuText");
            var component21 = gameObject2.AddComponent<RectTransform>();

            var component22 = gameObject2.AddComponent<Text>();
            component22.text = "Close Menu";
            component22.fontSize = 14;
            component22.fontStyle = FontStyle.Bold;
            component22.color = Color.white;
            component22.AssignDefaultFont();
            component22.alignment = TextAnchor.MiddleCenter;

            gameObject2.transform.SetParent(buttonCloseItemMenu.transform, false);

            var buttonCloseItemMenuRectTransofrm = buttonCloseItemMenu.GetComponent<RectTransform>();
            buttonCloseItemMenuRectTransofrm.sizeDelta = new Vector2(100, 50);

            buttonCloseItemMenu.transform.SetParent(panelTemplate2.transform, false);
            buttonCloseItemMenu.transform.localPosition = new Vector3(0, -200, 0);

            buttonCloseItemMenu.SetActiveRecursively(true);
        }
        void CreateUIButton(GameObject copyButton, GameObject panelTemplate, Item item, string text)
        {
            var buttonAddItemTemplate = GameObject.Instantiate(copyButton);
            GameObject.DontDestroyOnLoad(buttonAddItemTemplate);
            buttonAddItemTemplate.name = "Add" + item.name + "Button";
            buttonAddItemTemplate.transform.DetachChildren();

            var buttonAddItemTemplatebuttonAction = buttonAddItemTemplate.GetComponent<Button>();
            buttonAddItemTemplatebuttonAction.onClick.AddListener(delegate
            {
                selectedItem = null;
                selectedItem = item;
                addItem();
            });

            RectTransform buttonAddItemTemplatebuttonActiontoDestroy1 = buttonAddItemTemplate.GetComponent<RectTransform>();
            GameObject.Destroy(buttonAddItemTemplatebuttonActiontoDestroy1);

            var buttonAddItemTemplatetoDestroy2 = buttonAddItemTemplate.GetComponent<LayoutElement>();
            GameObject.Destroy(buttonAddItemTemplatetoDestroy2);

            buttonAddItemTemplate.AddComponent<RectTransform>();

            var buttonAddItemTemplatelayoutElement = buttonAddItemTemplate.AddComponent<LayoutElement>();
            buttonAddItemTemplatelayoutElement.ignoreLayout = false;



            GameObject buttonAddItemTemplategameObject1 = new GameObject("buttonAddItemTemplateIcon");
            var buttonAddItemTemplategameObject11 = buttonAddItemTemplategameObject1.AddComponent<RectTransform>();

            var buttonAddItemTemplategameObject12 = buttonAddItemTemplategameObject1.AddComponent<Image>();
            buttonAddItemTemplategameObject12.sprite = item.icon;
            buttonAddItemTemplategameObject12.preserveAspect = true;
            buttonAddItemTemplategameObject12.transform.SetParent(buttonAddItemTemplate.transform, false);

            GameObject buttonAddItemTemplategameObject2 = new GameObject("buttonAddItemTemplateText"+item.name);
            var buttonAddItemTemplatecomponent21 = buttonAddItemTemplategameObject2.AddComponent<RectTransform>();

            var buttonAddItemTemplatecomponent22 = buttonAddItemTemplategameObject2.AddComponent<Text>();
            buttonAddItemTemplatecomponent22.text = text;
            buttonAddItemTemplatecomponent22.fontSize = 14;
            buttonAddItemTemplatecomponent22.fontStyle = FontStyle.Bold;
            buttonAddItemTemplatecomponent22.color = Color.white;
            buttonAddItemTemplatecomponent22.AssignDefaultFont();
            buttonAddItemTemplatecomponent22.alignment = TextAnchor.MiddleCenter;

            buttonAddItemTemplategameObject2.transform.SetParent(buttonAddItemTemplate.transform, false);

            buttonAddItemTemplate.transform.SetParent(panelTemplate.transform, false);

            buttonAddItemTemplate.SetActiveRecursively(true);
        }

        void addItem()
        {
            var gameManagerAddItemObject = GameObject.Find("GameManager");
            if (gameManagerAddItemObject != null)
            {
                var inputManagerAddItem = gameManagerAddItemObject.GetComponent<InputManager>();
                if (inputManagerAddItem != null)
                {
                    var selectedBuilding = inputManagerAddItem.selectedObject.GetComponent<Building>();
                    if (selectedBuilding != null)
                    {
                        MelonLogger.Msg("bisa");
                        var itemBundle = new ItemBundle(selectedItem, 100, 100);
                        selectedBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
        }
    }
}

