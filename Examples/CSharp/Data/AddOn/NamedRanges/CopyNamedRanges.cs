//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;
using System.Drawing;

namespace Aspose.Cells.Examples.Data.AddOn.NamedRanges
{
    public class CopyNamedRanges
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            // Create directory if it is not already present.
            bool IsExists = System.IO.Directory.Exists(dataDir);
            if (!IsExists)
                System.IO.Directory.CreateDirectory(dataDir);

            //Instantiate a new Workbook.
            Workbook workbook = new Workbook();

            //Get all the worksheets in the book.
            WorksheetCollection worksheets = workbook.Worksheets;

            //Get the first worksheet in the worksheets collection.
            Worksheet worksheet = workbook.Worksheets[0];

            //Create a range of cells.
            Range range1 = worksheet.Cells.CreateRange("E12", "I12");

            //Name the range.
            range1.Name = "MyRange";

            //Set the outline border to the range.
            range1.SetOutlineBorder(BorderType.TopBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128));
            range1.SetOutlineBorder(BorderType.BottomBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128));
            range1.SetOutlineBorder(BorderType.LeftBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128));
            range1.SetOutlineBorder(BorderType.RightBorder, CellBorderType.Medium, Color.FromArgb(0, 0, 128));

            //Input some data with some formattings into
            //a few cells in the range.
            range1[0, 0].PutValue("Test");
            range1[0, 4].PutValue("123");

            //Create another range of cells.
            Range range2 = worksheet.Cells.CreateRange("B3", "F3");

            //Name the range.
            range2.Name = "testrange";

            //Copy the first range into second range.
            range2.Copy(range1);

            //Save the excel file.
            workbook.Save(dataDir + "copyranges.xls");
        }
    }
}