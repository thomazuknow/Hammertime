using System;
using Hammertime.Core;
using Hammertime.GUI.Logic;

namespace GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.randomButton = new System.Windows.Forms.Button();
            this.directionLable = new System.Windows.Forms.Label();
            this.stepsLable = new System.Windows.Forms.Label();
            this.northButton = new System.Windows.Forms.Button();
            this.westButton = new System.Windows.Forms.Button();
            this.eastButton = new System.Windows.Forms.Button();
            this.southButton = new System.Windows.Forms.Button();
            this.direcionLabel = new System.Windows.Forms.Label();
            this.stepSlider = new System.Windows.Forms.NumericUpDown();
            this.stepLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.stepSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(79, 275);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(240, 119);
            this.randomButton.TabIndex = 0;
            this.randomButton.Text = "Randomize";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // directionLable
            // 
            this.directionLable.AutoSize = true;
            this.directionLable.Location = new System.Drawing.Point(525, 70);
            this.directionLable.Name = "directionLable";
            this.directionLable.Size = new System.Drawing.Size(125, 15);
            this.directionLable.TabIndex = 2;
            this.directionLable.Text = "DEBUG: directionLable";
            this.directionLable.Click += new System.EventHandler(this.DirectionLabel_Click);
            // 
            // stepsLable
            // 
            this.stepsLable.AutoSize = true;
            this.stepsLable.Location = new System.Drawing.Point(525, 131);
            this.stepsLable.Name = "stepsLable";
            this.stepsLable.Size = new System.Drawing.Size(105, 15);
            this.stepsLable.TabIndex = 3;
            this.stepsLable.Text = "DEBUG: stepsLable";
            // 
            // northButton
            // 
            this.northButton.Location = new System.Drawing.Point(163, 62);
            this.northButton.Name = "northButton";
            this.northButton.Size = new System.Drawing.Size(75, 23);
            this.northButton.TabIndex = 4;
            this.northButton.Text = "NORTH";
            this.northButton.UseVisualStyleBackColor = true;
            this.northButton.Click += new System.EventHandler(this.NorthButton_Click);
            // 
            // westButton
            // 
            this.westButton.Location = new System.Drawing.Point(79, 101);
            this.westButton.Name = "westButton";
            this.westButton.Size = new System.Drawing.Size(75, 23);
            this.westButton.TabIndex = 5;
            this.westButton.Text = "WEST";
            this.westButton.UseVisualStyleBackColor = true;
            this.westButton.Click += new System.EventHandler(this.WestButton_Click);
            // 
            // eastButton
            // 
            this.eastButton.Location = new System.Drawing.Point(254, 101);
            this.eastButton.Name = "eastButton";
            this.eastButton.Size = new System.Drawing.Size(75, 23);
            this.eastButton.TabIndex = 6;
            this.eastButton.Text = "EAST";
            this.eastButton.UseVisualStyleBackColor = true;
            this.eastButton.Click += new System.EventHandler(this.EastButton_Click);
            // 
            // southButton
            // 
            this.southButton.Location = new System.Drawing.Point(163, 145);
            this.southButton.Name = "southButton";
            this.southButton.Size = new System.Drawing.Size(75, 23);
            this.southButton.TabIndex = 7;
            this.southButton.Text = "SOUTH";
            this.southButton.UseVisualStyleBackColor = true;
            this.southButton.Click += new System.EventHandler(this.SouthButton_Click);
            // 
            // direcionLabel
            // 
            this.direcionLabel.AutoSize = true;
            this.direcionLabel.Location = new System.Drawing.Point(387, 62);
            this.direcionLabel.Name = "direcionLabel";
            this.direcionLabel.Size = new System.Drawing.Size(0, 15);
            this.direcionLabel.TabIndex = 8;
            // 
            // stepSlider
            // 
            this.stepSlider.Location = new System.Drawing.Point(12, 21);
            this.stepSlider.Name = "stepSlider";
            this.stepSlider.Size = new System.Drawing.Size(40, 23);
            this.stepSlider.TabIndex = 9;
            this.stepSlider.ValueChanged += new System.EventHandler(this.stepSlider_ValueChanged_1);
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Location = new System.Drawing.Point(12, 3);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(87, 15);
            this.stepLabel.TabIndex = 10;
            this.stepLabel.Text = "Max Antal Steg";
            this.stepLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(427, 275);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
           
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            //
            //ButtonGrid
            //
            this.CreateButtonGrid(5,5);
            //
            //other stuff
            //
            this.stepSlider.Value = 6; //initzial roll value
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.stepSlider);
            this.Controls.Add(this.direcionLabel);
            this.Controls.Add(this.southButton);
            this.Controls.Add(this.eastButton);
            this.Controls.Add(this.westButton);
            this.Controls.Add(this.northButton);
            this.Controls.Add(this.stepsLable);
            this.Controls.Add(this.directionLable);
            this.Controls.Add(this.randomButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stepSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Board Board = null;

        private void CreateButtonGrid(int height, int width)
        {
            this.Board = new Board(height, width);


            for (int i = 0; i < this.Board.Height; i++)
            {
                for (int j = 0; j < this.Board.Width; j++)
                {
                    var tile = this.Board.Tiles[i, j];
                    var button = new System.Windows.Forms.Button();

                    button.Name = tile.Name;
                    button.Text = tile.Text;
                    button.Size = new System.Drawing.Size(this.Board.ButtonWidth, this.Board.ButtonHeight);
                    button.Location = new System.Drawing.Point(tile.x, tile.y);
                    button.Click += new System.EventHandler(this.grid_Click);
                    this.flowLayoutPanel1.Controls.Add(button);


                }

            }

            this.flowLayoutPanel1.Size = new System.Drawing.Size(this.Board.PixelWidth, this.Board.PixelHeight);
            this.flowLayoutPanel1.TabIndex = 11;

            //string[] hightKey = {"1", "2", "3" , "4", "5", "6", "7", "8", "9", "10",
            //                     "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" ,};

            ////A B C D E F G H I J K L M N O P Q R S T U V W X Y Z
            //string[] widthKey = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
            //                     "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

            //if(height > hightKey.Length)
            //    throw new ArgumentException($"High is to big, exceedes the max of [{hightKey.Length}]");

            //if(width > widthKey.Length)
            //    throw new ArgumentException($"Width is to big, exceedes the max of [{widthKey.Length}]");



            //// flowLayoutPanel1
            //// 
            //this.flowLayoutPanel1.Location = new System.Drawing.Point(417, 231);
            //this.flowLayoutPanel1.Name = "flowLayoutPanel1";





            //var buttonHight = 30;
            //var buttonWidth = 30;
            //var posXSpace = 3;
            //var posYSpace = 3;

            //var totalHight = (buttonHight * height) + ((3+posYSpace)*height);
            //var totalWidth = (buttonWidth * width) + ((3+posXSpace) * height);

            //var board = new string[height, width];

            //for (int i = 0; i < height; i++)
            //{
            //    var hightValue = hightKey[i];
            //    for (int j = 0; j < width; j++)
            //    {
            //        var widthValue = widthKey[j];
            //        var key = hightValue + widthValue;
            //        board[height-1, width-1] = key;
            //        var button = new System.Windows.Forms.Button();
            //        button.Name = key;
            //        button.Text = key;
            //        button.Size = new System.Drawing.Size(buttonWidth, buttonHight);

            //        var xPos = (buttonWidth * j) + posXSpace; // →
            //        var yPos = (buttonHight * i) + posYSpace; // ↑
            //        var x = xPos; 
            //        var y = yPos;

            //       // totalHight += yPos;
            //       // totalWidth += xPos;

            //        button.Location = new System.Drawing.Point(x, y);
            //        button.Click += new System.EventHandler(this.grid_Click); 
            //        this.flowLayoutPanel1.Controls.Add(button);

            //    }



            //}

            //this.flowLayoutPanel1.Size = new System.Drawing.Size(totalWidth, totalHight);
            //this.flowLayoutPanel1.TabIndex = 11;


        }




        #endregion

        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Label directionLable;
        private System.Windows.Forms.Label stepsLable;
        private System.Windows.Forms.Button northButton;
        private System.Windows.Forms.Button westButton;
        private System.Windows.Forms.Button eastButton;
        private System.Windows.Forms.Button southButton;
        private System.Windows.Forms.Label direcionLabel;
        private System.Windows.Forms.NumericUpDown stepSlider;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

