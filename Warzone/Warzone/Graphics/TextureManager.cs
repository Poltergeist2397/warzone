using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Warzone.Graphics
{
    public class TextureManager
    {
        private static Dictionary<String, Texture2D> textures = new Dictionary<string, Texture2D>();

        public static void LoadTextures(ContentManager txld)
        {
            textures.Add("Arrow", txld.Load<Texture2D>("arrow"));
        }
        
        /// <summary>
        /// Retrieves the Texture2D with the specified name
        /// </summary>
        /// <param name="name"> The internal name of the texture </param>
        /// <returns> A texture, or a generic one if that didn't exist </returns>
        public static Texture2D GetTexture(String name)
        {
            if (!textures.ContainsKey(name))
                return null;
            return textures[name];
        }
    }
}
