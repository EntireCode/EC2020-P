using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChartJSCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EC.Web.Areas.Admin.Pages.Dashboard
{
    public class IndexModel : PageModel
    {
        public Chart FirstChart { get; set; }

        public void OnGet()
        {
            Chart chart = new Chart();
            chart.Type = "line";
            ChartJSCore.Models.Data data = new ChartJSCore.Models.Data();
            data.Labels = new List<string> {
                "January", "February", "March", "April", "May", "June", "July"
            };

            LineDataset firstDataset = new LineDataset
            {               
                Label = "First",
                Data = new List<double>() { 65, 59, 80, 81, 56, 55, 40 },
                Fill = "origin",
                LineTension = 0.1,
                BackgroundColor = "rgba(255, 0, 0, 0.4)",
                BorderColor = "rgba(255, 0, 0, 0.8)",
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<string>() { "rgba(255, 0, 0, 1)" },
                PointBackgroundColor = new List<string>() { "#fff" },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<string>() { "rgba(255, 0, 0, 1)" },
                PointHoverBorderColor = new List<string>() { "rgba(220,220,220,1)" },
                PointHoverBorderWidth = new List<int> { 2 },
                PointRadius = new List<int> { 1 },
                PointHitRadius = new List<int> { 10 },
                SpanGaps = false
            };

            LineDataset secondDataset = new LineDataset
            {
                Label = "Second",
                Data = new List<double>() { 165, 159, 180, 181, 156, 155, 140 },
                Fill = "-1",
                LineTension = 0.1,
                BackgroundColor = "rgba(75, 192, 192, 0.4)",
                BorderColor = "rgba(75,192,192,1)",
                BorderCapStyle = "butt",
                BorderDash = new List<int> { },
                BorderDashOffset = 0.0,
                BorderJoinStyle = "miter",
                PointBorderColor = new List<string>() { "rgba(75,192,192,1)" },
                PointBackgroundColor = new List<string>() { "#fff" },
                PointBorderWidth = new List<int> { 1 },
                PointHoverRadius = new List<int> { 5 },
                PointHoverBackgroundColor = new List<string>() { "rgba(75,192,192,1)" },
                PointHoverBorderColor = new List<string>() { "rgba(220,220,220,1)" },
                PointHoverBorderWidth = new List<int> { 2 },
                PointRadius = new List<int> { 1 },
                PointHitRadius = new List<int> { 10 },
                SpanGaps = false
            };

            data.Datasets = new List<Dataset>();
            data.Datasets.Add(firstDataset);
            data.Datasets.Add(secondDataset);
            chart.Data = data;

            FirstChart = chart;
        }
    }
}