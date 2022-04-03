class HelloWorld {
    static void Main() {
        int columnNumber = 27;
        string columnName = "";
        while (columnNumber > 0)
        {
            int modulo = (columnNumber - 1) % 26;
            columnName = Convert.ToChar('A' + modulo) + columnName;
            columnNumber = (columnNumber - modulo) / 26;
        }
        System.Console.WriteLine(columnName);
    }
}