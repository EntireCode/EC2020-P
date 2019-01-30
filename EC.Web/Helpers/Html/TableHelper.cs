namespace EC.Web.Helpers.Html
{
    public class TableHelper
    {
        public static string PrepareScript(string tableId, string fileName, int columnCount, string templateScriptFile)
        {
            var scripts = System.IO.File.ReadAllText(templateScriptFile);
            scripts = scripts.Replace("{tableId}", tableId);
            scripts = scripts.Replace("{fileName}", fileName);
            string columnsArray = "[";
            for (var i = 0; i < columnCount - 1; i++)
            {
                columnsArray += string.Format("{0}, ", i);
            }
            columnsArray += string.Format("{0}]", columnCount - 1);
            scripts = scripts.Replace("{columnsArray}", columnsArray);
            return scripts;
        }
    }
}
