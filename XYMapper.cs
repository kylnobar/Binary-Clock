using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Binary_Clock
{
    class XYMapper
    {
        private int bit1Pos = 212;
        private int bit2Pos = 148;
        private int bit4Pos = 84;
        private int bit8Pos = 20;
        public void DrawPips(int digit, int xCoordinate, SpriteBatch spriteBatch, Texture2D pipTexture)
        {
            //digit = 11;  //Uncomment to turn all pips on

            switch (digit)
            {
                case 0:
                    break;

                case 1:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit1Pos), Color.White);
                    break;

                case 2:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit2Pos), Color.White);
                    break;

                case 3:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit2Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit1Pos), Color.White);
                    break;

                case 4:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit4Pos), Color.White);
                    break;

                case 5:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit4Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit1Pos), Color.White);
                    break;

                case 6:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit4Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit2Pos), Color.White);
                    break;

                case 7:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit4Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit2Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit1Pos), Color.White);
                    break;

                case 8:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit8Pos), Color.White);
                    break;

                case 9:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit8Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit1Pos), Color.White);
                    break;

                default:
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit8Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit4Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit2Pos), Color.White);
                    spriteBatch.Draw(pipTexture, new Vector2(xCoordinate, bit1Pos), Color.White);
                    break;
            }

        }

        public int getLeftDigit(int number)
        {
            return number / 10;
        }

        public int getRightDigit(int number)
        {
            return number % 10;
        }
    }
}
