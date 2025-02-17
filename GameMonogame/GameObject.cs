using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
internal class GameObject
 {
    private List<Component> Components = new List<Component>();

    private bool isComponentListDirty;

    public Vector2 position; 
    public T GetComponent<T>() where T : Component 
    {

        for (int i = 0; i < Components.Count; i++) 
        {

            if (Components[i] is T) 
            {
                return (T) Components[i];
            }                  
        }
        return null;
    }

    public T AddComponent<T> () where T : Component, new() 
    {
        T newComponent = new T();
        Components.Add(newComponent);
        newComponent.Initialize(this); 
        isComponentListDirty = true;    
        return newComponent;
    }

    public void Update(float deltaTime) 
    {

    }

    public void StartUnstartedComponents() 
    {
        if (!isComponentListDirty) 
        {
            return;
        }

        isComponentListDirty= false;/*
        for (int i = Components.Count - 1; i >= 0; i--) 
        {
            if (!Components[i].hasStarted) 
            {
                Components[i].ApllyStart(); 
            }
        } */ 
    }

    public virtual void Draw(SpriteBatch _spriteBatch) 
    {

    }


 }

