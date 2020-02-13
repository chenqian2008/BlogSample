﻿// <auto-generated/>
#pragma warning disable 1591
namespace CompiledRazorTemplates.Dynamic
{
#line hidden
    using System.Threading.Tasks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data;
    internal class RazorEngine_ae63066fb563485ea63edec41beb440f : RazorEngine.Templating.TemplateBase<dynamic>
    {
#pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!DOCTYPE html>

<html lang=""en"" xmlns=""http://www.w3.org/1999/xhtml"">

<head>
    <meta charset=""utf-8""/>
    <title></title>
    <style type=""text/css"">
        footer {
            border-top: 1px solid #e4e4e4;
            color: #999;
            font-size: 0.8rem;
            margin-bottom: 1.5rem;
            margin-top: 3rem;
            padding-top: 1rem;
            text-align: center;
        }

        table,
        th,
        td {
            border: 1px solid #cccccc;
            border-collapse: collapse;
            height: 2rem;
            padding: 5px;
            padding-left: 1%;
        }

        table tr:nth-child(odd) { background-color: #ffffff; }

        table tr:nth-child(even) { background-color: #f5f6ff; }

        table,
        thead { background-color: #617af8 !important; }
    </style>
</head>
<body>
<h1 style=""margin-top: 2rem; text-align: center;"">");
            Write(Model.Title);
            WriteLiteral("</h1>\r\n\r\n<table width=\"90%\" style=\"margin-left: 5%;\">\r\n    <thead>\r\n    <tr style=\"background-color: #617af8 !important; color: #010c13; font-weight: bold; height: 3.5rem; text-align: left;\">\r\n");
            foreach (var header in Model.Headers)
            {
                WriteLiteral("            <th>");
                Write(header.DisplayName);
                WriteLiteral("</th>\r\n");
            }
            WriteLiteral("    </tr>\r\n    </thead>\r\n");

            DataTable dt = Model.ToDataTable();
            WriteLiteral("    ");
            foreach (DataRow dr in dt.Rows)
            {
                WriteLiteral("        <tr>\r\n");
                for (var i = 0; i < dt.Columns.Count; i++)
                {
                    WriteLiteral("                <td>");
                    Write(dr[i]);
                    WriteLiteral("</td>\r\n");
                }
                WriteLiteral("        </tr>\r\n");
            }
            WriteLiteral("\r\n</table>\r\n<footer>\r\n    by Magicodes.IE\r\n</footer>\r\n</body>\r\n</html>");
        }
#pragma warning restore 1998
    }
}
#pragma warning restore 1591
