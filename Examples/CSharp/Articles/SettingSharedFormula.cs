//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Cells. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Cells;

namespace Aspose.Cells.Examples.Articles
{
    public class SettingSharedFormula
    {
        public static void Main()
        {
            // The path to the documents directory.
            string dataDir = Aspose.Cells.Examples.Utils.GetDataDir(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            
            string filePath = dataDir+ "input.xlsx";

         //Instantiate a Workbook from existing file
         Workbook workbook = new Workbook(filePath);

        //Get the cells collection in the first worksheet
        Cells cells = workbook.Worksheets[0].Cells;

        //Apply the shared formula in the range i.e.., B2:B14
        cells["B2"].SetSharedFormula("=A2*0.09", 13, 1);

        //Save the excel file
        workbook.Save(dataDir+ ".out.xlsx", SaveFormat.Xlsx);
            
        }
    }
}