/*
 *  Nick Muldrew
 *  OOSD Assignment 1, Gray Scott Simulator.
 */
using MULDND1Assignment1.Shading_Factory;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULDND1Assignment1
{
    /*
     * GridDrawer is used to Save the CellGrid as a file in a Directory or display it on the screen.
     * Uses ShadingFactory to choose what type of Shading algorthim should be used to shade the grid.
     */
    public class GridDrawer
    {
        //DataFields
        private Cell[,] Grid;
        private Graphics canvas;
        private IShading ShadingAlgorithm;
        private ShadingFactory shadingFactory;
        private int Width;
        private int Height;
        private Bitmap bitmap;
        private const string directory = "../../images/";
        private const string fileType = ".bmp";

        /*
         * GridDrawer constructer takes in various parameters then sets them to setup the GridDrawer.
         */
        public GridDrawer(Graphics canvas, int Width, int Height, EShadingAlgorthims shadingEnum)
        {
            this.canvas = canvas;
            this.Width = Width;
            this.Height = Height;
            shadingFactory = new ShadingFactory();                              //Creates an instance of ShadingFactory
            ShadingAlgorithm = shadingFactory.CreateNewShadeing(shadingEnum);   //calls the CreateNewShadeing method of ShadingFactory to return the ShadingAlgorithm requested.
        }

        /*
         * SetGrid is used to copy the grid over from the manager class.
         */
        public void SetGrid(Cell[,] Grid)
        {
            this.Grid = new Cell[Width, Height];
            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    this.Grid[row, col] = Grid[row, col];
                }
            }
        }

        /*
         * CreateBitmap is used to create a bitmap the same size as the CellGrid being used.
         * It then loops through the CellGrid using the ShadingAlgorthim.CalculateColor method to get the color.
         * Then bitmap then gets a pixel drawn at the location with the calculated color.
         * The Bitmap is created no by default because its needed to be drawn to the canvas or saved to file.
         */
        public void CreateBitmap()
        {
            Color color;
            bitmap = new Bitmap(Width, Height);         //Sets the Bitmap to the Width and height of the CellGrid

            for (int row = 0; row < Height; row++)
            {
                for (int col = 0; col < Width; col++)
                {
                    color = ShadingAlgorithm.CalculateColor(Grid[row, col].A);          //Calculates the Color needed from the current shadingAlgorthim.
                    bitmap.SetPixel(Grid[row, col].XPos, Grid[row, col].YPos, color);   //Sets the pixel with the color at the Cells XPos and YPos.
                }
            }            
        }

        /*
         * DrawToCanvas is used to draw the Bitmap representing the grid to the Canvas.
         */
        public void DrawToCanvas()
        {
            CreateBitmap();                     //method call to create the Bitmap needed to draw to the canvas.
            canvas.DrawImage(bitmap, 0, 0);
        }
        
        /*
         * SaveFile is passed in the FileName which holds various information about the Current Grid.
         * The method call to create the bitmap is made then the bitmap is saved in a directory.
         */
        public void SaveFile(String FileName)
        {
            CreateBitmap();
            Bitmap bp = new Bitmap(bitmap);             //New bitmap created using the other Grid Bitmap to help prevent errors
            bp.Save(directory + FileName + fileType);   //A string is passed to the save method consisting of the directory, filename and the filetype to save the Bitmap.
        }
    }
}
