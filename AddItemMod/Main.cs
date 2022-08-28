﻿using MelonLoader;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AddItemMod
{

    public static class BuildInfo
    {
        public const string Name = "AddItemMod";
        public const string Description = "Mod to Add Item";
        public const string Author = "donimuzur"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.1.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)    
    }

    public class AddItemMod : MelonMod
    {
 
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("AddItemMod Started");
        }
        public override void OnUpdate()
        {
            var listItems = AppDomain.CurrentDomain.GetAssemblies()
                       .SelectMany(assembly => assembly.GetTypes())
                       .Where(type => type.IsSubclassOf(typeof(Item)));

            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha6))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemBread(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha7))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemMeat(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha8))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemEggs(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha9))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemFruit(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha0))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemTool(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha6))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemPlatemail(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha7))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemShield(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha8))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemHeavyWeapon(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha9))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemCrossbow(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha0))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemShoes(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.M))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemGoldIngot(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.N))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemStone(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.B))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemLogs(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
        }
    }

}

