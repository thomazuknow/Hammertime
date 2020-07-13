using System;
using System.Collections.Generic;
using System.Text;

namespace Hammertime.GUI.Logic
{
    /// <summary>
    /// ##############
    /// #
    /// #
    /// #
    /// #
    /// Y
    /// #X############
    /// </summary>
    public class Board
    {
        private static readonly string[] HeightVales = {"1", "2", "3" , "4", "5", "6", "7", "8", "9", "10",
            "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", };


        private static readonly string[] WidthValues = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};


        public readonly Tile[,] Tiles;
        public  Dictionary<string, (int x, int y)> TileDictionary;
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int PixelHeight { get; }
        public int PixelWidth { get; }
        private readonly int SpaceForX = 3;
        private readonly int SpaceForY = 3;
        public readonly int ButtonHeight = 30;
        public readonly int ButtonWidth = 30;


        public Board(int boardHeight, int boardWidth, int space, int buttonHeight, int buttonWidth)
        {
            this.SpaceForY = space;
            this.SpaceForX = space;
            this.ButtonHeight = buttonHeight;
            this.ButtonWidth = buttonWidth;
            new Board(boardHeight, boardWidth);
        }


        public Board(int boardHeight, int boardWidth)
        {

            if (boardHeight > HeightVales.Length)
                throw new ArgumentException($"High is to big, exceedes the max of [{HeightVales.Length}]");

            if (boardWidth > WidthValues.Length)
                throw new ArgumentException($"Width is to big, exceedes the max of [{WidthValues.Length}]");

            this.Height = boardHeight;
            this.Width = boardWidth;
            // total board in pixels
            this.PixelHeight = (this.ButtonHeight * this.Height) + ((3 + this.SpaceForY) * this.Height);
            this.PixelWidth = (this.ButtonWidth * this.Width) + ((3 + this.SpaceForX) * this.Width);

            this.TileDictionary = new Dictionary<string, (int x, int y)>();



            // fill Board with Tiles
            this.Tiles = new Tile[this.Height, this.Width];


            for (int i = 0; i < this.Height; i++)
            {
                var heightText = HeightVales[i];
                for (int j = 0; j < this.Width; j++)
                {
                    var widthText = WidthValues[j];
                    var key = heightText + widthText;

                    // tile position
                    var x = (this.ButtonHeight * j) + this.SpaceForX; // →;
                    var y = (this.ButtonWidth * i) + this.SpaceForY; // ↑;

                    
                    


                    // move this to its own method were we can check if tiles already exist
                    // add new tile to array
                    this.Tiles[i, j] = new Tile
                    {
                        Name = key,
                        Text = key,
                        x = x,
                        y = y
                    };
                    this.TileDictionary.Add(key, (i, j));
                    
                }
            }
        }
    }
}
