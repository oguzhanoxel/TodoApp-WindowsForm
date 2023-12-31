﻿using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileManager
{
    public class ExcelFileManager<T>
    {
        private string filePath;
        private string sheetName;

        public ExcelFileManager(string filePath, string fileName, string sheetName)
        {
            this.filePath = Path.Combine(filePath, fileName + ".xlsx");
            this.sheetName = sheetName;

            using (var workbook = CreateOrGetWorkbook(this.filePath))
            {
                var worksheet = CreateOrGetWorksheet(workbook);

                var properties = typeof(T).GetProperties();

                for(int i = 0; i < properties.Length; i++)
                {
                    worksheet.Cell(1, i + 1).Value = properties[i].Name;
                }

                workbook.SaveAs(this.filePath);
            }
        }


        public void WriteDataToExcel(List<T> data)
        {
            using (var workbook = CreateOrGetWorkbook(filePath))
            {
                var properties = typeof(T).GetProperties();

                IXLWorksheet worksheet = CreateOrGetWorksheet(workbook);

                for (int i = 0; i < data.Count; i++)
                {
                    T item = data[i];

                    for (int j = 0; j < properties.Length; j++)
                    {
                        worksheet.Cell(i + 2, j + 1).Value = properties[j].GetValue(item).ToString();
                    }
                }

                workbook.SaveAs(filePath);
            }
        }

        public List<T> ReadDataFromExcel()
        {
            List<T> data = new List<T>();

            using (var workbook = new XLWorkbook(filePath))
            {
                var properties = typeof(T).GetProperties();

                IXLWorksheet worksheet = workbook.Worksheet(sheetName);
                IEnumerable<IXLRow> rows = worksheet.RowsUsed().Skip(1);

                foreach (IXLRow row in rows)
                {
                    T item = Activator.CreateInstance<T>();

                    for (int i = 0; i < properties.Length; i++)
                    {
                        var cellValue = row.Cell(i + 1).Value.ToString();
                        Type type = properties[i].PropertyType;
                        var propertyValue = Convert.ChangeType(cellValue, type);
                        properties[i].SetValue(item, propertyValue);
                    }

                    data.Add(item);
                }
            }
            return data;
        }

        public void DeleteExcelFile()
        {
            File.Delete(filePath);
        }

        private IXLWorkbook CreateOrGetWorkbook(string filePath)
        {
            if (File.Exists(filePath))
            {
                return new XLWorkbook(filePath);
            }

            return new XLWorkbook();
        }

        private IXLWorksheet CreateOrGetWorksheet(IXLWorkbook workbook)
        {
            if (workbook.Worksheets.Contains(sheetName))
            {
                return workbook.Worksheet(sheetName);
            }
            return workbook.Worksheets.Add(sheetName);
        }
    }
}
