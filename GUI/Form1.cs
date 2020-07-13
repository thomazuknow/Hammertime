using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hammertime.Core;
using Hammertime.GUI.Logic;

namespace GUI
{
    public partial class Form1 : Form
    {
        public readonly Navigator navigator;
        public readonly List<Direction> currentDirections;
        public Form1()
        {
            var randomizer = new Randomizer();
            this.navigator = new Navigator(randomizer);
            this.currentDirections = new List<Direction>();

            InitializeComponent();
            this.ValidRandomButtonControl();

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            var stepValue = (int)Math.Floor(this.stepSlider.Value);

            var navi = this.navigator.GetDirections(this.currentDirections, stepValue);

            string ad = $"{navi.Direction} :: {navi.Steps}";

            this.directionLable.Text = $"{navi.Direction}";
            this.stepsLable.Text = $"{navi.Steps}";
        }

        private void DirectionLabel_Click(object sender, EventArgs e)
        {

        }

        private void NorthButton_Click(object sender, EventArgs e)
        {
            this.AddOrRemoveDirection(Direction.North);
            this.SetDirectionLabel();
        }

        private void WestButton_Click(object sender, EventArgs e)
        {
            this.AddOrRemoveDirection(Direction.West);
            this.SetDirectionLabel();
        }

        private void EastButton_Click(object sender, EventArgs e)
        {
            this.AddOrRemoveDirection(Direction.East);
            this.SetDirectionLabel();
        }

        private void SouthButton_Click(object sender, EventArgs e)
        {
            this.AddOrRemoveDirection(Direction.South);
            this.SetDirectionLabel();
        }

        private void SetDirectionLabel()
        {
            this.direcionLabel.Text = "";
            foreach (var d in this.currentDirections)
                this.direcionLabel.Text += $"{d}\r";

        }

        private void ValidRandomButtonControl()
        {
            if (this.currentDirections.Any())
                this.EnableRandomButton();
            else
                this.DisableRandomButton();

        }

        private void EnableRandomButton()
        {
            this.randomButton.Enabled = true;
        }

        private void DisableRandomButton()
        {
            this.randomButton.Enabled = false;
        }

        private void AddOrRemoveDirection(Direction direction)
        {
            if (this.currentDirections.Contains(direction))
                this.currentDirections.Remove(direction);
            else
                this.currentDirections.Add(direction);

            this.ValidRandomButtonControl();

        }

        private void grid_Click(object sender, EventArgs e)
        {
            var s = GetPropertyValue<string>(sender, "Text");

            var tileKey = this.Board.TileDictionary[s];
            var tile = this.Board.Tiles[tileKey.x, tileKey.y];
            var button = this.flowLayoutPanel1.Controls[s];
            this.ChangeTile(tile, button);
            //button.BackColor = Color.BurlyWood;
        }

        private void ChangeTile(Tile tile, Control button)
        {
            switch (tile.TileType)
            {
                case TileType.Front:
                    tile.ChangeType(TileType.Flipped);
                    this.SetTileColorByType(TileType.Flipped, button);
                    break;
                case TileType.Flipped:
                    tile.ChangeType(TileType.Front);
                    this.SetTileColorByType(TileType.Front, button);
                    break;
            }


        }

        private void SetTileColorByType(TileType tileType, Control button)
        {

            switch (tileType)
            {
                case TileType.Front: //{255, 240, 240, 240}
                    button.BackColor =  Color.FromArgb(255, 240, 240, 240);
                    break;
                case TileType.Flipped:
                    button.BackColor = Color.BurlyWood;
                    break;

            }


        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stepSlider_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public static T GetPropertyValue<T>(object obj, string propName)
        {
            return (T)obj.GetType().GetProperty(propName).GetValue(obj, null);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
