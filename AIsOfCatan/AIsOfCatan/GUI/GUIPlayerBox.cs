﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TroyXnaAPI;

namespace AIsOfCatan.GUI
{
    class GUIPlayerBox : TXADrawableComponent
    {
        public GUIPlayerBox(Vector2 position, Texture2D texture) : base(position, texture)
        {

        }

        protected override void DoUpdate(GameTime time)
        {
            throw new NotImplementedException();
        }
    }
}
