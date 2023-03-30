using System.Collections.Generic;
using System.Drawing;

using Pamella;

var view = new MainView();
App.Open(view);

public class MainView : View
{
    Nonogram nono;
    RectangleF nonoRect;

    protected override void OnStart(IGraphics g)
    {
        g.SubscribeKeyDownEvent(key =>
        {
            if (key == System.Windows.Forms.Keys.Escape)
                App.Close();
            
            if (key == System.Windows.Forms.Keys.Space)
                nono.Solve();
        });

        this.nono = new Nonogram(25);

        float side = .8f * g.Height;
        this.nonoRect = new RectangleF(
            (g.Width - side) / 2,
            (g.Height - side) / 2,
            side, side
        );

        nono.HorizontalAdd(7, 3, 1, 1, 7);
        nono.HorizontalAdd(1, 1, 2, 2, 1, 1);
        nono.HorizontalAdd(1, 3, 1, 3, 1, 1, 3, 1);
        nono.HorizontalAdd(1, 3, 1, 1, 6, 1, 3, 1);
        nono.HorizontalAdd(1, 3, 1, 5, 2, 1, 3, 1);
        nono.HorizontalAdd(1, 1, 2, 1, 1);
        nono.HorizontalAdd(7, 1, 1, 1, 1, 1, 7);
        nono.HorizontalAdd(3, 3);
        nono.HorizontalAdd(1, 2, 3, 1, 1, 3, 1, 1, 2);
        nono.HorizontalAdd(1, 1, 3, 2, 1, 1);
        nono.HorizontalAdd(4, 1, 4, 2, 1, 2);
        nono.HorizontalAdd(1, 1, 1, 1, 1, 4, 1, 3);
        nono.HorizontalAdd(2, 1, 1, 1, 2, 5);
        nono.HorizontalAdd(3, 2, 2, 6, 3, 1);
        nono.HorizontalAdd(1, 9, 1, 1, 2, 1);
        nono.HorizontalAdd(2, 1, 2, 2, 3, 1);
        nono.HorizontalAdd(3, 1, 1, 1, 1, 5, 1);
        nono.HorizontalAdd(1, 2, 2, 5);
        nono.HorizontalAdd(7, 1, 2, 1, 1, 1, 3);
        nono.HorizontalAdd(1, 1, 2, 1, 2, 2, 1);
        nono.HorizontalAdd(1, 3, 1, 4, 5, 1);
        nono.HorizontalAdd(1, 3, 1, 3, 10, 2);
        nono.HorizontalAdd(1, 3, 1, 1, 6, 6);
        nono.HorizontalAdd(1, 1, 2, 1, 1, 2);
        nono.HorizontalAdd(7, 2, 1, 2, 5);

        nono.VerticalAdd(7, 2, 1, 1, 7);
        nono.VerticalAdd(1, 1, 2, 2, 1, 1);
        nono.VerticalAdd(1, 3, 1, 3, 1, 3, 1, 3, 1);
        nono.VerticalAdd(1, 3, 1, 1, 5, 1, 3, 1);
        nono.VerticalAdd(1, 3, 1, 1, 4, 1, 3, 1);
        nono.VerticalAdd(1, 1, 1, 2, 1, 1);
        nono.VerticalAdd(7, 1, 1, 1, 1, 1, 7);
        nono.VerticalAdd(1, 1, 3);
        nono.VerticalAdd(2, 1, 2, 1, 8, 2, 1);
        nono.VerticalAdd(2, 2, 1, 2, 1, 1, 1, 2);
        nono.VerticalAdd(1, 7, 3, 2, 1);
        nono.VerticalAdd(1, 2, 3, 1, 1, 1, 1, 1);
        nono.VerticalAdd(4, 1, 1, 2, 6);
        nono.VerticalAdd(3, 3, 1, 1, 1, 3, 1);
        nono.VerticalAdd(1, 2, 5, 2, 2);
        nono.VerticalAdd(2, 2, 1, 1, 1, 1, 1, 2, 1);
        nono.VerticalAdd(1, 3, 3, 2, 1, 8, 1);
        nono.VerticalAdd(6, 2, 1);
        nono.VerticalAdd(7, 1, 4, 1, 1, 3);
        nono.VerticalAdd(1, 1, 1, 1, 4);
        nono.VerticalAdd(1, 3, 1, 3, 7, 1);
        nono.VerticalAdd(1, 3, 1, 1, 1, 2, 1, 1, 4);
        nono.VerticalAdd(1, 3, 1, 4, 3, 3);
        nono.VerticalAdd(1, 1, 2, 2, 2, 6, 1);
        nono.VerticalAdd(7, 1, 3, 2, 1, 1);

        nono.AddUnknowBlack(3, 3);
        nono.AddUnknowBlack(4, 3);
        nono.AddUnknowBlack(12, 3);
        nono.AddUnknowBlack(13, 3);
        nono.AddUnknowBlack(21, 3);

        nono.AddUnknowBlack(6, 8);
        nono.AddUnknowBlack(7, 8);
        nono.AddUnknowBlack(10, 8);
        nono.AddUnknowBlack(14, 8);
        nono.AddUnknowBlack(15, 8);
        nono.AddUnknowBlack(18, 8);

        nono.AddUnknowBlack(6, 16);
        nono.AddUnknowBlack(11, 16);
        nono.AddUnknowBlack(16, 16);
        nono.AddUnknowBlack(20, 16);

        nono.AddUnknowBlack(3, 21);
        nono.AddUnknowBlack(4, 21);
        nono.AddUnknowBlack(9, 21);
        nono.AddUnknowBlack(10, 21);
        nono.AddUnknowBlack(15, 21);
        nono.AddUnknowBlack(20, 21);
        nono.AddUnknowBlack(21, 21);
    }

