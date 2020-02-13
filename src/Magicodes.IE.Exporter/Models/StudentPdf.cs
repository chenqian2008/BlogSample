﻿using Magicodes.ExporterAndImporter.Core;
using Magicodes.ExporterAndImporter.Pdf;
using System;

namespace Magicodes.IE.Exporter.Models
{
    [PdfExporter(Name = "学生信息")]
    public class StudentPdf
    {
        /// <summary>
        ///     姓名
        /// </summary>
        [ExporterHeader(DisplayName = "姓名")]
        public string Name { get; set; }
        /// <summary>
        ///     年龄
        /// </summary>
        [ExporterHeader(DisplayName = "年龄")]
        public int Age { get; set; }
        /// <summary>
        ///     备注
        /// </summary>
        public string Remarks { get; set; }
        /// <summary>
        ///     出生日期
        /// </summary>
        [ExporterHeader(DisplayName = "出生日期", Format = "yyyy-mm-DD")]
        public DateTime Birthday { get; set; }
    }
}
