﻿using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMaaS.Core.Sdk.Excel.Abstractions
{
    public interface IExcel
    {
        object Run(string udfName, object parameters, ExcelFunc func);
        ExcelReference Call(int excelFunction);
    }
}
