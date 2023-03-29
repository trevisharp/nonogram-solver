using System.Drawing;

using Pamella;

var view = new MainView();
App.Open(view);

public class MainView : View
{
    int i = 0;

    protected override void OnStart(IGraphics g)
    {
        g.SubscribeKeyDownEvent(key =>
        {
            if ((int)key == 27)
                App.Close();
        });
    }

    protected override void OnRender(IGraphics g)
    {
        g.Clear(Color.White);
        g.DrawText(new Rectangle(100 + (i % 200), 100, 100, 100),
            g.IsDown ? Brushes.Red : Brushes.Black,
            g.Cursor.ToString());
        i++;
        Invalidate();
    }
}