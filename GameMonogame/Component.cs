using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal abstract class Component
{

    public GameObject gameObject { get; private set; }

    public void Initialize(GameObject _gameObject)
    {
        gameObject = _gameObject;
    }


    
}