    protected override void OnRender(IGraphics g)
    {
        g.Clear(Color.White);
        
        nono.Draw(nonoRect, g);

        Invalidate();
    }
}

public class Nonogram
{
    private const byte WHITE = 255;
    private const byte UNKNOWBLACK = 254;
    private const byte BASELINE = 128;
    private const byte UNKNOW = 0;

    private int size;
    private byte[] data;
    private List<byte[]> horRules;
    private List<byte[]> verRules;

    public byte this[int i, int j]
    {
        get => data[i + j * size];
        set => data[i + j * size] = value;
    }

    public Nonogram(int size)
    {
        this.size = size;
        this.data = new byte[size * size];
        this.horRules = new List<int[]>();
        this.verRules = new List<int[]>();
    }

    public void HorizontalAdd(params byte[] arr)
        => this.horRules.Add(arr);
    
    public void VerticalAdd(params byte[] arr)
        => this.verRules.Add(arr);
    
    public void AddUnknowBlack(int i, int j)
        => this[i, j] = UNKNOWBLACK;

    public void Draw(RectangleF rect, IGraphics g)
    {
        RectangleF mainRect = new RectangleF(
            rect.X - .2f * rect.Width,
            rect.Y - .2f * rect.Height,
            rect.Width,
            rect.Height
        );

        float square = rect.Width / size;

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                var value = this.data[i + size * j];

                g.FillRectangle(
                    rect.X + i * square,
                    rect.Y + j * square,
                    square, square,
                    value switch
                    {
                        0 => Brushes.Gray,
                        255 => Brushes.White,
                        _ => Brushes.Black
                    }
                );
                
                g.DrawRectangle(
                    rect.X + i * square,
                    rect.Y + j * square,
                    square, square,
                    Pens.Black
                );
            }
        }
    }

    public void Solve()
    {
        for (int line = 0; line < size; line++)
            minMaxSolutionLineInterseption(line);
        
        for (int column = 0; column < size; column++)
            minMaxSolutionColumnInterseption(column);
    }

    private void minMaxSolutionColumnInterseption(int column)
    {
        var rule = verRules[column];
        if (rule.Length == 0)
        {
            for (int i = 0; i < size; i++)
                this[column, i] = WHITE;
            return;
        }

        byte[] left = new byte[size];
        byte[] right = new byte[size];
        for (int i = 0; i < size; i++)
        {
            left[i] = this[column, i];
            right[i] = this[column, i];
        }

        int s = 0;
        for (int j = 0; j < rule.Length; j++)
        {
            var color = (byte)(j + 1);

            bool hasSpace = testSpace(left, s, rule[j], color);
            if (!hasSpace)
                continue;
            
            for (int k = 0; k < rule[j]; k++, s++)
                left[s] = color;
            
            s++;
        }
        
        s = size - 1;
        for (int j = rule.Length - 1; j >= 0; j--)
        {
            var color = (byte)(j + 1);

            bool hasSpace = testSpace(right, s - rule[j], rule[j], color);
            if (!hasSpace)
                continue;
            
            for (int k = 0; k < rule[j]; k++, s--)
                right[s] = color;
            
            s--;
        }

        for (int i = 0; i < size; i++)
        {
            if (left[i] == right[i])
                this[i, column] = left[i];
        }
    }

    private void minMaxSolutionLineInterseption(int line)
    {
        var rule = horRules[line];
        if (rule.Length == 0)
        {
            for (int i = 0; i < size; i++)
                this[i, line] = WHITE;
            return;
        }

        byte[] left = new byte[size];
        byte[] right = new byte[size];
        for (int i = 0; i < size; i++)
        {
            left[i] = this[i, line];
            right[i] = this[i, line];
        }

        int s = 0;
        for (int j = 0; j < rule.Length; j++)
        {
            var color = (byte)(j + 1);

            bool hasSpace = testSpace(left, s, rule[j], color);
            if (!hasSpace)
                continue;
            
            for (int k = 0; k < rule[j]; k++, s++)
                left[s] = color;
            
            s++;
        }
        
        s = size - 1;
        for (int j = rule.Length - 1; j >= 0; j--)
        {
            var color = (byte)(j + 1);

            bool hasSpace = testSpace(right, s - rule[j], rule[j], color);
            if (!hasSpace)
                continue;
            
            for (int k = 0; k < rule[j]; k++, s--)
                right[s] = color;
            
            s--;
        }

        for (int i = 0; i < size; i++)
        {
            if (left[i] == right[i])
                this[i, line] = left[i];
        }
    }

    private byte[] minSolution(byte[] data, byte[] rule)
    {
        byte[] solution = new byte[size];

        int s = 0;
        for (int j = 0; j < rule.Length; j++)
        {
            var color = (byte)(j + 1);

            bool hasSpace = testSpace(solution, s, rule[j], color);
            if (!hasSpace)
                continue;
            
            for (int k = 0; k < rule[j]; k++, s++)
                solution[s] = color;
            
            s++;
        } 

        return solution;
    }

    private bool testSpace(byte[] arr, int start, int needSpace, byte crrColor)
    {
        if (start < 0)
            return false;

        if (start + needSpace > arr.Length)
            return false;

        for (int i = start; i < needSpace; i++)
            if (arr[i] != crrColor && arr[i] != UNKNOW && arr[i] != UNKNOWBLACK)
                return false;
            
        return true;
    }
}