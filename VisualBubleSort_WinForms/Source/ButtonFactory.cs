namespace VisualBubleSort_WinForms.Source
{
    using System.Drawing;
    using System.Windows.Forms;

    public static class ButtonFactory
    {
        public static Color SelectedBorderColor = Color.Red;

        public static Color NormalBorderColor = Color.Black;

        public static int ButtonSize = 40;

        public static Button Create(int n, int pos)
        {
            var btn = new Button
            {
                Text = n.ToString(),
                Height = ButtonSize,
                Width = ButtonSize,
                Top = 62,
                Left = 10 + 45*pos,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = {BorderColor = NormalBorderColor, BorderSize = 2}
            };

            return btn;
        }
    }
}